using System.Data;
using System.Data.SQLite;

namespace GozetmenTakipSistemi.Views.Childs
{
    public partial class SupervisorForm : Form
    {
        public SupervisorForm()
        {
            InitializeComponent();
        }

        private void SupervisorForm_Load(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection();
            con.ConnectionString = @"Data Source =database.db";
            SQLiteDataAdapter adp = new SQLiteDataAdapter("select * from gozetmen", con);
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                adp.Fill(ds, "gozetmen");
                dataGridView1.DataSource = ds.Tables["gozetmen"];

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
            cmd.CommandText = "insert into gozetmen (adsoyad, unvan, durum) VALUES (@ad,@unvan,@durum)";
            cmd.Parameters.AddWithValue("@ad", textBoxName.Text);
            cmd.Parameters.AddWithValue("@unvan", comboBoxUnvan.Text);
            cmd.Parameters.AddWithValue("@durum", comboBoxDurum.Text == "Aktif" ? 1 : 0);
            try
            {
                if (textBoxName.Text == "")
                {
                    MessageBox.Show("tüm alanları doldurunuz!");

                }
                else
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    textBoxName.Text = string.Empty;
                    MessageBox.Show("Kullanıcı eklendi!");

                    SQLiteDataAdapter adp = new SQLiteDataAdapter("select * from gozetmen", con);
                    DataSet ds = new DataSet();
                    adp.Fill(ds, "gozetmen");
                    dataGridView1.DataSource = ds.Tables["gozetmen"];

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
        private void button2_Click(object sender, EventArgs e)
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
                    cmd.CommandText = "delete from gozetmen where id = '" + selectedId + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Silindi", "Kayıt Sil");

                    SQLiteDataAdapter adp = new SQLiteDataAdapter("select * from gozetmen", con);
                    DataSet ds = new DataSet();
                    adp.Fill(ds, "gozetmen");
                    dataGridView1.DataSource = ds.Tables["gozetmen"];

                }
            }
        }
    }
}
