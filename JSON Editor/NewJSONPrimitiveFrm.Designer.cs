
namespace JSON_Editor
{
    partial class NewJSONPrimitiveFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.stringRdo = new System.Windows.Forms.RadioButton();
            this.stringTxt = new System.Windows.Forms.TextBox();
            this.numberRdo = new System.Windows.Forms.RadioButton();
            this.numberNud = new System.Windows.Forms.NumericUpDown();
            this.booleanRdo = new System.Windows.Forms.RadioButton();
            this.booleanCbo = new System.Windows.Forms.ComboBox();
            this.nullRdo = new System.Windows.Forms.RadioButton();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.okBtn = new System.Windows.Forms.Button();
            this.keyLbl = new System.Windows.Forms.Label();
            this.keyTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numberNud)).BeginInit();
            this.SuspendLayout();
            // 
            // stringRdo
            // 
            this.stringRdo.AutoSize = true;
            this.stringRdo.Location = new System.Drawing.Point(12, 49);
            this.stringRdo.Name = "stringRdo";
            this.stringRdo.Size = new System.Drawing.Size(117, 41);
            this.stringRdo.TabIndex = 0;
            this.stringRdo.TabStop = true;
            this.stringRdo.Text = "String";
            this.stringRdo.UseVisualStyleBackColor = true;
            // 
            // stringTxt
            // 
            this.stringTxt.Location = new System.Drawing.Point(192, 58);
            this.stringTxt.Name = "stringTxt";
            this.stringTxt.Size = new System.Drawing.Size(270, 43);
            this.stringTxt.TabIndex = 1;
            // 
            // numberRdo
            // 
            this.numberRdo.AutoSize = true;
            this.numberRdo.Location = new System.Drawing.Point(12, 96);
            this.numberRdo.Name = "numberRdo";
            this.numberRdo.Size = new System.Drawing.Size(145, 41);
            this.numberRdo.TabIndex = 2;
            this.numberRdo.TabStop = true;
            this.numberRdo.Text = "Number";
            this.numberRdo.UseVisualStyleBackColor = true;
            // 
            // numberNud
            // 
            this.numberNud.Location = new System.Drawing.Point(192, 107);
            this.numberNud.Name = "numberNud";
            this.numberNud.Size = new System.Drawing.Size(270, 43);
            this.numberNud.TabIndex = 3;
            // 
            // booleanRdo
            // 
            this.booleanRdo.AutoSize = true;
            this.booleanRdo.Location = new System.Drawing.Point(12, 143);
            this.booleanRdo.Name = "booleanRdo";
            this.booleanRdo.Size = new System.Drawing.Size(145, 41);
            this.booleanRdo.TabIndex = 4;
            this.booleanRdo.TabStop = true;
            this.booleanRdo.Text = "Boolean";
            this.booleanRdo.UseVisualStyleBackColor = true;
            // 
            // booleanCbo
            // 
            this.booleanCbo.FormattingEnabled = true;
            this.booleanCbo.Items.AddRange(new object[] {
            "True",
            "False"});
            this.booleanCbo.Location = new System.Drawing.Point(192, 156);
            this.booleanCbo.Name = "booleanCbo";
            this.booleanCbo.Size = new System.Drawing.Size(272, 45);
            this.booleanCbo.TabIndex = 5;
            // 
            // nullRdo
            // 
            this.nullRdo.AutoSize = true;
            this.nullRdo.Location = new System.Drawing.Point(12, 190);
            this.nullRdo.Name = "nullRdo";
            this.nullRdo.Size = new System.Drawing.Size(97, 41);
            this.nullRdo.TabIndex = 6;
            this.nullRdo.TabStop = true;
            this.nullRdo.Text = "Null";
            this.nullRdo.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(619, 386);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(169, 52);
            this.cancelBtn.TabIndex = 7;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // okBtn
            // 
            this.okBtn.Location = new System.Drawing.Point(444, 386);
            this.okBtn.Name = "okBtn";
            this.okBtn.Size = new System.Drawing.Size(169, 52);
            this.okBtn.TabIndex = 8;
            this.okBtn.Text = "OK";
            this.okBtn.UseVisualStyleBackColor = true;
            this.okBtn.Click += new System.EventHandler(this.okBtn_Click);
            // 
            // keyLbl
            // 
            this.keyLbl.AutoSize = true;
            this.keyLbl.Location = new System.Drawing.Point(12, 9);
            this.keyLbl.Name = "keyLbl";
            this.keyLbl.Size = new System.Drawing.Size(66, 37);
            this.keyLbl.TabIndex = 9;
            this.keyLbl.Text = "Key:";
            // 
            // keyTxt
            // 
            this.keyTxt.Location = new System.Drawing.Point(192, 9);
            this.keyTxt.Name = "keyTxt";
            this.keyTxt.PlaceholderText = "Enter key name";
            this.keyTxt.Size = new System.Drawing.Size(270, 43);
            this.keyTxt.TabIndex = 10;
            this.keyTxt.TextChanged += new System.EventHandler(this.keyTxt_TextChanged);
            // 
            // NewJSONPrimitiveFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.keyTxt);
            this.Controls.Add(this.keyLbl);
            this.Controls.Add(this.okBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.nullRdo);
            this.Controls.Add(this.booleanCbo);
            this.Controls.Add(this.booleanRdo);
            this.Controls.Add(this.numberNud);
            this.Controls.Add(this.numberRdo);
            this.Controls.Add(this.stringTxt);
            this.Controls.Add(this.stringRdo);
            this.Name = "NewJSONPrimitiveFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Primitive";
            ((System.ComponentModel.ISupportInitialize)(this.numberNud)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton stringRdo;
        private System.Windows.Forms.TextBox stringTxt;
        private System.Windows.Forms.RadioButton numberRdo;
        private System.Windows.Forms.NumericUpDown numberNud;
        private System.Windows.Forms.RadioButton booleanRdo;
        private System.Windows.Forms.ComboBox booleanCbo;
        private System.Windows.Forms.RadioButton nullRdo;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button okBtn;
        private System.Windows.Forms.Label keyLbl;
        private System.Windows.Forms.TextBox keyTxt;
    }
}