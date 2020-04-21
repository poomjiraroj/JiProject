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
    public partial class OPDpatient : Form
    {
        SqlConnection Conn;
        SqlCommand cmd;
        SqlDataAdapter Da;
        DataSet Ds;
        DataTable Dt;

        String PID;

        public OPDpatient(String PID)
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
            String SQL = "Select Diagnosis.OPDID, Diagnosis.Time, PatientData.PatientFirstname + ' ' + PatientData.PatientLastname As Patient, ICD10.[ICD10-ID] + '  ' + ICD10.[ICD10-Name] As ICD10CodeMap ";
            SQL += "From Diagnosis Inner Join PatientData On Diagnosis.HN = PatientData.HN ";
            SQL += "Inner Join ICD10 On Diagnosis.ICD10 = ICD10.[ICD10-ID] ";
            SQL += "Where PID = '" + PID + "'";
            cmd = new SqlCommand(SQL, Conn);
            Da = new SqlDataAdapter(cmd);
            Ds = new DataSet();
            Dt = new DataTable();
            Da.Fill(Ds, "OPD");
            Dt = Ds.Tables["OPD"];
            gvOPDPatient.DataSource = Dt;
            gvOPDPatient.ReadOnly = true;
            gvOPDPatient.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvOPDPatient.Columns[0].FillWeight = 25;
            gvOPDPatient.Columns[1].FillWeight = 45;
            gvOPDPatient.Columns[2].FillWeight = 50;
            Conn.Close();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
