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
    public partial class Physician : Form
    {
        SqlConnection Conn;
        SqlCommand cmd;
        SqlDataReader Reader;

        String PID;
        public Physician(String PID)
        {
            InitializeComponent();
            this.PID = PID;
            String SQL = "Data Source=JICOMPUTER;Initial Catalog=Tricus_Data;Integrated Security=True";
            Conn = new SqlConnection(SQL);
            setData();
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            setData();
        }

        public void setData()
        {
            Conn.Open();
            String SQL = "Select PhysicianData.PhyFirstname, PhysicianData.PhyLastname, Department.DeptName, PhysicianData.PID ";
            SQL += "From PhysicianData Inner Join Department On PhysicianData.DeptID = Department.DeptID ";
            SQL += "Where PID = '" + PID + "' ";
            cmd = new SqlCommand(SQL, Conn);
            try
            {
                Reader = cmd.ExecuteReader();
                Reader.Read();

                lbPhysician.Text = Reader["PhyFirstname"].ToString() + " " + Reader["PhyLastname"].ToString();
                lbDept.Text = Reader["DeptName"].ToString();
            }
            catch (Exception ex)
            {

            }
            Conn.Close();
            DateTime now = DateTime.Now;
            lbDate.Text = now.ToString("dd-MM-yyyy hh:mm:ss");

            setBtn();
        }

        public void setBtn()
        {
            Conn.Open();
            String preOPDSQL = "Select Count (SID) As cntPOPD from sentPhysician where PID = '" + PID + "' and Status = 'P' ";
            cmd = new SqlCommand(preOPDSQL, Conn);
            Reader = cmd.ExecuteReader();
            Reader.Read();
            try
            {
                btnPreOPD.Text = "PRE-OPD Case " + Reader["cntPOPD"].ToString();
                if (Reader["cntPOPD"].ToString() == "0")
                {
                    btnPreOPD.Enabled = false;
                }
            }
            catch (Exception ex)
            {

            }

            Conn.Close();

            Conn.Open();
            String OPDSQL = "Select Count (SID) As cntOPD from sentPhysician where PID = '" + PID + "' and Status = 'O' ";
            cmd = new SqlCommand(OPDSQL, Conn);
            Reader = cmd.ExecuteReader();
            Reader.Read();
            try
            {
                btnOPD.Text = "OPD Case " + Reader["cntOPD"].ToString();
                if (Reader["cntOPD"].ToString() == "0")
                {
                    btnOPD.Enabled = false;
                }
            }
            catch (Exception ex)
            {

            }

            Conn.Close();

            Conn.Open();
            String IPDSQL = "Select Count (SID) As cntIPD from sentPhysician where PID = '" + PID + "' and Status = 'I' ";
            cmd = new SqlCommand(IPDSQL, Conn);
            Reader = cmd.ExecuteReader();
            Reader.Read();
            try
            {
                btnIPD.Text = "IPD Case " + Reader["cntIPD"].ToString();
                if(Reader["cntIPD"].ToString()=="0")
                {
                    btnIPD.Enabled = false;
                }
            }
            catch (Exception ex)
            {

            }

            Conn.Close();
        }

        private void btnPreOPD_Click(object sender, EventArgs e)
        {
            PreOPD po = new PreOPD(PID);
            po.Show();
        }

        private void btnIPD_Click(object sender, EventArgs e)
        {
            IPDData IPD = new IPDData(PID);
            IPD.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {

        }

        private void btnOPD_Click(object sender, EventArgs e)
        {
            OPDpatient OPD = new OPDpatient(PID);
            OPD.Show();
        }

        private void panelReport_Click(object sender, EventArgs e)
        {
            IPDreport IPDre = new IPDreport(PID);
            IPDre.Show();
        }
    }
}
