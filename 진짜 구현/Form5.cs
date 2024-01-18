using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication5
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Visible = false; // 현재 폼 안보이게 하기 
            Form6 frm = new Form6(); // 새 폼 생성
            frm.Owner = this; // 새 폼의 오너를 현재 폼으로 
            frm.Show(); // 새폼 보여 주기 
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.Visible = false; // 현재 폼 안보이게 하기 
            Form4 frm = new Form4(); // 새 폼 생성
            frm.Owner = this; // 새 폼의 오너를 현재 폼으로 
            frm.Show(); // 새폼 보여 주기
        }
    }
}
