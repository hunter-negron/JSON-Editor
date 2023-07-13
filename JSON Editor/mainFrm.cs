using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSON_Editor
{
    public partial class mainFrm : Form
    {
        public mainFrm()
        {
            InitializeComponent();
        }

        private void addNodeBtn_Click(object sender, EventArgs e)
        {
            if(documentTrv.SelectedNode is null)
            {
                documentTrv.Nodes.Add("this is a node!");
            }
            else
            {
                documentTrv.SelectedNode.Nodes.Add("another one");
            }
        }

        private void deleteNodeBtn_Click(object sender, EventArgs e)
        {
            if (documentTrv.SelectedNode is null) return;

            documentTrv.SelectedNode.Remove();
        }

        private void documentTrv_Click(object sender, EventArgs e)
        {
            MouseEventArgs mouseArgs = (MouseEventArgs)e;

            if (mouseArgs.Button == MouseButtons.Right)
            {
                documentTrv.SelectedNode = null;
            }
        }
    }
}
