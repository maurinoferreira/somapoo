namespace Soma
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNumero1 = new System.Windows.Forms.Label();
            this.txtNumero1 = new System.Windows.Forms.TextBox();
            this.lblNumero2 = new System.Windows.Forms.Label();
            this.txbNumero2 = new System.Windows.Forms.TextBox();
            this.btnSoma = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNumero1
            // 
            this.lblNumero1.AutoSize = true;
            this.lblNumero1.Location = new System.Drawing.Point(28, 25);
            this.lblNumero1.Name = "lblNumero1";
            this.lblNumero1.Size = new System.Drawing.Size(104, 15);
            this.lblNumero1.TabIndex = 0;
            this.lblNumero1.Text = "Insira o 1° número";
            // 
            // txtNumero1
            // 
            this.txtNumero1.Location = new System.Drawing.Point(28, 43);
            this.txtNumero1.Name = "txtNumero1";
            this.txtNumero1.Size = new System.Drawing.Size(152, 23);
            this.txtNumero1.TabIndex = 1;
            // 
            // lblNumero2
            // 
            this.lblNumero2.AutoSize = true;
            this.lblNumero2.Location = new System.Drawing.Point(28, 80);
            this.lblNumero2.Name = "lblNumero2";
            this.lblNumero2.Size = new System.Drawing.Size(104, 15);
            this.lblNumero2.TabIndex = 2;
            this.lblNumero2.Text = "Insira o 2° número";
            // 
            // txbNumero2
            // 
            this.txbNumero2.Location = new System.Drawing.Point(28, 98);
            this.txbNumero2.Name = "txbNumero2";
            this.txbNumero2.Size = new System.Drawing.Size(152, 23);
            this.txbNumero2.TabIndex = 3;
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(28, 137);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(152, 23);
            this.btnSoma.TabIndex = 4;
            this.btnSoma.Text = "Somar";
            this.btnSoma.UseVisualStyleBackColor = true;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(28, 181);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(59, 15);
            this.lblResultado.TabIndex = 5;
            this.lblResultado.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 258);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.txbNumero2);
            this.Controls.Add(this.lblNumero2);
            this.Controls.Add(this.txtNumero1);
            this.Controls.Add(this.lblNumero1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNumero1;
        private TextBox txtNumero1;
        private Label lblNumero2;
        private TextBox txbNumero2;
        private Button btnSoma;
        private Label lblResultado;
    }
}