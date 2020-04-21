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

namespace TricuslabSoftware
{
    public partial class BPMsetting : Form
    {
        SqlConnection Conn;
        SqlCommand cmd;
        SqlDataReader Reader;

        public bool IsSelect = false;
        String BID;
        public BPMsetting(String BID)
        {
            InitializeComponent();
            this.BID = BID;
            String strConn = "Data Source=JICOMPUTER;Initial Catalog=Tricus_Data;Integrated Security=True";
            Conn = new SqlConnection(strConn);
            setData();
        }

        public void setData()
        {
            lbBID.Text = BID;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Conn.Open();
            String SQL = "Update Bed ";
            SQL += "Set HighPR = " + txtHighPR.Text + ", HighPRSA = " + txtHighPRSA.Text + ", LowPRSA = " + txtLowPRSA.Text + ", LowPR = " + txtLowPR.Text + " ";
            SQL += "Where BID = '" + BID + "' ";
            cmd = new SqlCommand(SQL, Conn);
            try
            {
                cmd.ExecuteNonQuery();
                IsSelect = true;
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please Insert Correct Value");
            }
        }
    }
}
