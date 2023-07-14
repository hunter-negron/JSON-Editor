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
        JSONObject document = new JSONObject();

        public mainFrm()
        {
            InitializeComponent();
        }

        private void addNodeBtn_Click(object sender, EventArgs e)
        {
            if (documentTrv.SelectedNode is not null && documentTrv.SelectedNode.Tag is JSONPrimitive) return;
            if (newValueTypeCbo.SelectedIndex == -1) return;

            JSONValue parent = documentTrv.SelectedNode is null ? document : (JSONValue) documentTrv.SelectedNode.Tag;
            TreeNodeCollection nodes = documentTrv.SelectedNode is null ? documentTrv.Nodes : documentTrv.SelectedNode.Nodes;

            bool needKey = parent is JSONObject;

            if (newValueTypeCbo.SelectedIndex == 0)
            {
                // new primitive
                NewJSONPrimitiveFrm newPrim = new NewJSONPrimitiveFrm(needKey);
                if(newPrim.ShowDialog() == DialogResult.OK)
                {
                    if(needKey)
                    {
                        ((JSONObject)parent).Data.Add(newPrim.Key, newPrim.Result);

                        TreeNode node = new TreeNode(newPrim.Key);
                        node.Tag = newPrim.Result;
                        nodes.Add(node);
                    }
                    else
                    {
                        ((JSONArray) parent).Data.Add(newPrim.Result);
                    }
                }

            }
            else if(newValueTypeCbo.SelectedIndex == 1)
            {
                // new object
            }
            else if (newValueTypeCbo.SelectedIndex == 2)
            {
                // new array
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
