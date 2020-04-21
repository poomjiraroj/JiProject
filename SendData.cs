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
    public partial class SendData : Form
    {
        SqlConnection Conn;
        SqlConnection ConnOnline;
        SqlCommand cmd;
        SqlDataReader Reader;
        SqlDataAdapter Da;
        DataSet Ds;
        DataTable Dt;

        String SID;

        public SendData()
        {
            InitializeComponent();
            String strConn = "Data Source=JICOMPUTER;Initial Catalog=Tricus_Data;Integrated Security=True";
            Conn = new SqlConnection(strConn);

            String strConnOnline = "Data Source=jirarojserver.database.windows.net;Initial Catalog=TricusDataOnline;Persist Security Info=True;User ID=poom_jiraroj;Password=Beijing2008";
            ConnOnline = new SqlConnection(strConnOnline);

            Conn.Open();
            String strLastValue = "Select Top 1 SID From sentPhysician Order by SID Desc ";
            SqlCommand lastValues = new SqlCommand(strLastValue, Conn);
            String strlastV = (String)lastValues.ExecuteScalar();
            int intlastV = Convert.ToInt16(strlastV.Substring(3));
            int curValues = intlastV + 1;
            SID = "SID" + curValues.ToString();
            Conn.Close();
        }
        public void getData(string HN)
        {
            lbHN.Text = HN;
            setData();
        }

        public void setData()
        {
            txtCID.Enabled = false;
            txtFirstname.Enabled = false;
            txtLastname.Enabled = false;

            Conn.Open();
            String SQL = "Select * From PatientData Where HN = '" + lbHN.Text + "' ";
            cmd = new SqlCommand(SQL, Conn);
            Reader = cmd.ExecuteReader();
            Reader.Read();
            try
            {
                txtCID.Text = Reader["CID"].ToString();
                txtFirstname.Text = Reader["PatientFirstname"].ToString();
                txtLastname.Text = Reader["PatientLastname"].ToString();
            }
            catch (Exception ex)
            {

            }
            Conn.Close();
            setBioData();
        }

        public void setBioData()
        {
            Conn.Open();
            String SQL = "Select * From VitalSign Where HN = '" + lbHN.Text + "' ";
            cmd = new SqlCommand(SQL, Conn);
            Reader = cmd.ExecuteReader();
            Reader.Read();

            try
            {
                txtBW.Text = Reader["BW"].ToString();
                txtHt.Text = Reader["Ht"].ToString();
                txtTemp.Text = Reader["T"].ToString();
                txtP.Text = Reader["P"].ToString();
                txtSP.Text = Reader["SP"].ToString();
                txtDP.Text = Reader["DP"].ToString();

                txtBW.Enabled = false;
                txtHt.Enabled = false;
                txtTemp.Enabled = false;
                txtP.Enabled = false;
                txtSP.Enabled = false;
                txtDP.Enabled = false;
            }
            catch (Exception ex)
            {

            }
            Conn.Close();
            setDept();
            setDataGridView();
        }

        public void setDept()
        {
            cbPhy.Enabled = false;
            Conn.Open();
            String SQL = "Select DeptID, DeptID + ' ' + DeptName As Dept From Department ";
            Da = new SqlDataAdapter(SQL, Conn);
            Ds = new DataSet();
            Da.Fill(Ds, "Department");
            cbDept.DisplayMember = "Dept";
            cbDept.ValueMember = "DeptID";
            cbDept.DataSource = Ds.Tables["Department"];
            Conn.Close();
        }

        public void setDataGridView()
        {
            String SQL = "Select sentPhysician.SID, sentPhysician.Time, Department.DeptName As Department, PhysicianData.PhyFirstname + ' ' + PhysicianData.PhyLastname As Physician, sentPhysician.Diagnosis ";
            SQL += "From sentPhysician INNER JOIN ";
            SQL += "Department ON sentPhysician.DeptID = Department.DeptID INNER JOIN ";
            SQL += "PhysicianData ON sentPhysician.PID = PhysicianData.PID AND Department.DeptID = PhysicianData.DeptID ";
            SQL += "Where HN = '" + lbHN.Text + "' ";
            cmd = new SqlCommand(SQL, Conn);
            Da = new SqlDataAdapter(cmd);
            Ds = new DataSet();
            Dt = new DataTable();
            Da.Fill(Ds, "sentPhysician");
            Dt = Ds.Tables["sentPhysician"];
            gvHisOPD.DataSource = Dt;
            gvHisOPD.ReadOnly = true;
            gvHisOPD.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvHisOPD.Columns[0].FillWeight = 40;
            gvHisOPD.Columns[1].FillWeight = 60;
            Conn.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void cbDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbPhy.Enabled = true;
            String SQL = "Select PID, PID + '  ' + PhyFirstname + ' ' + PhyLastname As Phy From PhysicianData ";
            SQL += "Where DeptID = '" + cbDept.SelectedValue.ToString() + "' ";
            Da = new SqlDataAdapter(SQL, Conn);
            Ds = new DataSet();
            Da.Fill(Ds, "PhysicianData");
            cbPhy.DisplayMember = "Phy";
            cbPhy.ValueMember = "PID";
            cbPhy.DataSource = Ds.Tables["PhysicianData"];
            Conn.Close();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Conn.Open();

            DateTime timeNow = DateTime.Now;
            String Time = timeNow.ToString("yyyy-MM-dd hh:mm:ss");

            String SQL = "Insert into sentPhysician (SID,Time,HN,DeptID,PID,Diagnosis,Status) ";
            SQL += "Values('" + SID + "','" + Time + "','" + lbHN.Text + "','" + cbDept.SelectedValue.ToString() + "','" + cbPhy.SelectedValue.ToString() + "','" + txtDiagnosis.Text + "','P')";
            cmd = new SqlCommand(SQL, Conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("OPD Data has send");
            }
            catch (Exception ex)
            {
                MessageBox.Show(SID);
            }
            Conn.Close();

            ConnOnline.Open();
            String SQLOnline = "Insert into sentPhysician (Time,SID,HN,PID,Diagnosis) ";
            SQLOnline += "Values('" + Time + "','" + SID + "','" + lbHN.Text + "','"+cbPhy.SelectedValue.ToString()+"','" + txtDiagnosis.Text + "') "; ;
            cmd = new SqlCommand(SQLOnline, ConnOnline);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            ConnOnline.Close();
            setDataGridView();
        }
    }
}