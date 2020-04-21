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
    public partial class Patient : Form
    {
        SqlConnection Conn;
        SqlCommand cmd;
        SqlDataAdapter Da;
        DataSet Ds;
        DataTable Dt;

        public Patient()
        {
            InitializeComponent();
            String strConn = "Data Source=JICOMPUTER;Initial Catalog=Tricus_Data;Integrated Security=True";
            Conn = new SqlConnection(strConn);
            Query();
        }

        private void Patient_Load(object sender, EventArgs e)
        {

        }

        public void Query()
        {
            Conn.Open();
            String SQL = "Select HN, CID, PatientFirstname As Firstname, PatientLastname As Lastname, Gender, DOB ,Mobile from PatientData ";
            cmd = new SqlCommand(SQL, Conn);
            Da = new SqlDataAdapter(cmd);
            Ds = new DataSet();
            Dt = new DataTable();
            Da.Fill(Ds, "Patient");
            Dt = Ds.Tables["Patient"];
            PatientGridview.DataSource = Dt;
            PatientGridview.ReadOnly = true;
            PatientGridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            PatientGridview.Columns[0].FillWeight = 40;
            PatientGridview.Columns[1].FillWeight = 50;
            PatientGridview.Columns[4].FillWeight = 30;
            PatientGridview.Columns[5].FillWeight = 40;
            PatientGridview.Columns[6].FillWeight = 50;
            Conn.Close();
        }

        private void txtSearchCID_TextChanged(object sender, EventArgs e)
        {
            txtSearchHN.Text = "";
            txtSearchFirstname.Text = "";
            txtSearchLastname.Text = "";

            Conn.Open();
            String SQL = "Select HN, CID, PatientFirstname As Firstname, PatientLastname As Lastname, Gender, DOB ,Mobile from PatientData ";
            SQL += "Where CID like '%" + txtSearchCID.Text + "%' ";
            cmd = new SqlCommand(SQL, Conn);
            Da = new SqlDataAdapter(cmd);
            Ds = new DataSet();
            Dt = new DataTable();
            Da.Fill(Ds, "Patient");
            Dt = Ds.Tables["Patient"];
            PatientGridview.DataSource = Dt;
            PatientGridview.ReadOnly = true;
            PatientGridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Conn.Close();
        }

        private void txtSearchHN_TextChanged(object sender, EventArgs e)
        {
            txtSearchCID.Text = "";
            txtSearchFirstname.Text = "";
            txtSearchLastname.Text = "";

            Conn.Open();
            String SQL = "Select HN, CID, PatientFirstname As Firstname, PatientLastname As Lastname, Gender, DOB ,Mobile from PatientData ";
            SQL += "Where HN like '%" + txtSearchHN.Text + "%' ";
            cmd = new SqlCommand(SQL, Conn);
            Da = new SqlDataAdapter(cmd);
            Ds = new DataSet();
            Dt = new DataTable();
            Da.Fill(Ds, "Patient");
            Dt = Ds.Tables["Patient"];
            PatientGridview.DataSource = Dt;
            PatientGridview.ReadOnly = true;
            PatientGridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Conn.Close();
        }

        private void txtSearchFirstname_TextChanged(object sender, EventArgs e)
        {
            txtSearchCID.Text = "";
            txtSearchHN.Text = "";
            txtSearchLastname.Text = "";

            Conn.Open();
            String SQL = "Select HN, CID, PatientFirstname As Firstname, PatientLastname As Lastname, Gender, DOB ,Mobile from PatientData ";
            SQL += "Where PatientFirstname like '%" + txtSearchFirstname.Text + "%' ";
            cmd = new SqlCommand(SQL, Conn);
            Da = new SqlDataAdapter(cmd);
            Ds = new DataSet();
            Dt = new DataTable();
            Da.Fill(Ds, "Patient");
            Dt = Ds.Tables["Patient"];
            PatientGridview.DataSource = Dt;
            PatientGridview.ReadOnly = true;
            PatientGridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Conn.Close();
        }

        private void txtSearchLastname_TextChanged(object sender, EventArgs e)
        {
            txtSearchCID.Text = "";
            txtSearchHN.Text = "";
            txtSearchFirstname.Text = "";

            Conn.Open();
            String SQL = "Select HN, CID, PatientFirstname As Firstname, PatientLastname As Lastname, Gender, DOB ,Mobile from PatientData ";
            SQL += "Where PatientLastname like '%" + txtSearchLastname.Text + "%' ";
            cmd = new SqlCommand(SQL, Conn);
            Da = new SqlDataAdapter(cmd);
            Ds = new DataSet();
            Dt = new DataTable();
            Da.Fill(Ds, "Patient");
            Dt = Ds.Tables["Patient"];
            PatientGridview.DataSource = Dt;
            PatientGridview.ReadOnly = true;
            PatientGridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            Conn.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearchCID.Text = "";
            txtSearchHN.Text = "";
            txtSearchFirstname.Text = "";
            txtSearchLastname.Text = "";
            Query();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.Close();
            addPatient ap = new addPatient();
            ap.Show();
        }

        private void PatientGridview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int curRow = PatientGridview.CurrentRow.Index;
            PatientInfo PI = new PatientInfo();
            PI.getData(Dt.Rows[curRow]["HN"].ToString());
            this.Close();
            PI.Show();
        }

        private void btnOPD_Click(object sender, EventArgs e)
        {
            LoginPhysician phy = new LoginPhysician();
            phy.Show();
            this.Close();
        }

        private void btnIPD_Click(object sender, EventArgs e)
        {
            LoginPhysician phy = new LoginPhysician();
            phy.Show();
            this.Close();
        }

        private void btnWard_Click(object sender, EventArgs e)
        {
            Ward w = new Ward();
            w.Show();
            this.Close();
        }
    }
}
