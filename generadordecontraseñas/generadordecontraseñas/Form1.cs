using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace generadordecontraseñas
{
    public partial class Form1 : Form
    {
        private const int PasswordLength = 15;
        private const int MinAscii = 33;
        private const int MaxAscii = 125;
        public Form1()
        {
            InitializeComponent();
        }

        private void Generarbuton_Click(object sender, EventArgs e)
        {
            string password = GeneratePassword();
            PasswordTexBox.Text = password;
        }
        private string GeneratePassword()
        {
            Random random = new Random();
            string password = string.Empty;
            bool[] usedChars = new bool[MaxAscii - MinAscii + 1];

            while (password.Length < PasswordLength)
            {
                char randomChar = (char)random.Next(MinAscii, MaxAscii + 1);
                if (!usedChars[randomChar - MinAscii])
                {
                    password += randomChar;
                    usedChars[randomChar - MinAscii] = true;
                }
            }

            return password;
        }
    }
}
