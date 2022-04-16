
namespace MODBUS_CRC
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.txt_msg = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.txt_end = new System.Windows.Forms.TextBox();
            this.txt_dados = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_msg_Sem = new System.Windows.Forms.TextBox();
            this.combo_func = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 0;
            this.button1.Text = "Gerar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_msg
            // 
            this.txt_msg.Location = new System.Drawing.Point(119, 158);
            this.txt_msg.Name = "txt_msg";
            this.txt_msg.Size = new System.Drawing.Size(156, 20);
            this.txt_msg.TabIndex = 1;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(119, 28);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 20);
            this.txt_id.TabIndex = 2;
            this.txt_id.Text = "00";
            // 
            // txt_end
            // 
            this.txt_end.Location = new System.Drawing.Point(119, 80);
            this.txt_end.Name = "txt_end";
            this.txt_end.Size = new System.Drawing.Size(100, 20);
            this.txt_end.TabIndex = 4;
            this.txt_end.Text = "00";
            // 
            // txt_dados
            // 
            this.txt_dados.Location = new System.Drawing.Point(119, 106);
            this.txt_dados.Name = "txt_dados";
            this.txt_dados.Size = new System.Drawing.Size(100, 20);
            this.txt_dados.TabIndex = 5;
            this.txt_dados.Text = "01";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Função";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Endereço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Num. Dados";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mensagem com CRC";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(47, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Mensagem";
            // 
            // txt_msg_Sem
            // 
            this.txt_msg_Sem.Location = new System.Drawing.Point(119, 132);
            this.txt_msg_Sem.Name = "txt_msg_Sem";
            this.txt_msg_Sem.Size = new System.Drawing.Size(100, 20);
            this.txt_msg_Sem.TabIndex = 11;
            // 
            // combo_func
            // 
            this.combo_func.FormattingEnabled = true;
            this.combo_func.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05"});
            this.combo_func.Location = new System.Drawing.Point(119, 54);
            this.combo_func.Name = "combo_func";
            this.combo_func.Size = new System.Drawing.Size(100, 21);
            this.combo_func.TabIndex = 13;
            this.combo_func.Tag = "";
            this.combo_func.Text = "01";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 201);
            this.Controls.Add(this.combo_func);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txt_msg_Sem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_dados);
            this.Controls.Add(this.txt_end);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.txt_msg);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Gerador de Mensagens MODBUS RTU";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_msg;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.TextBox txt_end;
        private System.Windows.Forms.TextBox txt_dados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_msg_Sem;
        private System.Windows.Forms.ComboBox combo_func;
    }
}

