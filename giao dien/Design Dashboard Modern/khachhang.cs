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

namespace Design_Dashboard_Modern
{
    public partial class khachhang : UserControl
    {
        public khachhang()
        {
            InitializeComponent();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
          
            dtkhach.DataSource = khachhangDAO.Instance.updatesdt(Convert.ToInt32(txtsdt.Text),Convert.ToInt32( txtmakhch.Text));
            dtkhach.DataSource = khachhangDAO.Instance.updateDC(txtdc.Text, Convert.ToInt32(txtmakhch.Text));
            MessageBox.Show(" Update thanh công ");
            load();
        }
        void load()
        {
            dtkhach.DataSource = khachhangDAO.Instance.laydanhsachkhach();

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

     
        private void khachhang_Load(object sender, EventArgs e)
        {
            load();
        }

        private void dtkhach_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            txttenkhach.Text = dtkhach.CurrentRow.Cells[1].Value.ToString();
            txtmakhch.Text = dtkhach.CurrentRow.Cells[0].Value.ToString();
            txtsdt.Text = dtkhach.CurrentRow.Cells[2].Value.ToString();
            txtdc.Text = dtkhach.CurrentRow.Cells[3].Value.ToString();
            dtkhach.DataSource = khachhangDAO.Instance.laydanhsachkhach();
        }
    }
}
