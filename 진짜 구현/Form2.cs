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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Visible = false; // 현재 폼 안보이게 하기 
            Form3 frm = new Form3(); // 새 폼 생성
            frm.Owner = this; // 새 폼의 오너를 현재 폼으로 
            frm.Show(); // 새폼 보여 주기
        }
    }
}
