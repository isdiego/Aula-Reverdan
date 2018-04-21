namespace TemperaturaDSNoite
{
    partial class frmPrincipal
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
            this.lblTemperatura = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txbTemperatura = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.rdbCF = new System.Windows.Forms.RadioButton();
            this.rdbFC = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lblTemperatura
            // 
            this.lblTemperatura.AutoSize = true;
            this.lblTemperatura.Location = new System.Drawing.Point(31, 9);
            this.lblTemperatura.Name = "lblTemperatura";
            this.lblTemperatura.Size = new System.Drawing.Size(100, 13);
            this.lblTemperatura.TabIndex = 3;
            this.lblTemperatura.Text = "Insira a temperatura";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(31, 226);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(52, 13);
            this.lblResultado.TabIndex = 4;
            this.lblResultado.Text = "Resposta";
            // 
            // txbTemperatura
            // 
            this.txbTemperatura.Location = new System.Drawing.Point(34, 40);
            this.txbTemperatura.Name = "txbTemperatura";
            this.txbTemperatura.Size = new System.Drawing.Size(196, 20);
            this.txbTemperatura.TabIndex = 5;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(34, 182);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(196, 23);
            this.btnCalcular.TabIndex = 6;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // rdbCF
            // 
            this.rdbCF.AutoSize = true;
            this.rdbCF.Checked = true;
            this.rdbCF.Location = new System.Drawing.Point(34, 99);
            this.rdbCF.Name = "rdbCF";
            this.rdbCF.Size = new System.Drawing.Size(117, 17);
            this.rdbCF.TabIndex = 7;
            this.rdbCF.TabStop = true;
            this.rdbCF.Text = "Celsius - Fahrenheit";
            this.rdbCF.UseVisualStyleBackColor = true;
            // 
            // rdbFC
            // 
            this.rdbFC.AutoSize = true;
            this.rdbFC.Location = new System.Drawing.Point(34, 135);
            this.rdbFC.Name = "rdbFC";
            this.rdbFC.Size = new System.Drawing.Size(117, 17);
            this.rdbFC.TabIndex = 8;
            this.rdbFC.TabStop = true;
            this.rdbFC.Text = "Fahrenheit - Celsius";
            this.rdbFC.UseVisualStyleBackColor = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.rdbFC);
            this.Controls.Add(this.rdbCF);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txbTemperatura);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblTemperatura);
            this.Name = "frmPrincipal";
            this.Text = "Temperatura";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTemperatura;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txbTemperatura;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.RadioButton rdbCF;
        private System.Windows.Forms.RadioButton rdbFC;

    }
}

