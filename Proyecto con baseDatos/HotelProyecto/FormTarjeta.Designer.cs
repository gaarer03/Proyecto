namespace HotelProyecto
{
    partial class FormTarjeta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTarjeta));
            this.btnPago = new System.Windows.Forms.Button();
            this.lbprueba = new System.Windows.Forms.Label();
            this.mtbVencimiento = new System.Windows.Forms.MaskedTextBox();
            this.mtbCvv = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mtbNumeroTarjeta = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTotalPagar = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lbCambiodeMoneda = new System.Windows.Forms.Label();
            this.btnPagarMoneda = new System.Windows.Forms.Button();
            this.lbCambio = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtbCantidadMon = new System.Windows.Forms.TextBox();
            this.cmbMoneda = new System.Windows.Forms.ComboBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPago
            // 
            this.btnPago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btnPago.Location = new System.Drawing.Point(248, 118);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(108, 91);
            this.btnPago.TabIndex = 16;
            this.btnPago.Text = "Finalizar Transacción";
            this.btnPago.UseVisualStyleBackColor = true;
            this.btnPago.Click += new System.EventHandler(this.btnPago_Click_1);
            // 
            // lbprueba
            // 
            this.lbprueba.AutoSize = true;
            this.lbprueba.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbprueba.Location = new System.Drawing.Point(21, 104);
            this.lbprueba.Name = "lbprueba";
            this.lbprueba.Size = new System.Drawing.Size(109, 17);
            this.lbprueba.TabIndex = 7;
            this.lbprueba.Text = "Total a pagar: $";
            // 
            // mtbVencimiento
            // 
            this.mtbVencimiento.Location = new System.Drawing.Point(258, 82);
            this.mtbVencimiento.Mask = "00 / 00";
            this.mtbVencimiento.Name = "mtbVencimiento";
            this.mtbVencimiento.Size = new System.Drawing.Size(48, 23);
            this.mtbVencimiento.TabIndex = 13;
            // 
            // mtbCvv
            // 
            this.mtbCvv.Location = new System.Drawing.Point(183, 61);
            this.mtbCvv.Mask = "000";
            this.mtbCvv.Name = "mtbCvv";
            this.mtbCvv.Size = new System.Drawing.Size(49, 23);
            this.mtbCvv.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fecha de Vencimiento ";
            // 
            // mtbNumeroTarjeta
            // 
            this.mtbNumeroTarjeta.Location = new System.Drawing.Point(13, 64);
            this.mtbNumeroTarjeta.Mask = "0000 - 0000 - 0000 - 0000";
            this.mtbNumeroTarjeta.Name = "mtbNumeroTarjeta";
            this.mtbNumeroTarjeta.Size = new System.Drawing.Size(138, 23);
            this.mtbNumeroTarjeta.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(180, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 17);
            this.label14.TabIndex = 10;
            this.label14.Text = "CVV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Número Tarjeta";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label25.Font = new System.Drawing.Font("Impact", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Black;
            this.label25.Location = new System.Drawing.Point(33, 60);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(162, 25);
            this.label25.TabIndex = 20;
            this.label25.Text = "Suites and Resorts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Impact", 31.75F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 53);
            this.label2.TabIndex = 18;
            this.label2.Text = "HOTEL  ACA";
            // 
            // lbTotalPagar
            // 
            this.lbTotalPagar.AutoSize = true;
            this.lbTotalPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lbTotalPagar.Location = new System.Drawing.Point(155, 104);
            this.lbTotalPagar.Name = "lbTotalPagar";
            this.lbTotalPagar.Size = new System.Drawing.Size(40, 17);
            this.lbTotalPagar.TabIndex = 21;
            this.lbTotalPagar.Text = "0000";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnPago);
            this.groupBox1.Controls.Add(this.mtbVencimiento);
            this.groupBox1.Controls.Add(this.mtbCvv);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.mtbNumeroTarjeta);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox1.Location = new System.Drawing.Point(24, 135);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 247);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pago con Tarjeta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "(mes / año)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 116);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(201, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox4);
            this.groupBox2.Controls.Add(this.lbCambiodeMoneda);
            this.groupBox2.Controls.Add(this.btnPagarMoneda);
            this.groupBox2.Controls.Add(this.lbCambio);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtbCantidadMon);
            this.groupBox2.Controls.Add(this.cmbMoneda);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.groupBox2.Location = new System.Drawing.Point(462, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(289, 246);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pago en Efectivo:";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::HotelProyecto.Properties.Resources.tipomonedas;
            this.pictureBox4.Location = new System.Drawing.Point(154, 50);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(121, 100);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // lbCambiodeMoneda
            // 
            this.lbCambiodeMoneda.AutoSize = true;
            this.lbCambiodeMoneda.Location = new System.Drawing.Point(15, 155);
            this.lbCambiodeMoneda.Name = "lbCambiodeMoneda";
            this.lbCambiodeMoneda.Size = new System.Drawing.Size(44, 17);
            this.lbCambiodeMoneda.TabIndex = 7;
            this.lbCambiodeMoneda.Text = "00.00";
            // 
            // btnPagarMoneda
            // 
            this.btnPagarMoneda.Location = new System.Drawing.Point(169, 175);
            this.btnPagarMoneda.Name = "btnPagarMoneda";
            this.btnPagarMoneda.Size = new System.Drawing.Size(106, 49);
            this.btnPagarMoneda.TabIndex = 6;
            this.btnPagarMoneda.Text = "Pagar";
            this.btnPagarMoneda.UseVisualStyleBackColor = true;
            this.btnPagarMoneda.Click += new System.EventHandler(this.btnPagarMoneda_Click);
            // 
            // lbCambio
            // 
            this.lbCambio.AutoSize = true;
            this.lbCambio.Location = new System.Drawing.Point(13, 226);
            this.lbCambio.Name = "lbCambio";
            this.lbCambio.Size = new System.Drawing.Size(44, 17);
            this.lbCambio.TabIndex = 5;
            this.lbCambio.Text = "00.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 17);
            this.label7.TabIndex = 4;
            this.label7.Text = "Cambio  MXN $ ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 3;
            this.label6.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Tipo de moneda";
            // 
            // txtbCantidadMon
            // 
            this.txtbCantidadMon.Location = new System.Drawing.Point(16, 104);
            this.txtbCantidadMon.Name = "txtbCantidadMon";
            this.txtbCantidadMon.Size = new System.Drawing.Size(100, 23);
            this.txtbCantidadMon.TabIndex = 1;
            // 
            // cmbMoneda
            // 
            this.cmbMoneda.FormattingEnabled = true;
            this.cmbMoneda.Location = new System.Drawing.Point(16, 50);
            this.cmbMoneda.Name = "cmbMoneda";
            this.cmbMoneda.Size = new System.Drawing.Size(121, 24);
            this.cmbMoneda.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(631, 17);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(134, 113);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::HotelProyecto.Properties.Resources.caja;
            this.pictureBox3.Location = new System.Drawing.Point(334, 12);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(138, 125);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 22;
            this.pictureBox3.TabStop = false;
            // 
            // FormTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 396);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lbTotalPagar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbprueba);
            this.Name = "FormTarjeta";
            this.Text = "Pago";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPago;
        private System.Windows.Forms.Label lbprueba;
        private System.Windows.Forms.MaskedTextBox mtbVencimiento;
        private System.Windows.Forms.MaskedTextBox mtbCvv;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox mtbNumeroTarjeta;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTotalPagar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbMoneda;
        private System.Windows.Forms.Button btnPagarMoneda;
        private System.Windows.Forms.Label lbCambio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtbCantidadMon;
        private System.Windows.Forms.Label lbCambiodeMoneda;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}