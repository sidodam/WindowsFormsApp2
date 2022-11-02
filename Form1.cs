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


namespace WindowsFormsApp2
{


    public partial class Form1 : Form
    {

        private ErrorProvider dniErrorProvider;
        public Form1()
        {
            InitializeComponent();

            dniErrorProvider = new ErrorProvider();
            dniErrorProvider.SetIconAlignment(this.textBox1, ErrorIconAlignment.TopRight);
           
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ChangeLabelColor(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;

            if (textBox1.Text.Length == 0)
            {
                label1.ForeColor = Color.Black;
            }
        }

        private void ChangeLabelColor2(object sender, EventArgs e)
        {
            label2.ForeColor = Color.Red;

            if (textBox3.Text.Length == 0)
            {
                label2.ForeColor = Color.Black;
            }

        }

        private void ChangeLabelColor3(object sender, EventArgs e)
        {
            label3.ForeColor = Color.Red;

            if (textBox4.Text.Length == 0)
            {
                label3.ForeColor = Color.Black;
            }

        }

        private void ChangeLabelColor4(object sender, EventArgs e)
        {
            label4.ForeColor = Color.Red;

            if (textBox2.Text.Length == 0)
            {
                label4.ForeColor = Color.Black;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Dni_Validating(object sender, CancelEventArgs e)
        {
            var patron = @"[1-9]{8}[A-Z]{1}";

            Regex rgx = new Regex(patron);

            if (!rgx.IsMatch(textBox1.Text))
            {

                this.dniErrorProvider.SetError(textBox1, "nif no es correctro");
                e.Cancel = true;

            }
        }

    }
}
