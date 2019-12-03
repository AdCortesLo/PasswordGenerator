using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passwords
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        string abc = "abdcefghiklmnopqrstuvwxyz";
        string ABC = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string numbers = "0123456789";
        string specialCharacters = "!#$%&'()*+,-./:;<=>?@[\\]^`{|}~_";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string password = "";
            do {
                password = GeneratePassword();
            } while(!CheckIsValid(password));

            rtbPassword.Text = password;
        }

        private string GeneratePassword()
        {
            string characters = abc;
            if (cbMayus.Checked)
                characters += ABC;
            if (cbNumeros.Checked)
                characters += numbers;
            if (cbEspeciales.Checked)
                characters += specialCharacters;

            string password = "";

            for (int i = 0; i < numericUpDown1.Value; i++)
            {
                password += characters[r.Next(0, characters.Length-1)];
            }
            return password;
        }

        private bool CheckIsValid(string password)
        {
            bool cumple = true;
            if (cbMayus.Checked && !Regex.IsMatch(password, @"[A-Z]+"))
                cumple = false;
            if (cbNumeros.Checked && !Regex.IsMatch(password, @"\d+"))
                cumple = false;
            if (cbEspeciales.Checked && !Regex.IsMatch(password, @"[\!\#\$\%\&\'\(\)\*\+\,\-\.\/\:\;\<\=\>\?\@\[\\\]\^\`\{\|\}\~_]+"))
                cumple = false;
            return cumple;
        }

        private void btGuardarFichero_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(rtbPassword.Text) || String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Introduce cuenta y/o contraseña");
            }
            else
            {
                saveFileDialog1.ShowDialog();

                using (var tw = new StreamWriter(saveFileDialog1.FileName, true))
                {
                    tw.WriteLine("Cuenta: " + textBox1.Text);
                    tw.WriteLine("Contraseña: " + rtbPassword.Text);
                    tw.WriteLine("-------------------------------------------------------------\n");
                }
                MessageBox.Show("Guardado correctamente");

                rtbPassword.Text = string.Empty;
                textBox1.Text = string.Empty;

            }
        }
    }
}
