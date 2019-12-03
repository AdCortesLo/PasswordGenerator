namespace Passwords
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbMayus = new System.Windows.Forms.CheckBox();
            this.cbNumeros = new System.Windows.Forms.CheckBox();
            this.cbEspeciales = new System.Windows.Forms.CheckBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rtbPassword = new System.Windows.Forms.RichTextBox();
            this.btGuardarFichero = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(252, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cuenta";
            // 
            // cbMayus
            // 
            this.cbMayus.AutoSize = true;
            this.cbMayus.Location = new System.Drawing.Point(12, 50);
            this.cbMayus.Name = "cbMayus";
            this.cbMayus.Size = new System.Drawing.Size(112, 17);
            this.cbMayus.TabIndex = 2;
            this.cbMayus.Text = "Incluir mayúsculas";
            this.cbMayus.UseVisualStyleBackColor = true;
            // 
            // cbNumeros
            // 
            this.cbNumeros.AutoSize = true;
            this.cbNumeros.Location = new System.Drawing.Point(12, 73);
            this.cbNumeros.Name = "cbNumeros";
            this.cbNumeros.Size = new System.Drawing.Size(97, 17);
            this.cbNumeros.TabIndex = 3;
            this.cbNumeros.Text = "Incluir números";
            this.cbNumeros.UseVisualStyleBackColor = true;
            // 
            // cbEspeciales
            // 
            this.cbEspeciales.AutoSize = true;
            this.cbEspeciales.Location = new System.Drawing.Point(12, 97);
            this.cbEspeciales.Name = "cbEspeciales";
            this.cbEspeciales.Size = new System.Drawing.Size(160, 17);
            this.cbEspeciales.TabIndex = 4;
            this.cbEspeciales.Text = "Incluir caracteres especiales";
            this.cbEspeciales.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(131, 120);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(60, 20);
            this.numericUpDown1.TabIndex = 5;
            this.numericUpDown1.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Número de caracteres";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 148);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Generar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtbPassword
            // 
            this.rtbPassword.Location = new System.Drawing.Point(10, 148);
            this.rtbPassword.Name = "rtbPassword";
            this.rtbPassword.Size = new System.Drawing.Size(173, 52);
            this.rtbPassword.TabIndex = 8;
            this.rtbPassword.Text = "";
            // 
            // btGuardarFichero
            // 
            this.btGuardarFichero.Location = new System.Drawing.Point(189, 177);
            this.btGuardarFichero.Name = "btGuardarFichero";
            this.btGuardarFichero.Size = new System.Drawing.Size(75, 23);
            this.btGuardarFichero.TabIndex = 9;
            this.btGuardarFichero.Text = "Guardar";
            this.btGuardarFichero.UseVisualStyleBackColor = true;
            this.btGuardarFichero.Click += new System.EventHandler(this.btGuardarFichero_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.FileName = "PasswordsGenerated";
            this.saveFileDialog1.OverwritePrompt = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 232);
            this.Controls.Add(this.btGuardarFichero);
            this.Controls.Add(this.rtbPassword);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.cbEspeciales);
            this.Controls.Add(this.cbNumeros);
            this.Controls.Add(this.cbMayus);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbMayus;
        private System.Windows.Forms.CheckBox cbNumeros;
        private System.Windows.Forms.CheckBox cbEspeciales;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtbPassword;
        private System.Windows.Forms.Button btGuardarFichero;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

