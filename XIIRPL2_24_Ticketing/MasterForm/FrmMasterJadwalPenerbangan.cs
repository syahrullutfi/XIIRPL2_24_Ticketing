using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XIIRPL2_24_Ticketing;

namespace XIIRPL2_24_Ticketing.MasterForm
{
    public partial class FrmMasterJadwalPenerbangan : Form
    {

        public NpgsqlCommand cmd;
        public NpgsqlDataReader dr;
        public FrmMasterJadwalPenerbangan()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void view_data()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM tbl_jadwalpenerbangan", Koneksi.conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView2.DataSource = dt;
        }
        public void View_data()
        {
            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter("SELECT * FROM tbl_jadwalpenerbangan", Koneksi.conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void FrmMasterJadwalPenerbangan_Load(object sender, EventArgs e)
        {
            view_data();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView2.Columns[e.ColumnIndex].HeaderText == "Delete")
            {
                int id;
                id = Convert.ToInt32(dataGridView2.Rows[e.RowIndex].Cells["id"].Value);
                try
                {
                    Koneksi.conn.Open();
                    String sql = "DELETE FROM tbl_jadwalpenerbangan WHERE id=@id";
                    cmd = new NpgsqlCommand(sql, Koneksi.conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    int result = cmd.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Data Berhasil Dihapus");
                        view_data();
                    }
                    else
                    {
                        MessageBox.Show("Data Tidak Berhasil Dihapus");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    Koneksi.conn.Close();
                }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    Koneksi.conn.Open();
                    String sql = "INSERT INTO tbl_jadwalpenerbangan" +
                    "(kodepenerbangan,bandarakeberangkatanid,bandaratujuanid,maskapaiid,tanggalwaktukeberangkatan,durasipenerbangan,hargapertiket)" + "VALUES" + "('" + txtkodepenerbangan.Text + "','" + txtbandarakeberangkatanid.Text + "','" + "('" + txtbandaratujuanid.Text + "','" + txtmaskapaiid.Text + "','" + txttanggalwaktukeberangkatan.Text + "','" + txtwaktukeberangkatan.Text + "','" + txtdurasipenerbangan.Text + "','" + txthargapertiket.Text + "')";
                    cmd = new NpgsqlCommand(sql, Koneksi.conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Berhasil Simpan Data Bandara");
                    Koneksi.conn.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
