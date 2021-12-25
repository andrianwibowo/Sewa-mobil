using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AplikasiSewaMobilku
{
    public partial class FormMobilku : Form
    {
        String sql;
        SqlCommand cmd;
        SqlDataReader rd;

        public FormMobilku()
        {
            InitializeComponent();
            LoadDatamobilku();
        }

        public void LoadDatamobilku()
        {
            Koneksi.Open();

            sql = " select * from MOBILKU order by nama mobil";
            cmd = new SqlCommand(sql, Koneksi.conn);
            rd = cmd.ExecuteReader();

            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    int n = dataGridView1.Rows.Add();
                    dataGridView1.Rows[n].Cells[0].Value = rd["id_mobil"].ToString();
                    dataGridView1.Rows[n].Cells[1].Value = rd["nama_mobil"].ToString();
                    dataGridView1.Rows[n].Cells[2].Value = rd["id_mobil"].ToString();
                    dataGridView1.Rows[n].Cells[3].Value = rd["tahun"].ToString();
                    dataGridView1.Rows[n].Cells[4].Value = rd["rating"].ToString();
                    dataGridView1.Rows[n].Cells[5].Value = rd["kategori"].ToString();
                    dataGridView1.Rows[n].Cells[6].Value = rd["harga_sewa"].ToString();


                }
            }
            rd.Close();
            Koneksi.Close();
            cmd.Dispose();
        }
    }
}
