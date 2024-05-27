using ClosedXML.Excel;
using GozetmenTakipSistemi.Models;
using System.Data;
using System.Data.SQLite;

namespace GozetmenTakipSistemi.Views.Childs
{
    public partial class AssignmentForm : Form
    {
        public AssignmentForm()
        {
            InitializeComponent();
        }


        private void btnAtamaYap_Click(object sender, EventArgs e)
        {
            List<ClassRoom> classRooms = new List<ClassRoom>();
            List<Supervisor> supervisors = new List<Supervisor>();
            List<Exam> exams = new List<Exam>();

            SQLiteConnection con = new SQLiteConnection();
            con.ConnectionString = @"Data Source =database.db";
            con.Open();

            try
            {
                SQLiteCommand cmd = new SQLiteCommand("select * from derslik", con);
                SQLiteDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ClassRoom classRoom = new ClassRoom();
                    classRoom.id = Convert.ToInt32(dr[0]);
                    classRoom.derslikAdi = Convert.ToString(dr[1]);
                    classRoom.kapasite = Convert.ToInt32(dr[2]);
                    classRooms.Add(classRoom);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Derslik Hata" + ex.Message);

            }
            try
            {
                SQLiteCommand cmd = new SQLiteCommand("select * from gozetmen", con);
                SQLiteDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Supervisor superVisor = new Supervisor();
                    superVisor.id = Convert.ToInt32(dr[0]);
                    superVisor.name = Convert.ToString(dr[1]);
                    superVisor.unvan = Convert.ToString(dr[2]);
                    superVisor.durum = Convert.ToInt32(dr[3]);
                    if (superVisor.durum == 1)
                    {
                        supervisors.Add(superVisor);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Gözetmen Hata " + ex.Message);

            }
            try
            {
                SQLiteCommand cmd = new SQLiteCommand("select * from sinav", con);
                SQLiteDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Exam exam = new Exam();
                    exam.id = Convert.ToInt32(dr[0]);
                    exam.dersadi = Convert.ToString(dr[1]);
                    exam.derskodu = Convert.ToString(dr[2]);
                    exam.ogrele = Convert.ToString(dr[3]);
                    exam.bolum = Convert.ToString(dr[4]);
                    exam.tarih = Convert.ToString(dr[5]);
                    exam.saat = Convert.ToString(dr[6]);
                    exam.ogrencisayisi = Convert.ToInt32(dr[7]);
                    exam.derslik = Convert.ToString(dr[8]);
                    exams.Add(exam);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Sınav Hata" + ex.Message);

            }
            finally
            {
                con.Close();
            }
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("Öğretim Elemanı");
            dataTable.Columns.Add("Ders Kodu");
            dataTable.Columns.Add("Bölüm");
            dataTable.Columns.Add("Ders Adı");
            dataTable.Columns.Add("Tarih");
            dataTable.Columns.Add("Saat");
            dataTable.Columns.Add("Öğrenci Sayısı");

            for (int i = 0; i < classRooms.Count; i++)
            {
                dataTable.Columns.Add(classRooms[i].derslikAdi);

                if (classRooms[i].kapasite >= 70)
                {
                    dataTable.Columns.Add(classRooms[i].derslikAdi + " ");

                }

            }

            for (int i = 0; i < exams.Count; i++)
            {
                DataRow dataRow = dataTable.NewRow();

                dataRow[0] = exams[i].ogrele;
                dataRow[1] = exams[i].derskodu;
                dataRow[2] = exams[i].bolum;
                dataRow[3] = exams[i].dersadi;
                dataRow[4] = exams[i].tarih;
                dataRow[5] = exams[i].saat;
                dataRow[6] = exams[i].ogrencisayisi;

                Random random = new Random();


                if (exams[i].ogrencisayisi <= 40)
                {
                    int randomSupervisor = random.Next(supervisors.Count);
                    int randomClassroom = random.Next(7, dataTable.Columns.Count);

                    dataRow[randomClassroom] = supervisors[randomSupervisor].name;
                }
                else if (exams[i].ogrencisayisi > 40 && exams[i].ogrencisayisi <= 70)
                {

                    int randomClassroom = random.Next(7, dataTable.Columns.Count);
                    int randomSupervisor = random.Next(supervisors.Count);
                    dataRow[randomClassroom] = supervisors[randomSupervisor].name;
                    supervisors.RemoveAt(randomSupervisor);

                    int randomClassroom2;
                    do
                    {
                        randomClassroom2 = random.Next(7, dataTable.Columns.Count);

                    } while (randomClassroom2 == randomClassroom);


                    int randomSupervisor2 = random.Next(supervisors.Count);
                    dataRow[randomClassroom2] += supervisors[randomSupervisor2].name;
                }
                else if (exams[i].ogrencisayisi > 70)
                {
                    int randomClassroom = random.Next(7, dataTable.Columns.Count);
                    int randomSupervisor = random.Next(supervisors.Count);
                    dataRow[randomClassroom] = supervisors[randomSupervisor].name;
                    supervisors.RemoveAt(randomSupervisor);

                    int randomClassroom2;
                    do
                    {
                        randomClassroom2 = random.Next(7, dataTable.Columns.Count);

                    } while (randomClassroom == randomClassroom2);

                    int randomSupervisor2 = random.Next(supervisors.Count);
                    dataRow[randomClassroom2] += supervisors[randomSupervisor2].name;
                    supervisors.RemoveAt(randomSupervisor2);

                    int randomClassroom3;
                    do
                    {
                        randomClassroom3 = random.Next(7, dataTable.Columns.Count);

                    } while (randomClassroom == randomClassroom2 || randomClassroom == randomClassroom3 || randomClassroom2 == randomClassroom3);
                    int randomSupervisor3 = random.Next(supervisors.Count);
                    dataRow[randomClassroom3] += supervisors[randomSupervisor3].name;

                }

                dataTable.Rows.Add(dataRow);
            }

            dataGridView1.DataSource = dataTable;

            classRooms = null;
            supervisors = null;
            exams = null;
        }

        private void buttonExportExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Excel Dosyası|*.xlsx" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (XLWorkbook workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("Tablo");
                            // Sütun başlıklarını ekle
                            for (int i = 0; i < dataGridView1.Columns.Count; i++)
                            {
                                worksheet.Cell(1, i + 1).Value = dataGridView1.Columns[i].HeaderText;
                            }

                            // Verileri ekle
                            for (int i = 0; i < dataGridView1.Rows.Count; i++)
                            {
                                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                                {
                                    worksheet.Cell(i + 2, j + 1).Value = dataGridView1.Rows[i].Cells[j].Value?.ToString();
                                }
                            }
                            workbook.SaveAs(saveFileDialog.FileName);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata oluştu." + ex.Message);
                    }
                }
            }
        }
    }
}
