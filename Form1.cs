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
    public partial class frmContainer : Form
    {
        private bool newMenuItemClicked = false;
        public frmContainer()
        {
            InitializeComponent();
            listBoxColors.Items.AddRange(new string[] { "red", "green", "yellow", "blue","gray", "black","white ","pink", "purple","orange","cyan" });
      }
        private void frmContainer_Load(object sender, EventArgs e)
        {

        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            newMenuItemClicked = true;
        }

        private void backgroundColorButton_Click_1(object sender, EventArgs e)
        {
            if (newMenuItemClicked)
            {
                try
                {
                    string childName = formNameTextBox.Text;
                    int width = int.Parse(widthTextBox.Text);
                    int height = int.Parse(heightTextBox.Text);
                    if (listBoxColors.SelectedItem==null)
                    {
                        MessageBox.Show("XATOlik: " , "xato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;

                    }
                    Color childColor = Color.FromName(listBoxColors.SelectedItem.ToString());

                    frmChild child = new frmChild(this, childName, childColor, new Size(width, height));
                    child.Show();

                    newMenuItemClicked = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("XATOlik: " + ex.Message, "xato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Avval menyudan 'New'ni tanlang.", "Ma'lumot", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }   
   
}

     
