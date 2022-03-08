using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolaMundo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_revisar_Click(object sender, EventArgs e)
        {
            string txt = txt_input.Text;
            string txt_2 = txt_psw_second.Text;


            if (Regex.IsMatch(txt, @"^(?=\w*\d*\W)(?=\w*[A-Z]*\W)(?=\w*[a-z]*\W)\S+$"))
            {
                if (txt == txt_2)
                {
                    MessageBox.Show("Las contraseñas coinciden y son seguras");
                }
                else
                {
                    MessageBox.Show("Las contraseñas no coinciden");                }
            }
            else
            {
                MessageBox.Show("La contraseña no tiene un formato válido, intenta de nuevo");
            }
            
        }
    }
}
