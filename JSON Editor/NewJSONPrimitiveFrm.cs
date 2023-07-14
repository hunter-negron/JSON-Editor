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
    public partial class NewJSONPrimitiveFrm : Form
    {
        public string Key { get; set; } = "Primitive";
        public JSONPrimitive Result { get; set; } = new JSONPrimitive();


        public NewJSONPrimitiveFrm(bool needKey)
        {
            InitializeComponent();
            
            if(!needKey)
            {
                keyLbl.Enabled = false;
                keyTxt.Enabled = false;
                keyLbl.Visible = false;
                keyTxt.Visible = false;
            }

            booleanCbo.SelectedIndex = 0;
        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            if(stringRdo.Checked)
            {
                Result.Data = stringTxt.Text;
                Result.Type = JSONPrimitive.PrimitiveType.String;
            }
            else if(numberRdo.Checked)
            {
                Result.Data = numberNud.Value;
                Result.Type = JSONPrimitive.PrimitiveType.Number;
            }
            else if(booleanRdo.Checked)
            {
                Result.Data = booleanCbo.SelectedIndex == 0 ? true : false;
                Result.Type = JSONPrimitive.PrimitiveType.Boolean;
            }
            else if(nullRdo.Checked)
            {
                Result.Type = JSONPrimitive.PrimitiveType.Null;
            }
            else
            {
                return;
            }

            this.DialogResult = DialogResult.OK;
            Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            Close();
        }

        private void keyTxt_TextChanged(object sender, EventArgs e)
        {
            Key = keyTxt.Text;
        }
    }
}
