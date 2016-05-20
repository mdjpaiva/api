namespace GlobalCode.Surfing.Win
{
    partial class Form1
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
            this.btnConectar = new System.Windows.Forms.Button();
            this.btnLuz = new System.Windows.Forms.Button();
            this.lblLuz = new System.Windows.Forms.Label();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnTemp = new System.Windows.Forms.Button();
            this.btnRGB = new System.Windows.Forms.Button();
            this.lblTemp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.btnEnviarLuz = new System.Windows.Forms.Button();
            this.btnReceber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(36, 65);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(120, 37);
            this.btnConectar.TabIndex = 0;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // btnLuz
            // 
            this.btnLuz.Location = new System.Drawing.Point(36, 120);
            this.btnLuz.Name = "btnLuz";
            this.btnLuz.Size = new System.Drawing.Size(120, 36);
            this.btnLuz.TabIndex = 1;
            this.btnLuz.Text = "LUZ";
            this.btnLuz.UseVisualStyleBackColor = true;
            this.btnLuz.Click += new System.EventHandler(this.btnLuz_Click);
            // 
            // lblLuz
            // 
            this.lblLuz.AutoSize = true;
            this.lblLuz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuz.Location = new System.Drawing.Point(162, 127);
            this.lblLuz.Name = "lblLuz";
            this.lblLuz.Size = new System.Drawing.Size(51, 20);
            this.lblLuz.TabIndex = 2;
            this.lblLuz.Text = "Valor";
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(36, 280);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(120, 37);
            this.btnDesconectar.TabIndex = 3;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // btnTemp
            // 
            this.btnTemp.Location = new System.Drawing.Point(36, 172);
            this.btnTemp.Name = "btnTemp";
            this.btnTemp.Size = new System.Drawing.Size(120, 37);
            this.btnTemp.TabIndex = 4;
            this.btnTemp.Text = "TEMPERATURA";
            this.btnTemp.UseVisualStyleBackColor = true;
            this.btnTemp.Click += new System.EventHandler(this.btnTemp_Click);
            // 
            // btnRGB
            // 
            this.btnRGB.Location = new System.Drawing.Point(36, 225);
            this.btnRGB.Name = "btnRGB";
            this.btnRGB.Size = new System.Drawing.Size(120, 37);
            this.btnRGB.TabIndex = 5;
            this.btnRGB.Text = "RGB";
            this.btnRGB.UseVisualStyleBackColor = true;
            this.btnRGB.Click += new System.EventHandler(this.btnRGB_Click);
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(162, 179);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(51, 20);
            this.lblTemp.TabIndex = 6;
            this.lblTemp.Text = "Valor";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Porta";
            // 
            // txtPorta
            // 
            this.txtPorta.Location = new System.Drawing.Point(91, 30);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(65, 20);
            this.txtPorta.TabIndex = 8;
            this.txtPorta.Text = "COM4";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(162, 72);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(51, 20);
            this.lblID.TabIndex = 9;
            this.lblID.Text = "Valor";
            // 
            // btnEnviarLuz
            // 
            this.btnEnviarLuz.Location = new System.Drawing.Point(268, 120);
            this.btnEnviarLuz.Name = "btnEnviarLuz";
            this.btnEnviarLuz.Size = new System.Drawing.Size(120, 36);
            this.btnEnviarLuz.TabIndex = 10;
            this.btnEnviarLuz.Text = "ENVIAR";
            this.btnEnviarLuz.UseVisualStyleBackColor = true;
            this.btnEnviarLuz.Click += new System.EventHandler(this.btnEnviarLuz_Click);
            // 
            // btnReceber
            // 
            this.btnReceber.Location = new System.Drawing.Point(394, 120);
            this.btnReceber.Name = "btnReceber";
            this.btnReceber.Size = new System.Drawing.Size(120, 36);
            this.btnReceber.TabIndex = 11;
            this.btnReceber.Text = "RECEBER";
            this.btnReceber.UseVisualStyleBackColor = true;
            this.btnReceber.Click += new System.EventHandler(this.btnReceber_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 354);
            this.Controls.Add(this.btnReceber);
            this.Controls.Add(this.btnEnviarLuz);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txtPorta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.btnRGB);
            this.Controls.Add(this.btnTemp);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.lblLuz);
            this.Controls.Add(this.btnLuz);
            this.Controls.Add(this.btnConectar);
            this.Name = "Form1";
            this.Text = "JoinCommunity 2016 - Show";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Button btnLuz;
        private System.Windows.Forms.Label lblLuz;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnTemp;
        private System.Windows.Forms.Button btnRGB;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Button btnEnviarLuz;
        private System.Windows.Forms.Button btnReceber;
    }
}

