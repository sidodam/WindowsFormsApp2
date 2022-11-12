using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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


        //private ErrorProvider dniErrorProvider;
        //private ErrorProvider nombreErrorProvider;
        //private ErrorProvider emailErrorProvider;
        private string imageName;
        private List<Estudiante> estudianteList = new List<Estudiante>();

        public Form1()
        {
            InitializeComponent();


            //dniErrorProvider = new ErrorProvider();
            //nombreErrorProvider = new ErrorProvider();
            //emailErrorProvider = new ErrorProvider();
            //dniErrorProvider.SetIconAlignment(this.textBox1, ErrorIconAlignment.TopRight);
            //nombreErrorProvider.SetIconAlignment(this.textBox3, ErrorIconAlignment.TopRight);
            //nombreErrorProvider.SetIconAlignment(this.textBox4, ErrorIconAlignment.TopRight);
            //emailErrorProvider.SetIconAlignment(this.textBox2, ErrorIconAlignment.TopRight);


            string conncectionString;
            SqlConnection cnn;

            conncectionString = @"Data Source=DESKTOP-FSTJBGL;Initial Catalog=estudiosDB; Integrated Security=True;";


            cnn = new SqlConnection(conncectionString);
            cnn.Open();


            SqlCommand sqlQuery = new SqlCommand("select nombre from ciclo", cnn);

            SqlDataReader datareader;
            string sql;


            datareader = sqlQuery.ExecuteReader();

            while (datareader.Read())
            {

                comboBox1.Items.Add(datareader.GetString(0));
            }
            cnn.Close();


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

            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(opnfd.FileName);
                imageName = opnfd.FileName;


            }

        }

      

      

   

        private void iconButton2_Click_1(object sender, EventArgs e)
        {


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

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
            {

            var id = 0;
       


            string conncectionString;
            SqlConnection cnn;

            conncectionString = @"Data Source=DESKTOP-FSTJBGL;Initial Catalog=estudiosDB; Integrated Security=True;";



            //INSERT INTO estudiante VALUES(1  , 'NIDO' , 'DIDO', 'RIDO' , 'SIDO@GAM.COM' )
            String sqlQuery = $"INSERT INTO estudiante VALUES({id}  , '{textBox3.Text}' , '{textBox4.Text}', '{textBox6.Text}' , '{textBox2.Text}' )";
            id++;


            cnn = new SqlConnection(conncectionString);
            cnn.Open();
            SqlCommand cl = new SqlCommand(sqlQuery, cnn);

            cl.ExecuteNonQuery();
          
            cnn.Close();

        }

        private void button4_Click(object sender, EventArgs e)
        {
         
            Form2 f2 = new Form2();
            Close();
            f2.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }
    }
}
