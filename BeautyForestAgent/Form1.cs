using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BeautyForestAgent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void VisibleChange(bool visible)
        {
            this.Visible = visible;
            this.ntiTray.Visible = !visible;
        }

        private void 폼보이기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VisibleChange(true);
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ntiTray.Visible = false;
            Application.ExitThread();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            VisibleChange(false);
        }

        private void BtnTray_Click(object sender, EventArgs e)
        {
            VisibleChange(false);
        }

        private void NtiTray_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            VisibleChange(true);
        }

        private void 이프로그램은ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowModaless();

        }

        private void ShowModaless()
        {
            this.stripmessage.Text = "이 프로그램은... 창을 띄웁니다.";
            FormAbout m = new FormAbout();
            m.Title = "이 프로그램은... 창띄우기";
            m.Show();
        }
        
            
        


        private void ToolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void StatusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void 끝내기ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.stripmessage.Text = "종료합니다.";
            Application.ExitThread();  

        }

        private void 수정ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.stripmessage.Text = "프로필 수정";
            ShowModalUpdate();
        }
        private void ShowModalUpdate()
        {
            this.stripmessage.Text = "모달수정 창을 띄웁니다.";
            FormModify m = new FormModify();
            m.Title = "모달 수정";
            m.ShowDialog();
            
        }

        private void 추가ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.stripmessage.Text = "프로필추가";
            ShowModalAdd();
        }

        private void ShowModalAdd()
        {
            this.stripmessage.Text = "모달추가 창을 띄웁니다.";
            FormAdd m = new FormAdd();
            m.Title = "모달 추가";
            m.ShowDialog();
        }

        private void BtnModify_Click(object sender, EventArgs e)
        {
            this.stripmessage.Text = "프로필 수정";
            ShowModalUpdate();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            this.stripmessage.Text = "프로필추가";
            ShowModalAdd();
        }
    }

}
