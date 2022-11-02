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
        private ErrorProvider nombreErrorProvider;
        private ErrorProvider emailErrorProvider;
        private string imageName;
        private List<Estudiante> estudianteList = new List<Estudiante>();

        public Form1()
        {
            InitializeComponent();


            dniErrorProvider = new ErrorProvider();
            nombreErrorProvider = new ErrorProvider();
            emailErrorProvider = new ErrorProvider();
            dniErrorProvider.SetIconAlignment(this.textBox1, ErrorIconAlignment.TopRight);
            nombreErrorProvider.SetIconAlignment(this.textBox3, ErrorIconAlignment.TopRight);
            nombreErrorProvider.SetIconAlignment(this.textBox4, ErrorIconAlignment.TopRight);
            emailErrorProvider.SetIconAlignment(this.textBox2, ErrorIconAlignment.TopRight);





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

           


            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(opnfd.FileName);
                imageName = opnfd.FileName;

                estudianteList.Add(new Estudiante(textBox1.Text, textBox3.Text, textBox4.Text, textBox2.Text, opnfd.FileName));


            }



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

            else
            {
                this.dniErrorProvider.SetError(textBox1, null);

            }
        }

        private void nombre_Validating(object sender, CancelEventArgs e)
        {
            var patron = @"^[a-z ,.'-]+$";
            Regex rgx = new Regex(patron);

            if (!rgx.IsMatch(textBox3.Text))
            {

                this.nombreErrorProvider.SetError(textBox3, "nombre no es correctro");
                e.Cancel = true;

            }

            else
            {
                this.nombreErrorProvider.SetError(textBox3, null);

            }


        }

        private void apellido_Validating(object sender, CancelEventArgs e)
        {

            var patron = @"^[a-z ,.'-]+$";
            Regex rgx = new Regex(patron);

            if (!rgx.IsMatch(textBox4.Text))
            {

                this.nombreErrorProvider.SetError(textBox4, "apellido no es correctro");
                e.Cancel = true;

            }
            else
            {
                this.nombreErrorProvider.SetError(textBox4, null);
            }

        }

        private void email_Validating(object sender, CancelEventArgs e)
        {

            var patron = @"^[a-z0-9._%+-]+@[a-z0-9.-]+.[a-z]$";
            Regex rgx = new Regex(patron);

            if (!rgx.IsMatch(textBox2.Text))
            {

                this.nombreErrorProvider.SetError(textBox2, "email no es correctro");
                e.Cancel = true;

            }
            else
            {
                this.nombreErrorProvider.SetError(textBox2, null);
            }
        }

        private void iconButton2_Click_1(object sender, EventArgs e)
        {

            if (this.ValidateChildren())
            {
                MessageBox.Show("Validation succeeded!");




            }
            else
            {
                MessageBox.Show("Validation failed.");
            }

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {


            foreach (var item in estudianteList)
            {

                label8.Text +=
                    label8.Text += "Dni::" + item.Dni + " " + " nombre "
                    + item.Nombre + "\r\n";

            }


        }
    }
}
