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
    public partial class Main : Form
    {
        String userId;
        public Main(String userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void getNotes (object sender, TabControlCancelEventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridViewNotes.Rows[e.RowIndex];
                String noteId = row.Cells["id"].Value.ToString();
                this.Hide();
                AddNote ss = new AddNote(userId, noteId);
                ss.Show();
            }

            }

        private void Main_Load(object sender, EventArgs e)
        {
            String connectionString = "Server=localhost;Database=planner_csharp;Uid=root;Password=;SslMode=none";
            MySqlConnection connection = new MySqlConnection(connectionString);

            dataGridViewNotes.Columns.Clear();
            dataGridViewNotes.Refresh();

            try
            {
                String sql = "SELECT id, note, date FROM notes WHERE user_id = '" + this.userId + "' ORDER BY date DESC";
                MySqlDataAdapter getNotes = new MySqlDataAdapter(sql, connection);
                DataSet dataSet = new DataSet();
                getNotes.Fill(dataSet);
                dataGridViewNotes.DataSource = dataSet.Tables[0];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void buttonAddNote_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddNote ss = new AddNote(this.userId);
            ss.Show();
        }


 
        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            this.Close();
            Login ss = new Login();
            ss.Show();
        }

        private void dataGridViewNotes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
