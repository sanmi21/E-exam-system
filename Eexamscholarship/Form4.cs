using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Eexamscholarship
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

            int finalscore, wrongans;
            double perc;
            string connectionstring = "datasource=127.0.0.1;port=3306;username=root;password=;database=eexam";
            string query = "select Score from User where Username = @user";

            MySqlConnection conn = new MySqlConnection(connectionstring);
            MySqlCommand cmd = new MySqlCommand(query, conn);
            conn.Open();
            cmd.Parameters.AddWithValue("user", Form1.User);
            MySqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string value = reader.GetString("Score");

            finalscore = int.Parse(value);
            Totalscoredisplay.Text = value;
            wrongans = 12-finalscore;
            double rightans = finalscore/12.0;
            perc = rightans*100;
            label3.Text = Form1.User.ToString();
            Wronganswersdisplay.Text = wrongans.ToString();
            Percentagedisplay.Text = perc.ToString("f2");
            if (perc>=75)
            {
                Remarkdisplay.Text = "Congratulations, you have been awarded the scholarship";
            }
            else
            {
                Remarkdisplay.Text = "Good score, but unfortunately scholarship requirements not met";
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("THANK YOU FOR WRITING EXAM");
            Application.Exit();
        }
    }
}
