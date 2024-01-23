using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        // MainForm의 버튼 이벤트 처리
        private void SinglePlayButton_Click(object sender, EventArgs e)
        {
            Hide();
            SinglePlayForm singlePlayForm = new SinglePlayForm();
            singlePlayForm.FormClosed += new FormClosedEventHandler(childForm_Closed);
            singlePlayForm.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        void childForm_Closed(object sender, FormClosedEventArgs e)
        {
            Show();
        }

        // 메뉴 화면에서 함께하기 화면으로 연결하기
        private void multiPlayButton_Click(object sender, EventArgs e)
        {
            Hide();
            MultiPlayForm multiPlayForm = new MultiPlayForm();
            multiPlayForm.FormClosed += new FormClosedEventHandler(childForm_Closed);
            multiPlayForm.Show();
        }

        // 인공지능 연습 창으로 이동하기
        private void AIPlayButton_Click(object sender, EventArgs e)
        {
            Hide();
            AIPlayForm aiPlayform = new AIPlayForm();
            aiPlayform.FormClosed += new FormClosedEventHandler(childForm_Closed);
            aiPlayform.Show();
        }
    }
}

