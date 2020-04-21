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
    public partial class PatientInfo : Form
    {
        SqlConnection Conn;
        SqlConnection ConnOnline;
        SqlCommand cmd;
        SqlDataReader Reader;

        Patient pt = new Patient();
        int bioStatus = 0;

        public PatientInfo()
        {
            InitializeComponent();
            String strConn = "Data Source=JICOMPUTER;Initial Catalog=Tricus_Data;Integrated Security=True";
            Conn = new SqlConnection(strConn);

            String strConnOnline = "Data Source=jirarojserver.database.windows.net;Initial Catalog=TricusDataOnline;Persist Security Info=True;User ID=poom_jiraroj;Password=Beijing2008";
            ConnOnline = new SqlConnection(strConnOnline);
        }
        public void getData(String HN)
        {
            lbHN.Text = HN;
            setData();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
            pt.Show();
        }
        public void setData()
        {
            txtCID.Enabled = false;
            txtFirstname.Enabled = false;
            txtLastname.Enabled = false;
            cbGender.Enabled = false;
            dtDOB.Enabled = false;
            txtMobile.Enabled = false;
            txtAddress.Enabled = false;

            txtRela.Enabled = false;
            txtRFirstname.Enabled = false;
            txtRLastname.Enabled = false;
            cbRGender.Enabled = false;
            txtRMobile.Enabled = false;

            btnSubmit.Enabled = false;

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
                cbGender.Text = Reader["Gender"].ToString();
                dtDOB.Text = Reader["DOB"].ToString();
                txtMobile.Text = Reader["Mobile"].ToString();
                txtAddress.Text = Reader["Address"].ToString();
            }
            catch(Exception ex)
            {

            }
            Conn.Close();

            Conn.Open();
            String RSQL = "Select * From RelativePatient Where HN = '" + lbHN.Text + "'";
            cmd = new SqlCommand(RSQL, Conn);
            Reader = cmd.ExecuteReader();
            Reader.Read();
            try
            {
                txtRela.Text = Reader["Relation"].ToString();
                txtRFirstname.Text = Reader["RFirstname"].ToString();
                txtRLastname.Text = Reader["RLastname"].ToString();
                cbRGender.Text = Reader["Gender"].ToString();
                txtRMobile.Text = Reader["Mobile"].ToString();
            }
            catch(Exception ex)
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
                btnBio.Text = "Edit";
                btnBioSubmit.Visible = true;
                btnBioSubmit.Enabled = false;
                btnSend.Enabled = true;
            }
            catch (Exception ex)
            {
                btnBioSubmit.Visible = false;
                btnBio.Text = "Submit";
                bioStatus = 1;
                btnSend.Enabled = false;
            }
            Conn.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            btnSubmit.Enabled = true;
            btnEdit.Enabled = false;
            txtCID.Enabled = true;
            txtFirstname.Enabled = true;
            txtLastname.Enabled = true;
            cbGender.Enabled = true;
            dtDOB.Enabled = true;
            txtMobile.Enabled = true;
            txtAddress.Enabled = true;

            txtRela.Enabled = true;
            txtRFirstname.Enabled = true;
            txtRLastname.Enabled = true;
            cbRGender.Enabled = true;
            txtRMobile.Enabled = true;
        }

        private void btnBio_Click(object sender, EventArgs e)
        {
            if (bioStatus == 1)
            {
                Conn.Open();
                String SQL = "Insert into VitalSign (HN,BW,Ht,T,P,SP,DP)";
                SQL += "Values ('" + lbHN.Text + "'," + txtBW.Text + "," + txtHt.Text + "," + txtTemp.Text + "," + txtP.Text + "," + txtSP.Text + "," + txtDP.Text + ")";
                cmd = new SqlCommand(SQL, Conn);
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("VitalSign has Accept");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please insert correct data or Complete all field");
                }
                Conn.Close();

                ConnOnline.Open();
                String SQLOnline = "Insert into VitalSign (HN,BW,Ht,T,P,SP,DP)";
                SQLOnline += "Values ('" + lbHN.Text + "'," + txtBW.Text + "," + txtHt.Text + "," + txtTemp.Text + "," + txtP.Text + "," + txtSP.Text + "," + txtDP.Text + ")";
                cmd = new SqlCommand(SQLOnline, ConnOnline);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch(Exception ex)
                {

                }
                ConnOnline.Close();
                setBioData();
            }
            else
            {
                btnBio.Enabled = false;
                txtBW.Enabled = true;
                txtHt.Enabled = true;
                txtTemp.Enabled = true;
                txtP.Enabled = true;
                txtSP.Enabled = true;
                txtDP.Enabled = true;
                btnBioSubmit.Enabled = true;
            }
        }

        private void btnBioSubmit_Click(object sender, EventArgs e)
        {
            btnBio.Enabled = true;
            Conn.Open();
            String SQL = "Update VitalSign ";
            SQL += "Set BW = " + txtBW.Text + ", Ht = " + txtHt.Text + ", T = " + txtTemp.Text + ", P = " + txtP.Text + ", SP = " + txtSP.Text + ", DP = " + txtDP.Text + " ";
            SQL += "Where HN = '" + lbHN.Text + "'";
            cmd = new SqlCommand(SQL, Conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("VitalSign has updated");
            }
            catch
            {
                MessageBox.Show("Please insert correct data or Complete all field");
            }
            Conn.Close();

            ConnOnline.Open();
            String SQLOnline = "Update VitalSign ";
            SQLOnline += "Set BW = " + txtBW.Text + ", Ht = " + txtHt.Text + ", T = " + txtTemp.Text + ", P = " + txtP.Text + ", SP = " + txtSP.Text + ", DP = " + txtDP.Text + " ";
            SQLOnline += "Where HN = '" + lbHN.Text + "'";
            cmd = new SqlCommand(SQLOnline, ConnOnline);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {

            }
            ConnOnline.Close();
            setBioData();
        }

        private void txtCID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Conn.Open();
            String SQL = "Update PatientData ";
            SQL += "Set CID = '" + txtCID.Text + " ', PatientFirstname = '" + txtFirstname.Text + "', PatientLastname = '" + txtLastname.Text + "', Gender = '" + cbGender.Text + "', DOB = '" + dtDOB.Text + "', Mobile = '" + txtMobile.Text + "', Address = '" + txtAddress.Text + "' ";
            SQL += "Where HN = '" + lbHN.Text + "' ";
            cmd = new SqlCommand(SQL, Conn);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please insert correct data or Complete all in Patient field");
            }
            Conn.Close();

            ConnOnline.Open();
            String SQLOnline = "Update PatientData ";
            SQLOnline += "Set CID = '" + txtCID.Text + " ', PatientFirstname = '" + txtFirstname.Text + "', PatientLastname = '" + txtLastname.Text + "', Gender = '" + cbGender.Text + "', DOB = '" + dtDOB.Text + "', Mobile = '" + txtMobile.Text + "', Address = '" + txtAddress.Text + "' ";
            SQLOnline += "Where HN = '" + lbHN.Text + "' ";
            cmd = new SqlCommand(SQLOnline, ConnOnline);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            ConnOnline.Close();

            Conn.Open();
            String RSQL = "Update RelativePatient ";
            RSQL += "Set RFirstname = '" + txtRFirstname.Text + "', RLastname = '" + txtRLastname.Text + "', Gender = '" + cbRGender.Text + "', Mobile = '" + txtRMobile.Text + "', Relation = '" + txtRela.Text + "' Where HN = '"+lbHN.Text+"'";
            cmd = new SqlCommand(RSQL, Conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Patient data has updated");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please insert correct data or Complete all in Relative field");
            }
            Conn.Close();

            ConnOnline.Open();
            String RSQLOnline = "Update RelativePatient ";
            RSQLOnline += "Set RFirstname = '" + txtRFirstname.Text + "', RLastname = '" + txtRLastname.Text + "', Gender = '" + cbRGender.Text + "', Mobile = '" + txtRMobile.Text + "', Relation = '" + txtRela.Text + "' Where HN = '" + lbHN.Text + "'";
            cmd = new SqlCommand(RSQLOnline, ConnOnline);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

            }
            ConnOnline.Close();
            setData();
        }

        private void btnOPD_Click(object sender, EventArgs e)
        {
            SendData sd = new SendData();
            sd.getData(lbHN.Text);
            sd.Show();
        }
    }
}
