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
    public partial class Diagnosis : Form
    {
        SqlConnection Conn;
        SqlConnection ConnOnline;
        SqlCommand cmd;
        SqlDataReader Reader;
        SqlDataAdapter Da;
        DataSet Ds;
        DataTable Dt;

        Physician phy;

        String SID;
        String PID;
        String HN;
        String ICD10;
        String PTType;

        DateTime timeNow = DateTime.Now;
        String Time;

        public Diagnosis(String SID,String PID,String HN)
        {
            this.SID = SID;
            this.PID = PID;
            this.HN = HN;
            InitializeComponent();
            String strConn = "Data Source=JICOMPUTER;Initial Catalog=Tricus_Data;Integrated Security=True";
            Conn = new SqlConnection(strConn);

            String strConnOnline = "Data Source=jirarojserver.database.windows.net;Initial Catalog=TricusDataOnline;Persist Security Info=True;User ID=poom_jiraroj;Password=Beijing2008";
            ConnOnline = new SqlConnection(strConnOnline);

            Time = timeNow.ToString("yyyy-MM-dd hh:mm:ss");
            setData();
            setPatient();
            setGVHistory();
            setType();
        }
        public void setData()
        {
            lbPID.Text = PID;
            Conn.Open();
            String SQL = "Select PhysicianData.PhyFirstname, PhysicianData.PhyLastname, Department.DeptName, PhysicianData.PID ";
            SQL += "From PhysicianData Inner Join Department On PhysicianData.DeptID = Department.DeptID ";
            SQL += "Where PID = '" + PID + "' ";
            cmd = new SqlCommand(SQL, Conn);
            Reader = cmd.ExecuteReader();
            Reader.Read();
            try
            {
                lbPhy.Text = Reader["PhyFirstname"].ToString() + " " + Reader["PhyLastname"].ToString();
                lbPhy.Text += " - Department of " + Reader["DeptName"].ToString();
            }
            catch(Exception ex)
            {

            }
            Conn.Close();
        }

        //TabPatient

        public void setPatient()
        {
            Conn.Open();
            String SQL = "Select * From PatientData Where HN = '" + HN + "' ";
            cmd = new SqlCommand(SQL, Conn);
            Reader = cmd.ExecuteReader();
            Reader.Read();
            try
            {
                lbHN.Text = HN;
                lbCID.Text = Reader["CID"].ToString();
                txtFirstname.Text = Reader["PatientFirstname"].ToString();
                txtLastname.Text = Reader["PatientLastname"].ToString();
                txtGender.Text = Reader["Gender"].ToString();
                dtDOB.Text = Reader["DOB"].ToString();
                txtMobile.Text = Reader["Mobile"].ToString();
                txtAddress.Text = Reader["Address"].ToString();
            }
            catch(Exception ex)
            {

            }
            Conn.Close();

            Conn.Open();
            String RSQL = "Select * From RelativePatient Where HN = '" + HN + "'";
            cmd = new SqlCommand(RSQL, Conn);
            Reader = cmd.ExecuteReader();
            Reader.Read();
            try
            {
                txtRFirstname.Text = Reader["RFirstname"].ToString();
                txtRLastname.Text = Reader["RLastname"].ToString();
                txtRGender.Text = Reader["Gender"].ToString();
                txtRMobile.Text = Reader["Mobile"].ToString();
                txtRRelation.Text = Reader["Relation"].ToString();
            }
            catch (Exception ex)
            {

            }
            Conn.Close();

            Conn.Open();
            String VSQL = "Select * From VitalSign Where HN = '" + HN + "' ";
            cmd = new SqlCommand(VSQL, Conn);
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
            }
            catch(Exception ex)
            {

            }
            Conn.Close();

            Conn.Open();
            String DiagSQL = "Select Diagnosis From sentPhysician Where SID = '" + SID + "' ";
            cmd = new SqlCommand(DiagSQL, Conn);
            Reader = cmd.ExecuteReader();
            Reader.Read();
            try
            {
                txtDiag.Text = Reader["Diagnosis"].ToString();
            }
            catch(Exception ex)
            {

            }
            Conn.Close();
        }

        public void setGVHistory()
        {
            Conn.Open();
            String SQL = "Select Diagnosis.Time,ICD10.[ICD10-ID] + ' ' + ICD10.[ICD10-Name] As ICD10 ";
            SQL += ", PatientData.PatientFirstname + ' ' + PatientData.PatientLastname As Patient ";
            SQL += ", PhysicianData.PhyFirstname + ' ' + PhysicianData.PhyLastname As Physician ";
            SQL += ", Department.DeptID + '  ' + Department.DeptName As Department ";
            SQL += " From Diagnosis Inner Join ";
            SQL += " PatientData ON Diagnosis.HN = PatientData.HN Inner Join PhysicianData ON Diagnosis.PID = PhysicianData.PID Inner Join ";
            SQL += " Department ON PhysicianData.DeptID = Department.DeptID Inner Join ICD10 ON Diagnosis.[ICD10-ID] = ICD10.[ICD10-ID] ";
            SQL += " Where PatientData.HN = '" + HN + "' ";
            cmd = new SqlCommand(SQL, Conn);
            Da = new SqlDataAdapter(cmd);
            Ds = new DataSet();
            Dt = new DataTable();
            Da.Fill(Ds, "Patient");
            Dt = Ds.Tables["Patient"];
            gvHisOPD.DataSource = Dt;
            gvHisOPD.ReadOnly = true;
            gvHisOPD.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvHisOPD.Columns[0].FillWeight = 50;
            gvHisOPD.Columns[2].FillWeight = 60;
            gvHisOPD.Columns[3].FillWeight = 60;
            gvHisOPD.Columns[4].FillWeight = 90;
            Conn.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //TabDiagnosis

        public void QueryOPD()
        {
            Conn.Open();
            String SQL = "Select Diagnosis.SID, Diagnosis.Time, ICD10.[ICD10-ID] +'  '+ ICD10.[ICD10-Name] As ICD10 ";
            SQL += "From Diagnosis Inner Join ICD10 ON Diagnosis.[ICD10-ID] = ICD10.[ICD10-ID] ";
            SQL += "Where SID = '" + SID + "'";
            cmd = new SqlCommand(SQL, Conn);
            Da = new SqlDataAdapter(cmd);
            Ds = new DataSet();
            Dt = new DataTable();
            Da.Fill(Ds, "OPD");
            Dt = Ds.Tables["OPD"];
            gvOPD.DataSource = Dt;
            gvOPD.ReadOnly = true;
            gvOPD.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gvOPD.Columns[0].FillWeight = 15;
            gvOPD.Columns[1].FillWeight = 30;
            Conn.Close();
        }

        private void btnICD10_Click(object sender, EventArgs e)
        {
            ICD10Data I10D = new ICD10Data();
            I10D.ShowDialog();
            if(I10D.IsSelect)
            {
                try
                {
                    ICD10 = I10D.ICD10;
                    txtICD10.Text = ICD10 + " - " + I10D.strICD10;
                    btnAdd.Enabled = true;
                }
                catch (Exception ex)
                {

                }
            }
            else
            {
                ICD10 = "";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Conn.Open();
            String OPDID;
            try
            {
                String strLastValue = "Select Top 1 OPDID From Diagnosis Order by OPDID Desc ";
                SqlCommand lastValues = new SqlCommand(strLastValue, Conn);
                String strlastV = (String)lastValues.ExecuteScalar();
                int intlastV = Convert.ToInt16(strlastV.Substring(3));
                int curValues = intlastV + 1;
                OPDID = "OPD" + curValues.ToString();
            }
            catch
            {
                OPDID = "OPD1111";
            }
            Conn.Close();

            Conn.Open();

            String SQL = "Insert into Diagnosis(OPDID,SID,Time,HN,[ICD10-ID],PID,Comment) ";
            SQL += "Values('" + OPDID + "','" + SID + "','" + Time + "','" + HN + "','" + ICD10 + "','" + PID + "','" + txtComment.Text + "')";
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

            ConnOnline.Open();
            String SQLOnline = "Insert into Diagnosis(OPDID,SID,Time,HN,[ICD10-ID],PID) ";
            SQLOnline += "Values('" + OPDID + "','" + SID + "','" + Time + "','" + HN + "','" + ICD10 + "','" + PID + "' )";
            cmd = new SqlCommand(SQLOnline, ConnOnline);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(SQLOnline);
            }
            ConnOnline.Close();

            QueryOPD();
        }

        private void cbPTType_SelectedIndexChanged(object sender, EventArgs e)
        {
            PTType = cbPTType.Text;
            setType();
        }

        public void setType()
        {
            btnOPDSave.Enabled = false;
            gbIPD.Enabled = false;

            if(PTType=="OPD")
            {
                btnOPDSave.Enabled = true;
                gbIPD.Enabled = false;
            }
            if(PTType=="IPD")
            {
                btnOPDSave.Enabled = false;
                gbIPD.Enabled = true;
                setcbWard();
            }
        }

        public void setcbWard()
        {
            Conn.Open();
            String SQL = "Select WID, WID + ' ' + Wardname As Ward From Ward ";
            Da = new SqlDataAdapter(SQL, Conn);
            Ds = new DataSet();
            Da.Fill(Ds, "Ward");
            cbWard.DisplayMember = "Ward";
            cbWard.ValueMember = "WID";
            cbWard.DataSource = Ds.Tables["Ward"];
            Conn.Close();
        }

        private void btnOPDSave_Click(object sender, EventArgs e)
        {
            Conn.Open();
            String SQL = "Update sentPhysician ";
            SQL += "Set Status = 'O' Where SID = '" + SID + "'";
            cmd = new SqlCommand(SQL, Conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has Saved");
            }
            catch
            {
                MessageBox.Show(SQL);
            }
            Conn.Close();
        }

        private void cbWard_SelectedIndexChanged(object sender, EventArgs e)
        {
            String SQL = "Select BID From Bed ";
            SQL += "Where WID = '" + cbWard.SelectedValue.ToString() +"' and Status = 0 ";
            Da = new SqlDataAdapter(SQL, Conn);
            Ds = new DataSet();
            Da.Fill(Ds, "Bed");
            cbBed.DisplayMember = "BID";
            cbBed.ValueMember = "BID";
            cbBed.DataSource = Ds.Tables["Bed"];
            Conn.Close();
        }

        private void btnIPDSave_Click(object sender, EventArgs e)
        {
            btnIPDSave.Enabled = false;
            Conn.Open();
            String SQL = "Update sentPhysician ";
            SQL += "Set Status = 'I' Where SID = '" + SID + "'";
            cmd = new SqlCommand(SQL, Conn);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data has Saved");
            }
            catch
            {
                MessageBox.Show(SQL);
            }
            Conn.Close();
            updateBed();
        }

        public void updateBed()
        {
            Conn.Open();
            String SQL = "Update Bed ";
            SQL += "Set Status = 1 Where BID = '" + cbBed.SelectedValue.ToString() + "' ";
            cmd = new SqlCommand(SQL, Conn);
            cmd.ExecuteNonQuery();
            Conn.Close();

            ConnOnline.Open();
            String SQLOnline = "Update Bed ";
            SQLOnline += "Set Status = 1 Where BID = '" + cbBed.SelectedValue.ToString() + "' ";
            cmd = new SqlCommand(SQLOnline, ConnOnline);
            cmd.ExecuteNonQuery();
            ConnOnline.Close();

            setAccept();
        }
        public void setAccept()
        {
            Conn.Open();
            String SQL = "Insert Into Accept(Time,PID,HN,BID,SID) ";
            SQL += "Values('" + Time + "','" + PID + "','" + HN + "','" + cbBed.SelectedValue.ToString() + "','" + SID + "')";
            cmd = new SqlCommand(SQL, Conn);
            cmd.ExecuteNonQuery();
            Conn.Close();

            ConnOnline.Open();
            String SQLOnline = "Insert Into Accept(Time,PID,HN,BID,SID) ";
            SQLOnline += "Values('" + Time + "','" + PID + "','" + HN + "','" + cbBed.SelectedValue.ToString() + "','" + SID + "')";
            cmd = new SqlCommand(SQLOnline, ConnOnline);
            cmd.ExecuteNonQuery();
            ConnOnline.Close();
            this.Close();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            Conn.Open();
            String SQL = "Delete From Diagnosis ";
            SQL += "Where SID = '" + SID + "'";
            cmd = new SqlCommand(SQL, Conn);
            cmd.ExecuteNonQuery();
            Conn.Close();

            ConnOnline.Open();
            String SQLOnline = "Delete From Diagnosis ";
            SQLOnline += "Where SID = '" + SID + "'";
            cmd = new SqlCommand(SQLOnline, ConnOnline);
            cmd.ExecuteNonQuery();
            ConnOnline.Close();
            QueryOPD();
        }
    }
}