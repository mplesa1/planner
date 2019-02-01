using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace planner
{
    public partial class AddNote : Form
    {
        String user_id;
        String note_id;
        public AddNote(String user_id)
        {
            InitializeComponent();
            this.user_id = user_id;
        }

        public AddNote(String user_id,  String note_id)
        {
            InitializeComponent();
            this.user_id = user_id;
            this.note_id = note_id;
        }

        private void AddNote_Load(object sender, EventArgs e)
        {
            if (note_id != null)
            {
                String connectionString = "Server=localhost;Database=planner_csharp;Uid=root;Password=;SslMode=none";
                MySqlConnection connection = new MySqlConnection(connectionString);

                textBoxNote.Clear();
                dateTimePickerNote.Refresh();
                try
                {
                    String sql = "SELECT * FROM notes WHERE id = '" + this.note_id + "'";
                    MySqlDataAdapter getNotes = new MySqlDataAdapter(sql, connection);
                    DataSet dataSet = new DataSet();
                    getNotes.Fill(dataSet);
                    String note = Convert.ToString(dataSet.Tables[0].Rows[0]["note"]);
                    textBoxNote.Text = note;
                    String noteDate = Convert.ToString(dataSet.Tables[0].Rows[0]["date"]);
                    dateTimePickerNote.Text = noteDate;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            } else
            {
                buttonDelete.Hide();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void submitNote_click(object sender, EventArgs e)
        {
            if (this.textBoxNote.Text != string.Empty && this.dateTimePickerNote.Value != null)
            {
                String connString = "Server=localhost;Database=planner_csharp;Uid=root;Password=;SslMode=none";
                MySqlConnection conn = new MySqlConnection(connString);

                try
                {

                    MySqlCommand command = conn.CreateCommand();
                    if (note_id == null)
                    {
                        command.CommandText = "INSERT INTO notes (note, date, user_id) VALUES ('" + this.textBoxNote.Text + "','" + this.dateTimePickerNote.Value.Date.ToString("yyyy-MM-dd HH:mm:ss") + "', '" + this.user_id + "')";
                    }
                    else
                    {
                        command.CommandText = "UPDATE notes SET note = '" + this.textBoxNote.Text + "', date = '" + this.dateTimePickerNote.Value.Date.ToString("yyyy-MM-dd HH:mm:ss") + "' WHERE id = '" + this.note_id +"'";
                    }
                    System.Diagnostics.Debug.WriteLine(command.CommandText);
                    conn.Open();
                    int isSuccesfull = command.ExecuteNonQuery();


                    if (isSuccesfull == 1)
                    {
                        MessageBox.Show("Uspješno ste dodali/izmjenili zapis !");
                        this.Hide();
                        this.buttonCancel_Click("", null);
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

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main ss = new Main(this.user_id);
            ss.Show();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(note_id != null)
            {
                String connString = "Server=localhost;Database=planner_csharp;Uid=root;Password=;SslMode=none";
                MySqlConnection conn = new MySqlConnection(connString);
                try
                {

                    MySqlCommand command = conn.CreateCommand();
                    command.CommandText = "DELETE FROM notes WHERE id = '" + this.note_id + "'";
                    System.Diagnostics.Debug.WriteLine(command.CommandText);
                    conn.Open();
                    int isSuccesfull = command.ExecuteNonQuery();


                    if (isSuccesfull == 1)
                    {
                        MessageBox.Show("Uspješno ste izbrisali zapis !");
                        this.Hide();
                        this.buttonCancel_Click("", null);
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
        }
        
    }
}
