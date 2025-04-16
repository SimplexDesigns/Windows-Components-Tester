using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Controls.WindowsForms;
using Microsoft.WindowsAPICodePack.Shell;

namespace Windows_Components_Tester
{
    public partial class BasicWindow : Form
    {
        public BasicWindow()
        {
            InitializeComponent();
        }

        private void BasicWindow_Load(object sender, EventArgs e)
        {
            explorerBrowser1.Navigate(ShellFileSystemFolder.FromFolderPath("C:\\Windows\\Resources\\Themes"));
        }
    }
}
