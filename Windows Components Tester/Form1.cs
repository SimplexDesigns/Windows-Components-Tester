using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using Microsoft.WindowsAPICodePack.Taskbar;
using Microsoft.WindowsAPICodePack.Shell;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.IO;
using System.Globalization;
using Microsoft.VisualBasic;

namespace Windows_Components_Tester
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox3.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox5.SelectedIndex = 0;
        }

        private void SetTaskbarProgressState(TaskbarProgressBarState state)
        {
            // Set the progress state of the taskbar button
            TaskbarManager.Instance.SetProgressState(state);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            TaskbarManager.Instance.SetProgressValue(0, 100);
            taskbarTrackbar.Value = 0;
            comboBox5.SelectedIndex =0;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            TaskbarManager.Instance.SetProgressValue(25, 100);
            taskbarTrackbar.Value = 25;
        }

        private void button50_Click(object sender, EventArgs e)
        {
            TaskbarManager.Instance.SetProgressValue(50, 100);
            taskbarTrackbar.Value = 50;
        }

        private void button75_Click(object sender, EventArgs e)
        {
            TaskbarManager.Instance.SetProgressValue(75, 100);
            taskbarTrackbar.Value = 75;
        }

        private void button100_Click(object sender, EventArgs e)
        {
            TaskbarManager.Instance.SetProgressValue(100, 100);
            taskbarTrackbar.Value = 100;
        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox5.SelectedIndex == 0)
            {
                taskbarTrackbar.Value = 0;
                taskbarTrackbar.Enabled = false;
            }
            if (comboBox5.SelectedIndex == 1) 
            {
                TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Normal);
                taskbarTrackbar.Enabled = true;
            }
            if (comboBox5.SelectedIndex == 2)
            {
                TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Paused);
                taskbarTrackbar.Enabled = true;
            }
            if (comboBox5.SelectedIndex == 3)
            {
                TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Error);
                taskbarTrackbar.Enabled = true;
            }
            if (comboBox5.SelectedIndex == 4)
            {
               TaskbarManager.Instance.SetProgressState(TaskbarProgressBarState.Indeterminate);
                taskbarTrackbar.Enabled = false;
            }
        }

        private void taskbarTrackbar_Scroll(object sender, EventArgs e)
        {
            TaskbarManager.Instance.SetProgressValue(taskbarTrackbar.Value, 100);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MDIParentForm frm2 = new MDIParentForm();
            {
                frm2.Show();
            }
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ToolForm frm2 = new ToolForm();
            {
                frm2.Show();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
            }
        }

        private void menuItem3_Click(object sender, EventArgs e)
        {
            AboutForm abt = new AboutForm();
            {
                abt.Show();
            }
        }




        // private void progressbar_trackbar_Scroll(object sender, EventArgs e)
        //{
        //windows7ProgressBar.Value = this.progressbar_trackbar.Value;
        //TaskbarManager.Instance.SetProgressValue(this.progressbar_trackbar.Value, 100);
        //textBox_tbr_percent.Text = string.Concat(progressbar_trackbar.Value.ToString() + "%");
        //}
    }

}
