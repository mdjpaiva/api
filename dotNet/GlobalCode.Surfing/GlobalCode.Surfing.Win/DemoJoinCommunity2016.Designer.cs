namespace GlobalCode.Surfing.Win
{
    partial class DemoJoinCommunity2016
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
            this.components = new System.ComponentModel.Container();
            this.btnConectar = new System.Windows.Forms.Button();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLuz = new System.Windows.Forms.Button();
            this.btnTemp = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.lblTemp = new System.Windows.Forms.Label();
            this.lblLuz = new System.Windows.Forms.Label();
            this.btnRGB = new System.Windows.Forms.Button();
            this.btnDesconectar = new System.Windows.Forms.Button();
            this.btnMonitor = new System.Windows.Forms.Button();
            this.btnFechaMonitor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMonitor = new System.Windows.Forms.Label();
            this.timerEnvio = new System.Windows.Forms.Timer(this.components);
            this.picLuz = new System.Windows.Forms.PictureBox();
            this.lblPotenciometro = new System.Windows.Forms.Label();
            this.lblpotencia = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAlcool = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLuz)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(48, 65);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(120, 37);
            this.btnConectar.TabIndex = 1;
            this.btnConectar.Text = "Conectar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
            // 
            // txtPorta
            // 
            this.txtPorta.Location = new System.Drawing.Point(103, 30);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(65, 20);
            this.txtPorta.TabIndex = 10;
            this.txtPorta.Text = "COM4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Porta";
            // 
            // btnLuz
            // 
            this.btnLuz.Location = new System.Drawing.Point(48, 121);
            this.btnLuz.Name = "btnLuz";
            this.btnLuz.Size = new System.Drawing.Size(120, 36);
            this.btnLuz.TabIndex = 11;
            this.btnLuz.Text = "LUZ";
            this.btnLuz.UseVisualStyleBackColor = true;
            this.btnLuz.Click += new System.EventHandler(this.btnLuz_Click);
            // 
            // btnTemp
            // 
            this.btnTemp.Location = new System.Drawing.Point(48, 176);
            this.btnTemp.Name = "btnTemp";
            this.btnTemp.Size = new System.Drawing.Size(120, 37);
            this.btnTemp.TabIndex = 12;
            this.btnTemp.Text = "TEMPERATURA";
            this.btnTemp.UseVisualStyleBackColor = true;
            this.btnTemp.Click += new System.EventHandler(this.btnTemp_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(174, 72);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(51, 20);
            this.lblID.TabIndex = 15;
            this.lblID.Text = "Valor";
            // 
            // lblTemp
            // 
            this.lblTemp.AutoSize = true;
            this.lblTemp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemp.Location = new System.Drawing.Point(174, 179);
            this.lblTemp.Name = "lblTemp";
            this.lblTemp.Size = new System.Drawing.Size(51, 20);
            this.lblTemp.TabIndex = 14;
            this.lblTemp.Text = "Valor";
            // 
            // lblLuz
            // 
            this.lblLuz.AutoSize = true;
            this.lblLuz.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuz.Location = new System.Drawing.Point(174, 127);
            this.lblLuz.Name = "lblLuz";
            this.lblLuz.Size = new System.Drawing.Size(51, 20);
            this.lblLuz.TabIndex = 13;
            this.lblLuz.Text = "Valor";
            // 
            // btnRGB
            // 
            this.btnRGB.Location = new System.Drawing.Point(48, 234);
            this.btnRGB.Name = "btnRGB";
            this.btnRGB.Size = new System.Drawing.Size(120, 37);
            this.btnRGB.TabIndex = 16;
            this.btnRGB.Text = "RGB";
            this.btnRGB.UseVisualStyleBackColor = true;
            this.btnRGB.Click += new System.EventHandler(this.btnRGB_Click);
            // 
            // btnDesconectar
            // 
            this.btnDesconectar.Location = new System.Drawing.Point(48, 287);
            this.btnDesconectar.Name = "btnDesconectar";
            this.btnDesconectar.Size = new System.Drawing.Size(120, 37);
            this.btnDesconectar.TabIndex = 17;
            this.btnDesconectar.Text = "Desconectar";
            this.btnDesconectar.UseVisualStyleBackColor = true;
            this.btnDesconectar.Click += new System.EventHandler(this.btnDesconectar_Click);
            // 
            // btnMonitor
            // 
            this.btnMonitor.Location = new System.Drawing.Point(18, 51);
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.Size = new System.Drawing.Size(75, 23);
            this.btnMonitor.TabIndex = 18;
            this.btnMonitor.Text = "CONECTAR";
            this.btnMonitor.UseVisualStyleBackColor = true;
            this.btnMonitor.Click += new System.EventHandler(this.btnMonitor_Click);
            // 
            // btnFechaMonitor
            // 
            this.btnFechaMonitor.Location = new System.Drawing.Point(108, 51);
            this.btnFechaMonitor.Name = "btnFechaMonitor";
            this.btnFechaMonitor.Size = new System.Drawing.Size(75, 23);
            this.btnFechaMonitor.TabIndex = 19;
            this.btnFechaMonitor.Text = "DESCONECTAR";
            this.btnFechaMonitor.UseVisualStyleBackColor = true;
            this.btnFechaMonitor.Click += new System.EventHandler(this.btnFechaMonitor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMonitor);
            this.groupBox1.Controls.Add(this.btnMonitor);
            this.groupBox1.Controls.Add(this.btnFechaMonitor);
            this.groupBox1.Location = new System.Drawing.Point(312, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 119);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MONITORAMENTO / ENVIO";
            // 
            // lblMonitor
            // 
            this.lblMonitor.AutoSize = true;
            this.lblMonitor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonitor.Location = new System.Drawing.Point(71, 83);
            this.lblMonitor.Name = "lblMonitor";
            this.lblMonitor.Size = new System.Drawing.Size(89, 20);
            this.lblMonitor.TabIndex = 20;
            this.lblMonitor.Text = "Desligado";
            // 
            // timerEnvio
            // 
            this.timerEnvio.Interval = 5000;
            this.timerEnvio.Tick += new System.EventHandler(this.timerEnvio_Tick);
            // 
            // picLuz
            // 
            this.picLuz.Location = new System.Drawing.Point(211, 223);
            this.picLuz.Name = "picLuz";
            this.picLuz.Size = new System.Drawing.Size(301, 192);
            this.picLuz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLuz.TabIndex = 21;
            this.picLuz.TabStop = false;
            // 
            // lblPotenciometro
            // 
            this.lblPotenciometro.AutoSize = true;
            this.lblPotenciometro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPotenciometro.Location = new System.Drawing.Point(99, 349);
            this.lblPotenciometro.Name = "lblPotenciometro";
            this.lblPotenciometro.Size = new System.Drawing.Size(51, 20);
            this.lblPotenciometro.TabIndex = 22;
            this.lblPotenciometro.Text = "Valor";
            // 
            // lblpotencia
            // 
            this.lblpotencia.AutoSize = true;
            this.lblpotencia.Location = new System.Drawing.Point(12, 354);
            this.lblpotencia.Name = "lblpotencia";
            this.lblpotencia.Size = new System.Drawing.Size(75, 13);
            this.lblpotencia.TabIndex = 23;
            this.lblpotencia.Text = "Potenciômetro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 390);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Alcool";
            // 
            // lblAlcool
            // 
            this.lblAlcool.AutoSize = true;
            this.lblAlcool.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlcool.Location = new System.Drawing.Point(99, 385);
            this.lblAlcool.Name = "lblAlcool";
            this.lblAlcool.Size = new System.Drawing.Size(51, 20);
            this.lblAlcool.TabIndex = 25;
            this.lblAlcool.Text = "Valor";
            // 
            // DemoJoinCommunity2016
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 427);
            this.Controls.Add(this.lblAlcool);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblpotencia);
            this.Controls.Add(this.lblPotenciometro);
            this.Controls.Add(this.picLuz);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDesconectar);
            this.Controls.Add(this.btnRGB);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblTemp);
            this.Controls.Add(this.lblLuz);
            this.Controls.Add(this.btnTemp);
            this.Controls.Add(this.btnLuz);
            this.Controls.Add(this.txtPorta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConectar);
            this.Name = "DemoJoinCommunity2016";
            this.Text = "DemoJoinCommunity2016";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLuz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLuz;
        private System.Windows.Forms.Button btnTemp;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblTemp;
        private System.Windows.Forms.Label lblLuz;
        private System.Windows.Forms.Button btnRGB;
        private System.Windows.Forms.Button btnDesconectar;
        private System.Windows.Forms.Button btnMonitor;
        private System.Windows.Forms.Button btnFechaMonitor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timerEnvio;
        private System.Windows.Forms.Label lblMonitor;
        private System.Windows.Forms.PictureBox picLuz;
        private System.Windows.Forms.Label lblPotenciometro;
        private System.Windows.Forms.Label lblpotencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAlcool;
    }
}