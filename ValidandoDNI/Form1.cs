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
            // para que solo se puden introducir 8 números y una letra mayúscula de primeras
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
// DNI -> 8 Num  
        private void btValidar_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text;
            int numero = int.Parse(dni.Substring(0, 8));
            char letra = char.Parse(dni.Substring(8, 1));

            //Las letras del DNI se corresponden con el resto de dividir el número del DNI entre 23 y ese número está asociado a una letra concreta
            if (letra == ("TRWAGMYFPDXBNJZSQVHLCKE"[numero % 23])) //Este es el listado de las letras asociadas a cada número:

            {
                MessageBox.Show("DNI Válido");
            }
            else
            {
                MessageBox.Show("DNI No Válido");
            }
            

        }

        private void maskedTextBox1_MaskInputRejected_1(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
