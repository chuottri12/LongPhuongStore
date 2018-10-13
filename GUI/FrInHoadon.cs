using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using Microsoft.Reporting.WinForms;
namespace GUI
{
    public partial class FrInHoadon : Form
    {
        public FrInHoadon()
        {
            InitializeComponent();
        }
        BUS_ReceiveBill bushd = new BUS_ReceiveBill();
        private void FrInHoadon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QuanlybanbanhDataSet2.Hoadon' table. You can move, or remove it, as needed.
            try
            {
                this.HoadonTableAdapter.Fill(this.QuanlybanbanhDataSet2.Hoadon);
            }
            catch (Exception ex)
            {
                return;
            }
            this.reportViewer1.RefreshReport();
            DataTable dt = new DataTable();
            dt = bushd.Danhsach();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<ReportParameter> Parameters = new List<ReportParameter>(); //Tạo danh sách các Parameter để truyền cho Report
            ReportParameter param = default(ReportParameter);
            param = new ReportParameter("RPmahd", textBox1.Text); //parameter "PhoneNumber" của Report
            Parameters.Add(param);

            reportViewer1.LocalReport.SetParameters(Parameters);
            //gán danh sách các Parameter vào Report
            reportViewer1.RefreshReport();
            //gọi RefreshReport() để bắt đầu hiển thị
        }
    }
}
