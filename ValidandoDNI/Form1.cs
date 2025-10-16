using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ValidandoDNI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // para que solo se puden introducir 8 números y una letra mayúscula
            txtDNI.Mask = "00000000>L";
            txtDNI.AsciiOnly = true;
            txtDNI.ResetOnSpace = false;
            txtDNI.SkipLiterals = true;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
             
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btValidar_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text.Replace(" ","");
            if (dni.Length != 9)
            {
                resultado.Text = "DNI no válido";
                return;

            }


        }

        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
