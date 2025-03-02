using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDIBasic
{
    public partial class frmChild : Form
    { 
        public frmChild(frmContainer parent, string childname, Color childcolor, Size childsize)
        {
            InitializeComponent();
            this.MdiParent = parent;
            this.Text=childname;
            this.BackColor = childcolor;
            this.Size = childsize;
        }
        private void frmChild_FormClosed(object sender, FormClosedEventArgs e)
        {
       
        }
        private void frmChild_Load(object sender, EventArgs e)
        {

        }
    }
}
