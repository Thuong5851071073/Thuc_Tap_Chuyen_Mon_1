using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Design_Dashboard_Modern.DAO;
using System.Data.SqlClient;
using DevExpress.XtraReports.UI;
namespace Design_Dashboard_Modern
 
{
    public partial class fmbaocao : UserControl
    {
        public fmbaocao()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
          //   Hoadondao.Instance.tinhtongdanhthu(tungay.,toingay.Text);
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {


            //DB con = new DB();
            //con.openconection();
            //SqlCommand cmd = new SqlCommand("'");
            //SqlDataAdapter da = new SqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //    da.Fill(dt);


            //con.closeconnection();
          
            if (txtmanguoidug.Text == "")
            {
                MessageBox.Show("bạn chưa nhập mã nhân viên");
            }
            else
            {
                int manguoidung = Convert.ToInt32(txtmanguoidug.Text);
              
               
            }
            

        }

        private void fmbaocao_Load(object sender, EventArgs e)
        {
            charttheongaythang.Series["Doanhthutheothang"].Points.Add(400000);
            charttheongaythang.Series["Doanhthutheothang"].Points[0].Label="408500";
            charttheongaythang.Series["Doanhthutheothang"].Points[0].Color = Color.Blue ;
            charttheongaythang.Series["Doanhthutheothang"].Points[0].AxisLabel = "Thang 1";

            charttheongaythang.Series["Doanhthutheothang"].Points.Add(500000);
            charttheongaythang.Series["Doanhthutheothang"].Points[1].Label = "580000";
            charttheongaythang.Series["Doanhthutheothang"].Points[1].Color = Color.Yellow;
            charttheongaythang.Series["Doanhthutheothang"].Points[1].AxisLabel = "Thang 2";

            charttheongaythang.Series["Doanhthutheothang"].Points.Add(6000000);
            charttheongaythang.Series["Doanhthutheothang"].Points[2].Label = "6077000";
            charttheongaythang.Series["Doanhthutheothang"].Points[2].Color = Color.Green;
            charttheongaythang.Series["Doanhthutheothang"].Points[2].AxisLabel = "Thang 3";


            charttheongaythang.Series["Doanhthutheothang"].Points.Add(700000);
            charttheongaythang.Series["Doanhthutheothang"].Points[3].Label = "720800";
            charttheongaythang.Series["Doanhthutheothang"].Points[3].Color = Color.Gray;
            charttheongaythang.Series["Doanhthutheothang"].Points[3].AxisLabel = "Thang 4";
            charttheongaythang.Series["Doanhthutheothang"].Points.Add(800000);
            charttheongaythang.Series["Doanhthutheothang"].Points[4].Label = "826000";
            charttheongaythang.Series["Doanhthutheothang"].Points[4].Color = Color.Gray;
            charttheongaythang.Series["Doanhthutheothang"].Points[4].AxisLabel = "Thang 5";
            //charttheongaythang.Series["Doanhthutheothang"].Points.AddY("Thang 1");
            //charttheongaythang.Series["Doanhthutheothang"].Points.AddY("Thang 2");
            //charttheongaythang.Series["Doanhthutheothang"].Points.AddY("Thang 3");
            //charttheongaythang.Series["Doanhthutheothang"].Points.AddY("Thang 4");
            //charttheongaythang.Series["Doanhthutheothang"].Points.AddY("Thang 5");
            //charttheongaythang.Series["Doanhthutheothang"].Points.AddY("Thang 6");
            //charttheongaythang.Series["Doanhthutheothang"].Points.AddY("Thang 7");
            //charttheongaythang.Series["Doanhthutheothang"].Points.AddY("Thang 8");
            //charttheongaythang.Series["Doanhthutheothang"].Points.AddY("Thang 9");
            //charttheongaythang.Series["Doanhthutheothang"].Points.AddY("Thang 10");
            //charttheongaythang.Series["Doanhthutheothang"].Points.AddY("Thang 11");
            //charttheongaythang.Series["Doanhthutheothang"].Points.AddY("Thang 12");



        }

        private void charttheongaythang_Click(object sender, EventArgs e)
        {

        }
    }
}
