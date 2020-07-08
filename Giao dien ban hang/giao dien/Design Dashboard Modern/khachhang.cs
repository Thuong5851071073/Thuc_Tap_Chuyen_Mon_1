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
using Excel = Microsoft.Office.Interop.Excel;
using Microsoft.Office.Interop.E
    xcel;
using System.Text.RegularExpressions;


namespace Design_Dashboard_Modern
{
    public partial class khachhang : UserControl
    {
        public khachhang()
        {
            InitializeComponent();
        }

        #region thêm và update khách hàng;
        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
          
            dtkhach.DataSource = khachhangDAO.Instance.updatesdt(Convert.ToInt32(txtsdt.Text),Convert.ToInt32( txtmakhch.Text));
            dtkhach.DataSource = khachhangDAO.Instance.updateDC(txtdc.Text, Convert.ToInt32(txtmakhch.Text));
            MessageBox.Show(" Update thanh công ");
            load();
        }
       
        private void bunifuFlatButton1_Click(object sender, EventArgs e)
            
        {
            if (txttenkhach.Text == "") {
                MessageBox.Show("Mời bạn nhập tên khách");
            }
            else if ( txtsdt.Text == "")
            {
                MessageBox.Show("Mời bạn nhập SĐT:");

            }
            else if (txtdc.Text == "")
            {
                MessageBox.Show("Mời bạn nhập Địa chỉ:");
            }
            else
            {
                khachhangDAO.Instance.ThemKhach(txttenkhach.Text,txtdc.Text,  Convert.ToInt32(txtsdt.Text));
                MessageBox.Show("Nhập thành công");
                load();

            }
           
        }
        #endregion;
        #region Load datagiview Kháchhang
        void load()
        {
            dtkhach.DataSource = khachhangDAO.Instance.laydanhsachkhach();

        }
        private void khachhang_Load(object sender, EventArgs e)
        {
            load();
        }
        #endregion;
        #region LoaD từ datagiview lên textbox
        private void dtkhach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txttenkhach.Text = dtkhach.CurrentRow.Cells[1].Value.ToString();
            txtmakhch.Text = dtkhach.CurrentRow.Cells[0].Value.ToString();
            txtsdt.Text = dtkhach.CurrentRow.Cells[2].Value.ToString();
            txtdc.Text = dtkhach.CurrentRow.Cells[3].Value.ToString();
            dtkhach.DataSource = khachhangDAO.Instance.laydanhsachkhach();
        }
        #endregion;
        #region bắt lỗi nhập chữ ;
        private static bool IsNumber(string val)
        {
            if (val != "")
                return Regex.IsMatch(val, @"^[0-9]\d*\.?[0]*$");
            else return true;
        }
        private void txtsdt_OnValueChanged(object sender, EventArgs e)
        {
            if (IsNumber(txtsdt.Text) != true)
            {
                MessageBox.Show("Dữ liệu nhập không hợp lệ, không được nhập ký tự", "Thông báo");
                txtsdt.Text = "";
            }
        }
        #endregion;

        private void btnXuatExcel_Click(object sender, EventArgs e)
        {

        }
    }
}
