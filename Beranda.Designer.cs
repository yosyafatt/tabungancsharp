namespace Tabungan_GUI
{
    partial class Beranda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.nominalSetor = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nominalTarik = new System.Windows.Forms.TextBox();
            this.btnTarik = new System.Windows.Forms.Button();
            this.radioIDR = new System.Windows.Forms.RadioButton();
            this.radioUSD = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 112);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(460, 237);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.nominalSetor);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(452, 211);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Setor Tunai";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.radioUSD);
            this.tabPage2.Controls.Add(this.radioIDR);
            this.tabPage2.Controls.Add(this.btnTarik);
            this.tabPage2.Controls.Add(this.nominalTarik);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(452, 211);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tarik Tunai";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nominal :";
            // 
            // nominalSetor
            // 
            this.nominalSetor.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nominalSetor.Location = new System.Drawing.Point(130, 80);
            this.nominalSetor.Name = "nominalSetor";
            this.nominalSetor.Size = new System.Drawing.Size(200, 29);
            this.nominalSetor.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(194, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Setor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(127, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nominal :";
            // 
            // nominalTarik
            // 
            this.nominalTarik.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nominalTarik.Location = new System.Drawing.Point(130, 80);
            this.nominalTarik.Name = "nominalTarik";
            this.nominalTarik.Size = new System.Drawing.Size(200, 29);
            this.nominalTarik.TabIndex = 1;
            // 
            // btnTarik
            // 
            this.btnTarik.Location = new System.Drawing.Point(193, 138);
            this.btnTarik.Name = "btnTarik";
            this.btnTarik.Size = new System.Drawing.Size(75, 29);
            this.btnTarik.TabIndex = 2;
            this.btnTarik.Text = "Ambil";
            this.btnTarik.UseVisualStyleBackColor = true;
            this.btnTarik.Click += new System.EventHandler(this.Button2_Click);
            // 
            // radioIDR
            // 
            this.radioIDR.AutoSize = true;
            this.radioIDR.Location = new System.Drawing.Point(130, 115);
            this.radioIDR.Name = "radioIDR";
            this.radioIDR.Size = new System.Drawing.Size(83, 17);
            this.radioIDR.TabIndex = 3;
            this.radioIDR.TabStop = true;
            this.radioIDR.Text = "Rupiah/IDR";
            this.radioIDR.UseVisualStyleBackColor = true;
            // 
            // radioUSD
            // 
            this.radioUSD.AutoSize = true;
            this.radioUSD.Location = new System.Drawing.Point(232, 115);
            this.radioUSD.Name = "radioUSD";
            this.radioUSD.Size = new System.Drawing.Size(98, 17);
            this.radioUSD.TabIndex = 4;
            this.radioUSD.TabStop = true;
            this.radioUSD.Text = "US Dollar/USD";
            this.radioUSD.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Saldo :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(141, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 26);
            this.label4.TabIndex = 3;
            this.label4.Text = "Update Saldo";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(310, 48);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Cek Saldo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5.Location = new System.Drawing.Point(195, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Minimum setor : Rp. 5.000,-";
            // 
            // Beranda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tabControl1);
            this.Name = "Beranda";
            this.Text = "Tabungan";
            this.Load += new System.EventHandler(this.Beranda_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox nominalSetor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioUSD;
        private System.Windows.Forms.RadioButton radioIDR;
        private System.Windows.Forms.Button btnTarik;
        private System.Windows.Forms.TextBox nominalTarik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
    }
}

