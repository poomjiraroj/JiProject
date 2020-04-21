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
    public partial class IPDreport : Form
    {
        SqlConnection Conn;
        SqlCommand cmd;
        SqlDataReader Reader;
        SqlDataAdapter Da;
        DataSet Ds;
        DataTable Dt;

        String PID;
        public IPDreport(String PID)
        {
            InitializeComponent();
            String strConn = "Data Source=JICOMPUTER;Initial Catalog=Tricus_Data;Integrated Security=True";
            Conn = new SqlConnection(strConn);
            this.PID = PID;
            Query();
        }

        public void Query()
        {
            Conn.Open();
            String SQL = "Select Accept.Time, PatientData.HN, sentPhysician.SID, PatientData.PatientFirstname + ' ' +PatientData.PatientLastname As PatientName, Accept.BID, Ward.WID + ' ' + Ward.Wardname As Ward ";
            SQL += "From Accept Inner Join PatientData On dbo.Accept.HN = PatientData.HN ";
            SQL += "Inner Join Bed On Accept.BID = Bed.BID Inner Join Ward ON Bed.WID = Ward.WID ";
            SQL += "Inner Join sentPhysician On Accept.SID = sentPhysician.SID ";
            SQL += "Inner Join PhysicianData On Accept.PID = PhysicianData.PID ";
            SQL += "Where PhysicianData.PID = '" + PID + "' and sentPhysician.Status = 'I' ";
            cmd = new SqlCommand(SQL, Conn);
            Da = new SqlDataAdapter(cmd);
            Ds = new DataSet();
            Dt = new DataTable();
            Da.Fill(Ds, "Patient");
            Dt = Ds.Tables["Patient"];
            gvIPDreport.DataSource = Dt;
            gvIPDreport.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvIPDreport.Columns[0].FillWeight = 40;
            gvIPDreport.Columns[1].FillWeight = 25;
            gvIPDreport.Columns[2].FillWeight = 25;
            gvIPDreport.Columns[3].FillWeight = 70;
            gvIPDreport.Columns[4].FillWeight = 25;
            gvIPDreport.Columns[5].FillWeight = 30;

            Conn.Close();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvIPDreport_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int curRow = gvIPDreport.CurrentRow.Index;
            ReportPatient RP = new ReportPatient(Dt.Rows[curRow]["HN"].ToString(), Dt.Rows[curRow]["SID"].ToString(), Dt.Rows[curRow]["BID"].ToString());
            RP.Show();
            this.Close();
        }
    }
}
