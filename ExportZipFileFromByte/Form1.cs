using Connect.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows.Forms;

namespace ExportZipFileFromByte
{
    public partial class frmGenZip : Form
    {
        public frmGenZip()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboBU.Items.Add("PU4");
            cboBU.Items.Add("PU6");
            cboBU.Items.Add("PU9");

            lbResult.Text = "";
            lbZipName.Text = "";
        }

        private void cboBU_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*--Get Program list from Application list of BU--*/
            lbResult.Text = "";
            if (cboBU.SelectedItem.ToString().Trim() == "PU4")
            {
                DataTable dt = dtQueryByBU("PU4");
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        cboProgram.Items.Add(row["StationName"].ToString().Trim());
                    }
                }
            }
            else if (cboBU.SelectedItem.ToString().Trim() == "PU6")
            {
                DataTable dt = dtQueryByBU("PU6");
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        cboProgram.Items.Add(row["StationName"].ToString().Trim());
                    }
                }
            }
            else if (cboBU.SelectedItem.ToString().Trim() == "PU9")
            {
                DataTable dt = dtQueryByBU("PU9");
                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        cboProgram.Items.Add(row["StationName"].ToString().Trim());
                    }
                }
            }
        }

        public DataTable dtQueryByBU(string strBU)
        {
            ConnectDBPU4 oConPu4 = new ConnectDBPU4();
            ConnectDBPU6 oConPu6 = new ConnectDBPU6();
            ConnectDBPU9 oConPu9 = new ConnectDBPU9();

            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "Select Distinct StationName from Application_ZipData With(nolock)";
            cmd.CommandTimeout = 180;
            if (strBU == "PU4")
            {
                dt = oConPu4.Query(cmd);
            }
            else if (strBU == "PU6")
            {
                dt = oConPu6.Query(cmd);
            }
            else if (strBU == "PU9")
            {
                dt = oConPu9.Query(cmd);
            }

            return dt;
        }

        private void cboProgram_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*--Clear Dgv--*/
            lbResult.Text = "";
            dgvZipfile.DataSource = null;

            /*--Get Zip file--*/
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT ZipName,UID,TransDatetime FROM Application_ZipData WHERE StationName = @stationName AND ZipName LIKE @zipName ORDER BY TransDatetime DESC";
            cmd.Parameters.Add(new SqlParameter("@stationName", cboProgram.SelectedItem.ToString().Trim()));
            cmd.Parameters.Add(new SqlParameter("@zipName", "%"));
            cmd.CommandTimeout = 180;

            DataTable dt = new DataTable();
            ConnectDBPU4 oConPu4 = new ConnectDBPU4();
            ConnectDBPU6 oConPu6 = new ConnectDBPU6();
            ConnectDBPU9 oConPu9 = new ConnectDBPU9();
            if (cboBU.SelectedItem.ToString().Trim() == "PU4")
            {
                dt = oConPu4.Query(cmd);
            }
            else if (cboBU.SelectedItem.ToString().Trim() == "PU6")
            {
                dt = oConPu6.Query(cmd);
            }
            else if (cboBU.SelectedItem.ToString().Trim() == "PU9")
            {
                dt = oConPu9.Query(cmd);
            }

            if (dt.Rows.Count > 0)
            {
                dgvZipfile.DataSource = dt.DefaultView;
            }
        }

        private void dgvZipfile_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*--Cell double click select row show in label--*/
            lbResult.Text = "";
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                lbZipName.Text = "";
                lbZipName.Text = dgvZipfile.Rows[e.RowIndex].Cells[0].Value.ToString().Trim();
            }
        }

        private void btnGenZip_Click(object sender, EventArgs e)
        {
            /*--Create ZIP file into D:\--*/
            lbResult.Text = "";
            if (lbZipName.Text != "")
            {
                /*---Get Byte from database---*/
                ConnectDBPU4 oConPu4 = new ConnectDBPU4();
                ConnectDBPU6 oConPu6 = new ConnectDBPU6();
                ConnectDBPU9 oConPu9 = new ConnectDBPU9();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select Top 1 FileData From Application_ZipData Where StationName = @StationName AND ZipName = @ZipName";
                cmd.Parameters.Add(new SqlParameter("@StationName", cboProgram.SelectedItem.ToString().Trim()));
                cmd.Parameters.Add(new SqlParameter("@ZipName", lbZipName.Text.Trim())); 
                cmd.CommandTimeout = 180;

                DataTable dt = new DataTable();
                if (cboBU.SelectedItem.ToString().Trim() == "PU4")
                {
                    dt = oConPu4.Query(cmd);
                }
                else if (cboBU.SelectedItem.ToString().Trim() == "PU6")
                {
                    dt = oConPu6.Query(cmd);
                }
                else if (cboBU.SelectedItem.ToString().Trim() == "PU9")
                {
                    dt = oConPu9.Query(cmd);
                }

                if (dt.Rows.Count > 0)
                {
                    foreach (DataRow row in dt.Rows)
                    {
                        //byte[] data = File.ReadAllBytes(<path>);
                        byte[] data = (byte[])row["FileData"];

                        /*---Write file into path---*/
                        string _tmpfile = "D:\\" + cboProgram.SelectedItem.ToString().Trim() + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".ZIP";
                        File.WriteAllBytes(_tmpfile, data); // Requires System.IO    
                        lbResult.Text = "Created Zip file to " + _tmpfile;   
                    }
                }
                /*---END Get Byte from database---*/
                //Application.Exit();
            }
            else
            {
                lbResult.Text = "No ZipName selected.";
            }
        }
    }
}
