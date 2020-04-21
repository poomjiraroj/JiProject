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
    public partial class PreOPD : Form
    {
        SqlConnection Conn;
        SqlCommand cmd;
        SqlDataAdapter Da;
        DataSet Ds;
        DataTable Dt;

        String PID;

        public PreOPD(String PID)
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
            String SQL = "Select sentPhysician.SID, sentPhysician.Time, sentPhysician.HN, PatientData.PatientFirstname + ' ' + PatientData.PatientLastname As PatientName, PatientData.Gender ";
            SQL += "From sentPhysician INNER JOIN PatientData ON sentPhysician.HN = PatientData.HN Where PID = '" + PID + "' and sentPhysician.Status = 'P' ";
            cmd = new SqlCommand(SQL, Conn);
            Da = new SqlDataAdapter(cmd);
            Ds = new DataSet();
            Dt = new DataTable();
            Da.Fill(Ds, "Patient");
            Dt = Ds.Tables["Patient"];
            gvPreOPDPatient.DataSource = Dt;
            gvPreOPDPatient.ReadOnly = true;
            gvPreOPDPatient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvPreOPDPatient.Columns[0].FillWeight = 25;
            gvPreOPDPatient.Columns[1].FillWeight = 50;
            gvPreOPDPatient.Columns[2].FillWeight = 25;
            gvPreOPDPatient.Columns[4].FillWeight = 25;
            Conn.Close();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gvPreOPDPatient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int curRow = gvPreOPDPatient.CurrentRow.Index;
            Diagnosis ds = new Diagnosis(Dt.Rows[curRow]["SID"].ToString(),PID, Dt.Rows[curRow]["HN"].ToString());
            ds.Show();
            this.Close();
        }
    }
}
