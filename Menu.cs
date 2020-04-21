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
    public partial class Menu : Form
    {
        SqlConnection Conn;
        SqlDataReader Reader;
        SqlCommand cmd;

        public Menu()
        {
            InitializeComponent();
            String strConn = "Data Source=JICOMPUTER;Initial Catalog=Tricus_Data;Integrated Security=True";
            Conn = new SqlConnection(strConn);
            Count();
        }

        public void Count()
        {
            Conn.Open();
            String PatientSQL = "Select Count(HN) As cntHN From PatientData";
            cmd = new SqlCommand(PatientSQL, Conn);
            Reader = cmd.ExecuteReader();
            Reader.Read();
            try
            {
                int num = Convert.ToInt16(Reader["cntHN"].ToString());
                if(num < 10)
                {
                    lbPatient.Text = "000" + num;
                }
                else if(num < 100)
                {
                    lbPatient.Text = "00" + num;
                }
                else if(num < 1000)
                {
                    lbPatient.Text = "0" + num;
                }

            }
            catch (Exception ex)
            {
                lbPatient.Text = "0000";
            }
            Conn.Close();

            Conn.Open();
            String OPDSQL = "Select Count(HN) As cntHN From sentPhysician Where Status = 'O'";
            cmd = new SqlCommand(OPDSQL, Conn);
            Reader = cmd.ExecuteReader();
            Reader.Read();
            try
            {
                int num = Convert.ToInt16(Reader["cntHN"].ToString());
                if (num < 10)
                {
                    lbOPD.Text = "000" + num;
                }
                else if (num < 100)
                {
                    lbOPD.Text = "00" + num;
                }
                else if (num < 1000)
                {
                    lbOPD.Text = "0" + num;
                }
            }
            catch (Exception ex)
            {
                lbOPD.Text = "0000";
            }
            Conn.Close();

            Conn.Open();
            String IPDSQL = "Select Count(HN) As cntHN From sentPhysician Where Status = 'I'";
            cmd = new SqlCommand(IPDSQL, Conn);
            Reader = cmd.ExecuteReader();
            Reader.Read();
            try
            {
                int num = Convert.ToInt16(Reader["cntHN"].ToString());
                if (num < 10)
                {
                    lbIPD.Text = "000" + num;
                }
                else if (num < 100)
                {
                    lbIPD.Text = "00" + num;
                }
                else if (num < 1000)
                {
                    lbIPD.Text = "0" + num;
                }
            }
            catch (Exception ex)
            {
                lbIPD.Text = "0000";
            }
            Conn.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            Patient pt = new Patient();
            pt.Show();
        }

        private void btnPhy_Click(object sender, EventArgs e)
        {
            LoginPhysician lp = new LoginPhysician();
            lp.Show();
        }

        private void btnWard_Click(object sender, EventArgs e)
        {
            Ward wd = new Ward();
            wd.Show();
        }
    }
}