using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Components_Tester
{
    public partial class MDIParentForm : Form
    {
        public MDIParentForm()
        {
            InitializeComponent();
        }

        private void MDIParentForm_Load(object sender, EventArgs e)
        {
            
        }

        private void menuItem1_Click(object sender, EventArgs e)
        {
            BasicWindow childForm = new BasicWindow();
            childForm.MdiParent = MDIParentForm.ActiveForm;
            childForm.Show();
        }

        private void menuItem2_Click(object sender, EventArgs e)
        {
            ToolForm childForm = new ToolForm();
            childForm.MdiParent = MDIParentForm.ActiveForm;
            childForm.Show();
        }
    }
}
