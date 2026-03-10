using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AkademikADOApp1
{
    public partial class Form1 : Form
    {
        string connString =
            "Data Source=DESKTOP-V6AL6JT\\ZAKYZEIN;Initial Catalog=DBAkademikADO;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }
        //Object SqlConnection
        SqlConnection conn;
        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                conn = new SqlConnection(connString);
                conn.Open();
                lblStatus.Text = "Status: Berhasil TerConnect Capt";
                MessageBox.Show("Koneksi ke Database Berhasil!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Koneksi Gagal : " + ex.Message);
            }
        }

        private void btnDisconnected_Click(object sender, EventArgs e)
        {
            try
            {
                if (conn != null && conn.State == System.Data.ConnectionState.Open)
                {
                    // Memutus koneksi ke database
                    conn.Close();

                    // Memperbarui status pada label
                    lblStatus.Text = "Status : Database Disconnected";

                    // Menampilkan pesan sukses
                    MessageBox.Show("Koneksi tidak bisa terhubung");
                }
                else
                {
                    MessageBox.Show("Database memang belum terhubung.");
                }
            }
            catch (Exception ex)
            {
                // Menampilkan pesan jika terjadi error saat memutus koneksi
                MessageBox.Show("Gagal memutus koneksi: " + ex.Message);
            }
        }
    }
}


