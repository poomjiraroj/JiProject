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
    public partial class ReportPatient : Form
    {
        SqlConnection Conn;
        SqlCommand cmd;
        SqlDataReader Reader;
        SqlDataAdapter Da;
        DataSet Ds;
        DataTable Dt;


        String HN, SID, BID;

        public ReportPatient(String HN,String SID,String BID)
        {
            InitializeComponent();
            String strConn = "Data Source=JICOMPUTER;Initial Catalog=Tricus_Data;Integrated Security=True";
            Conn = new SqlConnection(strConn);
            this.HN = HN;
            this.SID = SID;
            this.BID = BID;
            setData();
            setBPM();
            setGV();
        }

        public void setData()
        {
            Conn.Open();
            String SQL = "Select PatientData.PatientFirstname + ' ' + PatientData.PatientLastname As Patient, Bed.BID + ' - ' + Ward.Wardname As Ward, Diagnosis.[ICD10-ID]";
            SQL += "From Accept Inner Join PatientData ON Accept.HN = PatientData.HN Inner Join ";
            SQL += "Diagnosis ON PatientData.HN = Diagnosis.HN Inner Join ";
            SQL += "Bed ON Accept.BID = Bed.BID Inner Join ";
            SQL += "Ward ON Bed.WID = Ward.WID Inner Join ";
            SQL += "sentPhysician ON Accept.SID = sentPhysician.SID And PatientData.HN = sentPhysician.HN And Diagnosis.SID = sentPhysician.SID ";
            SQL += "Where PatientData.HN = '" + HN + "' And Accept.SID =  '" + SID + "' ";
            cmd = new SqlCommand(SQL, Conn);
            Reader = cmd.ExecuteReader();
            Reader.Read();

            lbPatient.Text = Reader["Patient"].ToString();
            lbDiagnosis.Text = Reader["ICD10-ID"].ToString();
            lbWard.Text = Reader["Ward"].ToString();

            Conn.Close();
        }

        public void setBPM()
        {
            Conn.Open();
            String SQL = "Select MIN(BPM) As Low,AVG(BPM) As Avarage, MAX(BPM) As High From PulseHR ";
            SQL += "Where (HN = '" + HN + "' and SID = '" + SID + "') And BPM!=0 ";
            cmd = new SqlCommand(SQL, Conn);
            try
            {
                Reader = cmd.ExecuteReader();
                Reader.Read();

                lbHighBPM.Text = Reader["High"].ToString();
                lbLowBPM.Text = Reader["Low"].ToString();
                lbAVGBPM.Text = Reader["Avarage"].ToString();
            }
            catch(Exception ex)
            {
                lbHighBPM.Text = "NULL";
                lbLowBPM.Text = "NULL";
                lbAVGBPM.Text = "NULL";
            }
            Conn.Close();
        }

        public void setGV()
        {
            Conn.Open();
            String SQL = "Select Time, BPM From PulseHR ";
            SQL += "Where HN = '" + HN + "' and SID = '" + SID + "'";
            cmd = new SqlCommand(SQL, Conn);
            Da = new SqlDataAdapter(cmd);
            Ds = new DataSet();
            Dt = new DataTable();
            Da.Fill(Ds, "PulseHR");
            Dt = Ds.Tables["PulseHR"];
            gvHR.DataSource = Dt;
            gvHR.ReadOnly = true;
            gvHR.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvHR.Columns[0].FillWeight = 30;
            gvHR.Columns[1].FillWeight = 10;
            Conn.Close();

            Conn.Open();
            String SQLhis = "Select Accept.Time, dbo.ICD10.[ICD10-ID] + ' ' + dbo.ICD10.[ICD10-Name] As ICD10, Accept.BID ";
            SQLhis += "From  Diagnosis Inner Join ";
            SQLhis += "ICD10 On Diagnosis.[ICD10-ID] = ICD10.[ICD10-ID] Inner Join ";
            SQLhis += "sentPhysician On Diagnosis.SID = sentPhysician.SID Inner Join ";
            SQLhis += "Accept On sentPhysician.SID = Accept.SID ";
            SQLhis += "Where Accept.HN = '" + HN + "' ";
            cmd = new SqlCommand(SQLhis, Conn);
            Da = new SqlDataAdapter(cmd);
            Ds = new DataSet();
            Dt = new DataTable();
            Da.Fill(Ds, "History");
            Dt = Ds.Tables["History"];
            gvHistory.DataSource = Dt;
            gvHistory.ReadOnly = true;
            gvHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvHistory.Columns[0].FillWeight = 10;
            gvHistory.Columns[1].FillWeight = 50;
            gvHistory.Columns[2].FillWeight = 10;
            Conn.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
