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
    public partial class Ward : Form
    {
        SqlConnection Conn;
        SqlCommand cmd;
        SqlDataReader Reader;

        int ICU, OR, ER, IPDm, IPDf, PD, DR;

        public Ward()
        {
            InitializeComponent();
            String strConn = "Data Source=JICOMPUTER;Initial Catalog=Tricus_Data;Integrated Security=True";
            Conn = new SqlConnection(strConn);
            setData();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            setData();
        }

        public void setData()
        {
            //All Patient
            Conn.Open();
            String cntSQL = "Select Count(BID) As Cnt From Bed Where Status = 1 ";
            cmd = new SqlCommand(cntSQL, Conn);
            Reader = cmd.ExecuteReader();
            Reader.Read();
            lbPatient.Text = Reader["Cnt"].ToString();
            Conn.Close();

            //ICU
            Conn.Open();
            String cntICU = "Select Count(BID) As Cnt From Bed Where WID = 'W1113' and Status = 1 ";
            cmd = new SqlCommand(cntICU, Conn);
            Reader = cmd.ExecuteReader();
            Reader.Read();
            ICU = Convert.ToInt16(Reader["Cnt"].ToString());
            lbICU.Text = ICU + "/8";
            Conn.Close();

            //OR
            Conn.Open();
            String cntOR = "Select Count(BID) As Cnt From Bed Where WID = 'W1112' and Status = 1 ";
            cmd = new SqlCommand(cntOR, Conn);
            Reader = cmd.ExecuteReader();
            Reader.Read();
            OR = Convert.ToInt16(Reader["Cnt"].ToString());
            lbOR.Text = OR + "/4";
            Conn.Close();

            //ER
            Conn.Open();
            String cntER = "Select Count(BID) As Cnt From Bed Where WID = 'W1111' and Status = 1 ";
            cmd = new SqlCommand(cntER, Conn);
            Reader = cmd.ExecuteReader();
            Reader.Read();
            ER = Convert.ToInt16(Reader["Cnt"].ToString());
            lbER.Text = ER + "/12";
            Conn.Close();

            //IPD male
            Conn.Open();
            String cntIPDm = "Select Count(BID) As Cnt From Bed Where BID Between 'IPDm11' and 'IPDm28' and Status = 1 ";
            cmd = new SqlCommand(cntIPDm, Conn);
            Reader = cmd.ExecuteReader();
            Reader.Read();
            IPDm = Convert.ToInt16(Reader["Cnt"].ToString());
            lbIPDm.Text = IPDm + "/12";
            Conn.Close();

            //IPD female
            Conn.Open();
            String cntIPDf = "Select Count(BID) As Cnt From Bed Where BID Between 'IPDf11' and 'IPDf28' and Status = 1 ";
            cmd = new SqlCommand(cntIPDf, Conn);
            Reader = cmd.ExecuteReader();
            Reader.Read();
            IPDf = Convert.ToInt16(Reader["Cnt"].ToString());
            lbIPDf.Text = IPDf + "/12";
            Conn.Close();

            //Pediatric
            Conn.Open();
            String cntPD = "Select Count(BID) As Cnt From Bed Where WID = 'W1115' and Status = 1 ";
            cmd = new SqlCommand(cntPD, Conn);
            Reader = cmd.ExecuteReader();
            Reader.Read();
            PD = Convert.ToInt16(Reader["Cnt"].ToString());
            lbPD.Text = PD + "/6";
            Conn.Close();

            //DR
            Conn.Open();
            String cntDR = "Select Count(BID) As Cnt From Bed Where WID = 'W1114' and Status = 1 ";
            cmd = new SqlCommand(cntDR, Conn);
            Reader = cmd.ExecuteReader();
            Reader.Read();
            DR = Convert.ToInt16(Reader["Cnt"].ToString());
            lbDR.Text = DR + "/2";
            Conn.Close();
        }

        //Button to Ward
        private void btnER_Click(object sender, EventArgs e)
        {
            MonitorDashboard mtDash = new MonitorDashboard("W1111");
            mtDash.Show();
        }

        private void btnOR_Click(object sender, EventArgs e)
        {
            MonitorDashboard mtDash = new MonitorDashboard("W1112");
            mtDash.Show();
        }

        private void btnDR_Click(object sender, EventArgs e)
        {
            MonitorDashboard mtDash = new MonitorDashboard("W1114");
            mtDash.Show();
        }

        private void btnPD_Click(object sender, EventArgs e)
        {
            MonitorDashboard mtDash = new MonitorDashboard("W1115");
            mtDash.Show();
        }

        private void btnIPDm_Click(object sender, EventArgs e)
        {
            MonitorDashboard mtDash = new MonitorDashboard("W1116");
            mtDash.Show();
        }

        private void btnIPDf_Click(object sender, EventArgs e)
        {
            MonitorDashboard mtDash = new MonitorDashboard("W1117");
            mtDash.Show();
        }

        private void btnICU_Click(object sender, EventArgs e)
        {
            MonitorDashboard mtDash = new MonitorDashboard("W1113");
            mtDash.Show();
        }

        private void panelICU_Click(object sender, EventArgs e)
        {
            if(ICU != 0)
            {
                ICUpatient ICUp = new ICUpatient();
                ICUp.Show();
            }
            else
            {
                MessageBox.Show("No Data");
            }
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Setting has Takes a while. Please wait");
            WardSetting WS = new WardSetting();
            WS.Show();
        }

        private void panelOR_Click(object sender, EventArgs e)
        {
            if(OR != 0)
            {
                ORpatient ORp = new ORpatient();
                ORp.Show();
            }
            else
            {
                MessageBox.Show("No Data");
            }
        }

        private void panelER_Click(object sender, EventArgs e)
        {
            if (ER != 0)
            {
                ERpatient ERp = new ERpatient();
                ERp.Show();
            }
            else
            {
                MessageBox.Show("No Data");
            }
        }

        private void panelIPD_Click(object sender, EventArgs e)
        {
            if (IPDm != 0 || IPDf != 0)
            {
                IPDpatient IPDp = new IPDpatient();
                IPDp.Show();
            }
            else
            {
                MessageBox.Show("No Data");
            }
        }

        private void panelPD_Click(object sender, EventArgs e)
        {
            if (PD != 0)
            {
                PDpatient PDp = new PDpatient();
                PDp.Show();
            }
            else
            {
                MessageBox.Show("No Data");
            }
        }

        private void panelDR_Click(object sender, EventArgs e)
        {
            if (DR != 0)
            {
                DRpatient DRp = new DRpatient();
                DRp.Show();
            }
            else
            {
                MessageBox.Show("No Data");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
