using System.Data;
using System.Data.SQLite;

namespace GozetmenTakipSistemi.Views.Childs
{
    public partial class ExamListForm : Form
    {
        public ExamListForm()
        {
            InitializeComponent();

            TimePicker.CustomFormat = "hh:mm";
            TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            datePicker.CustomFormat = "dd-mm-yyyy";
            TimePicker.CustomFormat = "hh:mm";
        }

        private void ExamListForm_Load(object sender, EventArgs e)
        {

            SQLiteConnection con = new SQLiteConnection();
            con.ConnectionString = @"Data Source =database.db";
            SQLiteDataAdapter adp = new SQLiteDataAdapter("select * from sinav", con);
            DataSet ds = new DataSet();
            try
            {
                con.Open();
                adp.Fill(ds, "sinav");
                dataGridView1.DataSource = ds.Tables["sinav"];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata" + ex.Message);

            }
            finally
            {
                con.Close();
            }



            con.ConnectionString = @"Data Source =database.db";
            SQLiteCommand cmd = new SQLiteCommand("select * from gozetmen", con);
            SQLiteCommand cmd2 = new SQLiteCommand("select * from derslik", con);

            try
            {
                SQLiteDataReader dr;
                con.Open();

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    comboBoxEleman.Items.Add(dr["unvan"].ToString() + " " + dr["adsoyad"].ToString());
                }


                SQLiteDataReader dr2;

                dr2 = cmd2.ExecuteReader();

                while (dr2.Read())
                {
                    comboBoxDerslik.Items.Add(dr2["derslikadi"].ToString());
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

        private void buttonAddExam_Click(object sender, EventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection();
            con.ConnectionString = @"Data Source =database.db";
            SQLiteCommand cmd = new SQLiteCommand(con);
            cmd.CommandText = "insert into sinav (dersadi, derskodu, ogrele, bolum, tarih, saat, ogrencisayisi, derslik) VALUES (@dersadi,@derskodu,@ogrele,@bolum,@tarih,@saat,@ogrencisayisi,@derslik)";
            cmd.Parameters.AddWithValue("@dersadi", textBoxDersAdi.Text);
            cmd.Parameters.AddWithValue("@derskodu", textBoxDersKodu.Text);
            cmd.Parameters.AddWithValue("@ogrele", comboBoxEleman.Text);
            cmd.Parameters.AddWithValue("@bolum", textBoxBolum.Text);
            cmd.Parameters.AddWithValue("@tarih", datePicker.Value.ToString());
            cmd.Parameters.AddWithValue("@saat", TimePicker.Value.ToShortTimeString());
            cmd.Parameters.AddWithValue("@ogrencisayisi", numericUpDownCapacity.Value);
            cmd.Parameters.AddWithValue("@derslik", comboBoxDerslik.Text);

            try
            {
                if (textBoxDersAdi.Text == "")
                {
                    MessageBox.Show("tüm alanları doldurunuz!");

                }
                else
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    textBoxDersAdi.Text = string.Empty;
                    textBoxDersKodu.Text = string.Empty;
                    comboBoxEleman.Text = "Öğretim elemanı";
                    MessageBox.Show("sınav eklendi!");

                    SQLiteDataAdapter adp = new SQLiteDataAdapter("select * from sinav", con);
                    DataSet ds = new DataSet();
                    adp.Fill(ds, "sinav");
                    dataGridView1.DataSource = ds.Tables["sinav"];

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
                    cmd.CommandText = "delete from sinav where id = '" + selectedId + "'";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Kayıt Silindi", "Kayıt Sil");

                    SQLiteDataAdapter adp = new SQLiteDataAdapter("select * from sinav", con);
                    DataSet ds = new DataSet();
                    adp.Fill(ds, "sinav");
                    dataGridView1.DataSource = ds.Tables["sinav"];

                }
            }
        }
    }
}
