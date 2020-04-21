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
using System.Media;
using System.IO.Ports;

namespace TricuslabSoftware
{
    public partial class DashboardPatient : Form
    {
        SqlConnection Conn;
        SqlConnection ConnOnline;
        SqlCommand cmd;
        SqlDataReader Reader;

        DateTime now = DateTime.Now;

        SoundPlayer Alert = new SoundPlayer("C:\\Users\\poomjiraroj\\OneDrive\\เอกสาร\\Tricus\\Alarm.wav");
        SoundPlayer Beep = new SoundPlayer("C:\\Users\\poom_\\OneDrive\\เอกสาร\\Tricus\\Beep.wav");

        String HN, SID, BID;
        String Port;
        int BPM;
        int HighPR, HighPRSA, LowPRSA, LowPR;

        public DashboardPatient(String HN,String SID,String BID)
        {
            InitializeComponent();
            this.HN = HN;
            this.SID = SID;
            this.BID = BID;
            String strConn = "Data Source=JICOMPUTER;Initial Catalog=Tricus_Data;Integrated Security=True";
            Conn = new SqlConnection(strConn);

            String strConnOnline = "Data Source=jirarojserver.database.windows.net;Initial Catalog=TricusDataOnline;Persist Security Info=True;User ID=poom_jiraroj;Password=Beijing2008";
            ConnOnline = new SqlConnection(strConnOnline);

            setPort();
            setRate();
            setSerial();
            setData();
        }

        public void setPort()
        {
            Conn.Open();
            String SQL = "Select Port From Bed Where BID = '" + BID + "' ";
            cmd = new SqlCommand(SQL, Conn);
            Reader = cmd.ExecuteReader();
            Reader.Read();
            Port = Reader["Port"].ToString();
            serialPort.PortName = Port;
            Conn.Close();
        }

        public void setRate()
        {
            Conn.Open();
            String SQL = "Select HighPR, HighPRSA, LowPRSA, LowPR From Bed ";
            SQL += "Where BID = '" + BID + "' ";
            cmd = new SqlCommand(SQL, Conn);
            Reader = cmd.ExecuteReader();
            Reader.Read();
            try
            {
                HighPR = Convert.ToInt16(Reader["HighPR"].ToString());
                HighPRSA = Convert.ToInt16(Reader["HighPRSA"].ToString());
                LowPRSA = Convert.ToInt16(Reader["LowPRSA"].ToString());
                LowPR = Convert.ToInt16(Reader["LowPR"].ToString());
            }
            catch(Exception ex)
            {

            }
            Conn.Close();
        }

        public void setSerial()
        {
            try
            {
                serialPort.Open();
                TimerRe.Start();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Pulse Sensor not Connect");
                this.Close();
            }
        }

        private void TimerRe_Tick(object sender, EventArgs e)
        {
            setData();
            setBPM();
        }

        public void setData()
        {
            Conn.Open();
            String SQL = "Select PatientData.PatientFirstname + ' ' + PatientData.PatientLastname As Patient, VitalSign.BW, VitalSign.Ht, VitalSign.T, VitalSign.P, VitalSign.SP, VitalSign.DP, Bed.BID + ' - ' + Ward.Wardname + ' Ward' As Ward, ";
            SQL += "PhysicianData.PhyFirstname + ' ' + PhysicianData.PhyLastname As Physician, Department.DeptName, sentPhysician.Diagnosis ";
            SQL += "From Accept Inner Join sentPhysician On Accept.SID = sentPhysician.SID Inner Join ";
            SQL += "PhysicianData On Accept.PID = PhysicianData.PID And sentPhysician.PID = PhysicianData.PID Inner Join ";
            SQL += "PatientData On dbo.Accept.HN = PatientData.HN And sentPhysician.HN = PatientData.HN Inner Join ";
            SQL += "VitalSign On PatientData.HN = VitalSign.HN Inner Join ";
            SQL += "Bed On Accept.BID = Bed.BID Inner Join ";
            SQL += "Ward On dbo.Bed.WID = Ward.WID Inner Join ";
            SQL += "Department On sentPhysician.DeptID = Department.DeptID And PhysicianData.DeptID = Department.DeptID ";
            SQL += "Where PatientData.HN = '" + HN + "' and sentPhysician.SID = '" + SID + "' ";
            cmd = new SqlCommand(SQL, Conn);
            Reader = cmd.ExecuteReader();
            Reader.Read();

            lbPatient.Text = Reader["Patient"].ToString();
            lbDept.Text = Reader["DeptName"].ToString();
            lbBW.Text = Reader["Bw"].ToString();
            lbHt.Text = Reader["Ht"].ToString();
            lbTemp.Text = Reader["T"].ToString();
            lbBP.Text = Reader["SP"].ToString() + "/" + Reader["DP"].ToString();
            lbDiag.Text = Reader["Diagnosis"].ToString();
            lbPhy.Text = Reader["Physician"].ToString();
            lbBID.Text = Reader["Ward"].ToString();
            Conn.Close();
            lbTime.Text = now.ToString("dd-MM-yyyy hh:mm:ss");
        }

        public void setBPM()
        {
            lbBPM.Text = BPM.ToString();
 
            if(BPM>HighPR)
            {
                lbStatus.Text = "HIGH";
                lbStatus.ForeColor = System.Drawing.Color.Red;
                lbBPM.ForeColor = System.Drawing.Color.Red;
                Alert.Play();
            }
            else if(BPM<LowPR)
            {
                lbStatus.Text = "LOW";
                lbStatus.ForeColor = System.Drawing.Color.Red;
                lbBPM.ForeColor = System.Drawing.Color.Red;
                Alert.Play();
            }
            else if(BPM>=HighPRSA || BPM <= LowPRSA)
            {
                lbStatus.Text = "STAYALERT";
                lbStatus.ForeColor = System.Drawing.Color.Orange;
                lbBPM.ForeColor = System.Drawing.Color.Orange;
                Alert.Stop();
            }
            else
            {
                lbStatus.Text = "NORMAL";
                lbStatus.ForeColor = Color.FromArgb(69, 253, 55);
                lbBPM.ForeColor = Color.FromArgb(69, 253, 55);
                Alert.Stop();
            }
            Conn.Open();
            String Time = now.ToString("yyyy-MM-dd hh:mm:ss");
            String SQL = "Insert into PulseHR(Time,HN,SID,BPM) ";
            SQL += "Values('" + Time + "','" + HN + "','" + SID + "'," + BPM + ") ";
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
            String SQLOnline = "Insert into PulseHR(Time,HN,SID,BPM) ";
            SQLOnline += "Values('" + Time + "','" + HN + "','" + SID + "'," + BPM + ") ";
            cmd = new SqlCommand(SQL, ConnOnline);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            ConnOnline.Close();
        }

        private void lbSetting_Click(object sender, EventArgs e)
        {
            BPMsetting BPMS = new BPMsetting(BID);
            BPMS.ShowDialog();
            if(BPMS.IsSelect)
            {
                setRate();
            }
        }

        private void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                BPM = Convert.ToInt16(serialPort.ReadLine());
            }
            catch(Exception ex)
            {

            }
        }

        private void lbExit_Click(object sender, EventArgs e)
        {
            Alert.Stop();
            Beep.Stop();
            serialPort.Close();
            this.Close();
        }
    }
}
