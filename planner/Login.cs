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

namespace planner
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }


    private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            String connString = "Server=localhost;Database=planner_csharp;Uid=root;Password=;SslMode=none";
            MySqlConnection conn = new MySqlConnection(connString);
            String userId;
           
            try
            {
                conn.Open();
                MySqlCommand command = conn.CreateCommand();
                command.CommandText = "SELECT id FROM users WHERE email='" + this.textBoxEmail.Text + "' AND password='" + this.textBoxPassword.Text + "' ";
                MySqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows == true)
                {
                    if (reader.Read()) { 
                        userId = reader["id"].ToString();
                        this.Hide();
                        Main ss = new Main(userId);
                        ss.Show();
                    }  
                }
                else
                {
                    MessageBox.Show("Email ili lozinka su neispravni!");
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void redirect_reg_Click(object sender, EventArgs e)
        {
            this.Hide();
            Reg ss = new Reg();
            ss.Show();
        }
    }
}
