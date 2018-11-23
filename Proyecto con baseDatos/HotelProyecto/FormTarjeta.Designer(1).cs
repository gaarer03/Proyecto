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
            this.btnPago = new System.Windows.Forms.Button();
            this.lbprueba = new System.Windows.Forms.Label();
            this.mtbVencimiento = new System.Windows.Forms.MaskedTextBox();
            this.mtbCvv = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mtbNumeroTarjeta = new System.Windows.Forms.MaskedTextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotalPagar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPago
            // 
            this.btnPago.Location = new System.Drawing.Point(31, 164);
            this.btnPago.Name = "btnPago";
            this.btnPago.Size = new System.Drawing.Size(230, 57);
            this.btnPago.TabIndex = 16;
            this.btnPago.Text = "Finalizar Transacción";
            this.btnPago.UseVisualStyleBackColor = true;
            // 
            // lbprueba
            // 
            this.lbprueba.AutoSize = true;
            this.lbprueba.Location = new System.Drawing.Point(334, 35);
            this.lbprueba.Name = "lbprueba";
            this.lbprueba.Size = new System.Drawing.Size(82, 13);
            this.lbprueba.TabIndex = 7;
            this.lbprueba.Text = "Total a pagar: $";
            // 
            // mtbVencimiento
            // 
            this.mtbVencimiento.Location = new System.Drawing.Point(423, 120);
            this.mtbVencimiento.Mask = "00 / 00";
            this.mtbVencimiento.Name = "mtbVencimiento";
            this.mtbVencimiento.Size = new System.Drawing.Size(57, 20);
            this.mtbVencimiento.TabIndex = 13;
            // 
            // mtbCvv
            // 
            this.mtbCvv.Location = new System.Drawing.Point(212, 119);
            this.mtbCvv.Mask = "000";
            this.mtbCvv.Name = "mtbCvv";
            this.mtbCvv.Size = new System.Drawing.Size(49, 20);
            this.mtbCvv.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(310, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Fecha de Vencimiento (mes / año)";
            // 
            // mtbNumeroTarjeta
            // 
            this.mtbNumeroTarjeta.Location = new System.Drawing.Point(31, 120);
            this.mtbNumeroTarjeta.Mask = "0000 - 0000 - 0000 - 0000";
            this.mtbNumeroTarjeta.Name = "mtbNumeroTarjeta";
            this.mtbNumeroTarjeta.Size = new System.Drawing.Size(138, 20);
            this.mtbNumeroTarjeta.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(219, 103);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 13);
            this.label14.TabIndex = 10;
            this.label14.Text = "CVV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Número Tarjeta";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotalPagar);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(31, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 53);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // lblTotalPagar
            // 
            this.lblTotalPagar.AutoSize = true;
            this.lblTotalPagar.Location = new System.Drawing.Point(76, 32);
            this.lblTotalPagar.Name = "lblTotalPagar";
            this.lblTotalPagar.Size = new System.Drawing.Size(0, 13);
            this.lblTotalPagar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pago con Tarjeta:";
            // 
            // FormTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 280);
            this.Controls.Add(this.btnPago);
            this.Controls.Add(this.lbprueba);
            this.Controls.Add(this.mtbVencimiento);
            this.Controls.Add(this.mtbCvv);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.mtbNumeroTarjeta);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormTarjeta";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblTotalPagar;
        private System.Windows.Forms.Label label1;
    }
}