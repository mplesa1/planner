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
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();
        }

        private void login_redirect_Click(object sender, EventArgs e)
        {
            this.Close();
            Login ss = new Login();
            ss.Show();
        }

        private void registration_Click(object sender, EventArgs e)
        {
            if(this.textBoxEmail.Text != string.Empty && this.textBoxPassword.Text != string.Empty && 
                this.textBoxFirstName.Text != string.Empty && this.textBoxLastName.Text != string.Empty)
            {
                String connString = "Server=localhost;Database=planner_csharp;Uid=root;Password=;SslMode=none";
                MySqlConnection conn = new MySqlConnection(connString);

                try
                {
                  
                    MySqlCommand command = conn.CreateCommand();
                    command.CommandText = "INSERT INTO users (email, password, fname, lname) VALUES ('" + this.textBoxEmail.Text + "','" + this.textBoxPassword.Text + "', '" + this.textBoxFirstName.Text + "','" + this.textBoxLastName.Text + "')" ;
                    conn.Open();
                    int isSuccesfull = command.ExecuteNonQuery();
                    

                    if (isSuccesfull == 1)
                    {
                        MessageBox.Show("Uspješno ste se registrirali !");
                        this.Close();
                        this.login_redirect_Click("", null);
                    }
                    else
                    {
                        MessageBox.Show("Email već postoji u bazi podataka !");
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
            else
            {
                MessageBox.Show("Ispunite sva obavezna polja !");
            }
        }
    }
}
