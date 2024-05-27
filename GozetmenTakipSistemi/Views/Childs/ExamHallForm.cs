using System.Data;
using System.Data.SQLite;

namespace GozetmenTakipSistemi.Views.Childs
{
    public partial class ExamHallForm : Form
    {
        public ExamHallForm()
        {
            InitializeComponent();

            SQLiteConnection con = new SQLiteConnection();
            con.ConnectionString = @"Data Source =database.db";
            SQLiteDataAdapter adp = new SQLiteDataAdapter("select * from derslik", con);
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                adp.Fill(ds, "derslik");
                dataGridView1.DataSource = ds.Tables["derslik"];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata" + ex.Message);

            }
            finally
            {
                con.Close();
            }
        }

        private void buttonAddSupervisor_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection();
            con.ConnectionString = @"Data Source =database.db";
            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "insert into derslik (derslikadi, kapasite) VALUES (@derslikadi,@kapasite)";
            cmd.Parameters.AddWithValue("@derslikadi", textBoxNameHall.Text);
            cmd.Parameters.AddWithValue("@kapasite", numericUpDownCapacity.Value);
            try
            {
                if (textBoxNameHall.Text == "")
                {
                    MessageBox.Show("tüm alanları doldurunuz!");

                }
                else
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    textBoxNameHall.Text = string.Empty;
                    MessageBox.Show("derslik eklendi!");

                    SQLiteDataAdapter adp = new SQLiteDataAdapter("select * from derslik", con);
                    DataSet ds = new DataSet();
                    adp.Fill(ds, "derslik");
                    dataGridView1.DataSource = ds.Tables["derslik"];

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata" + ex.Message);

            }
            finally
            {
                con.Close();
            }
        }
        int selectedId;
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            DialogResult deleteRow = new DialogResult();
            deleteRow = MessageBox.Show("Kaydı silmek istediğinizden emin misiniz?", "Kayıt Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (deleteRow == DialogResult.Yes)
            {
                if (dataGridView1.SelectedRows.Count >= 1)
                {
                    selectedId = Convert.ToInt32(dataGridView1.SelectedCells[0].Value);


                    SQLiteConnection con = new SQLiteConnection();
                    con.ConnectionString = @"Data Source =database.db";
                    con.Open();
                    SQLiteCommand cmd = new SQLiteCommand(con);
                    cmd.CommandText = "delete from derslik where id = '" + selectedId + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Silindi", "Kayıt Sil");

                    SQLiteDataAdapter adp = new SQLiteDataAdapter("select * from derslik", con);
                    DataSet ds = new DataSet();
                    adp.Fill(ds, "derslik");
                    dataGridView1.DataSource = ds.Tables["derslik"];

                }
            }
        }
    }
}
