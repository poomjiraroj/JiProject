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
    public partial class IPDmanagement : Form
    {
        SqlConnection Conn;
        SqlCommand cmd;
        SqlDataReader Reader;

        String PID;
        String HN;
        String BID;
        String SID;

        DateTime timeNow = DateTime.Now;
        String Time;

        public IPDmanagement(String PID, String HN, String BID, String SID)
        {
            InitializeComponent();
            this.PID = PID;
            this.HN = HN;
            this.BID = BID;
            this.SID = SID;

            String strConn = "Data Source=JICOMPUTER;Initial Catalog=Tricus_Data;Integrated Security=True";
            Conn = new SqlConnection(strConn);
            Time = timeNow.ToString("yyyy-MM-dd hh:mm:ss");
            setData();
        }

        public void setData()
        {
            Conn.Open();
            String SQL = "Select Bed.BID,PatientData.PatientFirstname, PatientData.PatientLastname ";
            SQL += "From Bed Inner Join Accept On Bed.BID = Accept.BID Inner Join ";
            SQL += "PatientData On Accept.HN = PatientData.HN ";
            SQL += "Where Bed.BID = '" + BID + "' ";
            cmd = new SqlCommand(SQL, Conn);
            Reader = cmd.ExecuteReader();
            Reader.Read();

            lbBID.Text = Reader["BID"].ToString() + " - " + Reader["PatientFirstname"].ToString() + " " + Reader["PatientLastname"].ToString();
            Conn.Close();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDischarge_Click(object sender, EventArgs e)
        {
            Conn.Open();
            String SQL = "Insert into Discharge(Time,PID,HN,BID,Reason) ";
            SQL += "Values ('" + Time + "','" + PID + "','" + HN + "','" + BID + "','" + cbReason.Text + "') ";
            cmd = new SqlCommand(SQL, Conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(SQL);
            }
            Conn.Close();

            Conn.Open();
            String edSQL = "Update sentPhysician ";
            edSQL += "Set Status = 'D' ";
            edSQL += "Where SID = '" + SID + "' ";
            cmd = new SqlCommand(edSQL, Conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(edSQL);
            }
            Conn.Close();

            Conn.Open();
            String edBedSQL = "Update Bed ";
            edBedSQL += "Set Status = 0 ";
            edBedSQL += "Where BID = '" + BID + "' ";
            cmd = new SqlCommand(edBedSQL, Conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient has Discharge");
            }
            catch (Exception ex)
            {
                MessageBox.Show(edBedSQL);
            }
            Conn.Close();

            setLabel();
        }

        public void setLabel()
        {
            lbTime.Visible = true;
            lbPhy.Visible = true;
            lbPatient.Visible = true;
            lbReason.Visible = true;

            Conn.Open();
            String SQL = "Select Discharge.Time, PhysicianData.PhyFirstname + ' ' + PhysicianData.PhyLastname As Phy, PatientData.PatientFirstname + ' ' + PatientData.PatientLastname As Patient, Discharge.Reason ";
            SQL += "From Discharge Inner Join PhysicianData On Discharge.PID = PhysicianData.PID ";
            SQL += "Inner Join PatientData On Discharge.HN = PatientData.HN ";
            SQL += "Where Discharge.HN = '" + HN + "' ";
            cmd = new SqlCommand(SQL, Conn);
            Reader = cmd.ExecuteReader();
            Reader.Read();

            lbTime.Text = Reader["Time"].ToString();
            lbPhy.Text = "Physician - " + Reader["Phy"].ToString();
            lbPatient.Text = "Patient - " + Reader["Patient"].ToString();
            lbReason.Text = "Reason - " + Reader["Reason"].ToString();

            Conn.Close();
        }

        private void cbReason_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnDischarge.Enabled = true;
        }
    }
}