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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private bool validate()
        {
            if (txtUser.Text == String.Empty || txtPassword.Text == String.Empty || txtPassword.Text != "Scholarship")
                return false;
            return true;
        }

         public static string User;

        private void button1_Click(object sender, EventArgs e)
        {
            string user;
             if (validate())
            {
                user = txtUser.Text;
                string connectionstring = "datasource=127.0.0.1;port=3306;username=root;password=;database=eexam;";
                string query = "select * from user where username = @user ";
                MySqlConnection conn = new MySqlConnection(connectionstring);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@user", user);
                try
                {
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();       // 2
                    if (reader.HasRows)                 // 3
                    {
                        User = user;
                        MessageBox.Show("Successful Login");
                        Form2 frm1 = new Form2();               // 4
                        this.Hide();                    // 5. hide the login form
                        frm1.ShowDialog();          // 6. display the other form in modal mode
                        this.Close();       // 7. close this form (login form) when the modal form closes
                    }
                    else
                    {
                        MessageBox.Show("At least one of the username/password is wrong..");
                        conn.Close();
                    }
                       
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("An error occurred, details as follows: " + ex.Message);
                }
            } // exit point of validate()
            else
            {
                MessageBox.Show("Input your username and password");
            }
        } // exit point of button click event


    }
}

        
  

