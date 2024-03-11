using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Microsoft.Win32.SafeHandles;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;


namespace Eexamscholarship
{
    public partial class Form3 : Form
    {
        int t, questioncounter;
        int score = 0;
        const int MaxArrayLength = 10;
        int currentIndex;
        int[] questionarray;
        public static string timer;

        public Form3()
        {
            InitializeComponent();
            currentIndex = 0;
            questioncounter=1;
            questionarray = new int[MaxArrayLength];
        }

        string[] answers = new string[12];
        string[] userChoices = new string[12];
        class Global
        {
            public static int Id;
            public static string Correct;

        }
        // Method used to generate question from databse
        void questiongenerate()
        {

            string Question;
            Question = string.Empty;
            var random = new Random();
            Global.Id = random.Next(1, 13);


            RadioButton[] questionOptions = { radioButton1, radioButton2, radioButton3 };
            foreach (RadioButton button in questionOptions)
            {
                if (button.Checked)
                {
                    userChoices[Global.Id - 1] = button.Text;
                    button.Checked = false;
                }
            }
            


            string connectionstring = "datasource=127.0.0.1;port=3306;username=root;password=;database=eexam;";
            string query = "select * from eexam_question where ID = @Id ";

            MySqlConnection conn = new MySqlConnection(connectionstring);
            conn.Open();
            MySqlCommand cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("Id",Global.Id);
            MySqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())  
            {
                label1.Text = reader["Question"].ToString();
                radioButton1.Text = reader["Potentialans1"].ToString();
                radioButton2.Text = reader["Potentialans2"].ToString();
                radioButton3.Text = reader["Potentialans3"].ToString();
                Global.Correct = reader["Correctans"].ToString();
                answers[Global.Id - 1] = reader["Correctans"].ToString();

            }
        }

        //method to check for correct answers
        void mark_answers()
        {
            for (int i = 0; i < answers.Length; i++)
            {
                if (answers[i] != null && userChoices[i] != null && answers[i] == userChoices[i])
                {
                    score++;
                }
            }
        }
        //Method to stop exam when timer is done
        public bool Timestop()
        {
            
                timer1.Stop();
               // mark_answers();
                MessageBox.Show("Time for exam has ended. Please Click the end exam button and proceed to the exam analysis page");
                EndExambutton.Visible = true;
                NextQuestionbutton.Enabled = false;
                return true;


        }

        private void Form3_Load(object sender, EventArgs e)
        {
            questiongenerate();
            questcounter.Text= questioncounter.ToString();


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            String myt = t.ToString();
            Timelabel.Text= myt;
            t++;
            if (int.Parse(myt)==45)
            {
                Timestop();
            }
           
        }


        private void button1_Click(object sender, EventArgs e)
        {
            questiongenerate();

            if (currentIndex >= MaxArrayLength)
            {
                EndExambutton.Visible = true;
                NextQuestionbutton.Enabled = false;
                return;
            }
            bool exists = ArrayContains(questionarray, Global.Id);

            while (exists)
            {
                questiongenerate();
                exists = ArrayContains(questionarray, Global.Id);
            }

            questionarray[currentIndex] = Global.Id;
            currentIndex++;
            questioncounter++;
            questcounter.Text= questioncounter.ToString();

        }

        private bool ArrayContains(int[] array, int value)
        {
            foreach (int element in array)
            {
                if (element == value)
                {
                    return true;
                }
            }

            return false;
        }
        private void EndExambutton_Click(object sender, EventArgs e)
        {
                mark_answers();
                string connectionstring = "datasource=127.0.0.1;port=3306;username=root;password=;database=eexam;"; // 4
                string query = "update user set Score= @score where Username = @user";
                MySqlConnection conn = new MySqlConnection(connectionstring);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("score", score);
                cmd.Parameters.AddWithValue("user", Form1.User);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show(score.ToString());
                Form4 frm3 = new Form4();
                this.Hide();
                frm3.ShowDialog();
                this.Close();
            
        }
    }
}

