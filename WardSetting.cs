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
    public partial class WardSetting : Form
    {
        SqlConnection Conn;
        SqlCommand cmd;
        SqlDataReader Reader;

        public WardSetting()
        {
            InitializeComponent();
            String strConn = "Data Source=JICOMPUTER;Initial Catalog=Tricus_Data;Integrated Security=True";
            Conn = new SqlConnection(strConn);
            setCb();
        }

        public void setCb()
        {
            var cbWard = new[] {cbDR11,cbDR12,cbER11,cbER12,cbER13,cbER14,cbER15,cbER16,cbER17,cbER18,cbER19,cbER20,cbER21,cbER22,cbER23,cbER24,cbER25,cbER26,
            cbICU11,cbICU12,cbICU13,cbICU14,cbICU15,cbICU16,cbICU17,cbICU18,
            cbIPDf11,cbIPDf12,cbIPDf13,cbIPDf14,cbIPDf15,cbIPDf16,cbIPDf17,cbIPDf18,cbIPDf19,cbIPDf20,cbIPDf21,cbIPDf22,cbIPDf23,cbIPDf24,cbIPDf25,cbIPDf26,
            cbIPDm11,cbIPDm12,cbIPDm13,cbIPDm14,cbIPDm15,cbIPDm16,cbIPDm17,cbIPDm18,cbIPDm19,cbIPDm20,cbIPDm21,cbIPDm22,cbIPDm23,cbIPDm24,cbIPDm25,cbIPDm26,
            cbOR11,cbOR12,cbOR13,cbOR14,cbPD11,cbPD12,cbPD13,cbPD14};

            String[] BID = new String[] {"DR11","DR12","ER11","ER12","ER13","ER14","ER15","ER16","ER17","ER18","ER19","ER20","ER21","ER22","ER23","ER24","ER25","ER26",
                                         "ICU11","ICU12","ICU13","ICU14","ICU15","ICU16","ICU17","ICU18",
                                         "IPDf11","IPDf12","IPDf13","IPDf14","IPDf15","IPDf16","IPDf17","IPDf18","IPDf19","IPDf20","IPDf21","IPDf22","IPDf23","IPDf24","IPDf25","IPDf26",
                                         "IPDm11","IPDm12","IPDm13","IPDm14","IPDm15","IPDm16","IPDm17","IPDm18","IPDm19","IPDm20","IPDm21","IPDm22","IPDm23","IPDm24","IPDm25","IPDm26",
                                         "OR11","OR12","OR13","OR14","PD11","PD12","PD13","PD14"};

            for(int i=0;i<66;i++)
            {
                Conn.Open();
                String SQL = "Select Port From Bed ";
                SQL += "Where BID = '" + BID[i] + "' ";
                cmd = new SqlCommand(SQL, Conn);
                Reader = cmd.ExecuteReader();
                Reader.Read();
                cbWard[i].Text = Reader["Port"].ToString();
                Conn.Close();
            }

        }

        private void panel1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var cbWard = new[] {cbDR11,cbDR12,cbER11,cbER12,cbER13,cbER14,cbER15,cbER16,cbER17,cbER18,cbER19,cbER20,cbER21,cbER22,cbER23,cbER24,cbER25,cbER26,
            cbICU11,cbICU12,cbICU13,cbICU14,cbICU15,cbICU16,cbICU17,cbICU18,
            cbIPDf11,cbIPDf12,cbIPDf13,cbIPDf14,cbIPDf15,cbIPDf16,cbIPDf17,cbIPDf18,cbIPDf19,cbIPDf20,cbIPDf21,cbIPDf22,cbIPDf23,cbIPDf24,cbIPDf25,cbIPDf26,
            cbIPDm11,cbIPDm12,cbIPDm13,cbIPDm14,cbIPDm15,cbIPDm16,cbIPDm17,cbIPDm18,cbIPDm19,cbIPDm20,cbIPDm21,cbIPDm22,cbIPDm23,cbIPDm24,cbIPDm25,cbIPDm26,
            cbOR11,cbOR12,cbOR13,cbOR14,cbPD11,cbPD12,cbPD13,cbPD14};

            String[] BID = new String[] {"DR11","DR12","ER11","ER12","ER13","ER14","ER15","ER16","ER17","ER18","ER19","ER20","ER21","ER22","ER23","ER24","ER25","ER26",
                                         "ICU11","ICU12","ICU13","ICU14","ICU15","ICU16","ICU17","ICU18",
                                         "IPDf11","IPDf12","IPDf13","IPDf14","IPDf15","IPDf16","IPDf17","IPDf18","IPDf19","IPDf20","IPDf21","IPDf22","IPDf23","IPDf24","IPDf25","IPDf26",
                                         "IPDm11","IPDm12","IPDm13","IPDm14","IPDm15","IPDm16","IPDm17","IPDm18","IPDm19","IPDm20","IPDm21","IPDm22","IPDm23","IPDm24","IPDm25","IPDm26",
                                         "OR11","OR12","OR13","OR14","PD11","PD12","PD13","PD14"};

            Conn.Open();
            for(int i=0;i<66;i++)
            {
                String SQL = "Update Bed set Port = '" + cbWard[i].Text + "' ";
                SQL += "Where BID = '" + BID[i] + "' ";
                cmd = new SqlCommand(SQL, Conn);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(SQL);
                }
            }
            Conn.Close();
            MessageBox.Show("Port has Set");
            this.Close();
        }
    }
}
