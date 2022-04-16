using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MODBUS_CRC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            Int32 str_id = Int32.Parse(txt_id.Text); // id
            Int32 str_func = Int32.Parse(combo_func.Text);// function
            Int32 str_end = Int32.Parse(txt_end.Text);// start adress
            UInt32 str_dados = UInt32.Parse(txt_dados.Text);// 

            byte slaveAddress = (byte) str_id;
            byte function = (byte) str_func; 
            ushort startAddress = (ushort)str_end; // 10 decimal = A hexa
            uint numberOfPoints = str_dados; // 13 decimal = D hexa

           


            byte[] frame = new byte[8];
            frame[0] = slaveAddress;			    // Slave Address
            frame[1] = function;				    // Function             
            frame[2] = (byte)(startAddress >> 8);	// Starting Address High
            frame[3] = (byte)startAddress;		    // Starting Address Low            
            frame[4] = (byte)(numberOfPoints >> 8);	// Quantity of Coils High
            frame[5] = (byte)numberOfPoints;		// Quantity of Coils Low
            byte[] crc = this.CalculateCRC(frame);  // Calculate CRC.
            frame[frame.Length - 2] = crc[0];       // Error Check Low
            frame[frame.Length - 1] = crc[1];       // Error Check High


            byte[] sobyte = { frame[0], frame[1], frame[2], frame[3], frame[4], frame[5] };

            string mensagem_sem = BitConverter.ToString(sobyte);
            mensagem_sem = mensagem_sem.Replace("-", "");
            string result = BitConverter.ToString(frame);
            result = result.Replace("-", "");
           
            txt_msg.Text = result ;
            txt_msg_Sem.Text = mensagem_sem;


        }

        private byte[] CalculateCRC(byte[] data)
        {
            ushort CRCFull = 0xFFFF; // Set the 16-bit register (CRC register) = FFFFH.
            byte CRCHigh = 0xFF, CRCLow = 0xFF;
            char CRCLSB;
            byte[] CRC = new byte[2];
            for (int i = 0; i < (data.Length) - 2; i++) // Loop over each bit
            {
                CRCFull = (ushort)(CRCFull ^ data[i]); // 

                for (int j = 0; j < 8; j++)
                {
                    CRCLSB = (char)(CRCFull & 0x0001);
                    CRCFull = (ushort)((CRCFull >> 1) & 0x7FFF);

                    if (CRCLSB == 1)
                        CRCFull = (ushort)(CRCFull ^ 0xA001);
                }
            }
            CRC[1] = CRCHigh = (byte)((CRCFull >> 8) & 0xFF);
            CRC[0] = CRCLow = (byte)(CRCFull & 0xFF);
            return CRC;
        }


    }
}
