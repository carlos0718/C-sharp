using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DatosPersonales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) )
            {
                e.Handled = true;
                MessageBox.Show("Sólo se aceptan letras");
            }

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Sólo se aceptan letras");
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Sólo se permiten números");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "")
                textBox5.BackColor = Color.Red;

            else
                textBox5.BackColor = System.Drawing.SystemColors.Control;
            if (textBox2.Text == "")
                textBox2.BackColor = Color.Red;
            else
                textBox2.BackColor = System.Drawing.SystemColors.Control;
            if (textBox3.Text == "")
                textBox3.BackColor = Color.Red;
            else
                textBox3.BackColor = System.Drawing.SystemColors.Control;
            if (textBox4.Text == "")
                textBox4.BackColor = Color.Red;
            else
                textBox4.BackColor = System.Drawing.SystemColors.Control;

            textBox1.Text = " APELLIDO Y NOMBRE: " + textBox3.Text + " " + textBox2.Text + Environment.NewLine +
            Environment.NewLine + " EDAD : " + textBox5.Text + Environment.NewLine +
            Environment.NewLine +" DIRECCIÓN: " + textBox4.Text;
        }

        private void btnCancelar_Click_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
