
namespace JSON_Editor
{
    partial class mainFrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.documentTrv = new System.Windows.Forms.TreeView();
            this.addNodeBtn = new System.Windows.Forms.Button();
            this.deleteNodeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // documentTrv
            // 
            this.documentTrv.Location = new System.Drawing.Point(13, 13);
            this.documentTrv.Name = "documentTrv";
            this.documentTrv.Size = new System.Drawing.Size(421, 355);
            this.documentTrv.TabIndex = 0;
            this.documentTrv.Click += new System.EventHandler(this.documentTrv_Click);
            // 
            // addNodeBtn
            // 
            this.addNodeBtn.Location = new System.Drawing.Point(440, 13);
            this.addNodeBtn.Name = "addNodeBtn";
            this.addNodeBtn.Size = new System.Drawing.Size(208, 52);
            this.addNodeBtn.TabIndex = 1;
            this.addNodeBtn.Text = "Add Node";
            this.addNodeBtn.UseVisualStyleBackColor = true;
            this.addNodeBtn.Click += new System.EventHandler(this.addNodeBtn_Click);
            // 
            // deleteNodeBtn
            // 
            this.deleteNodeBtn.Location = new System.Drawing.Point(440, 71);
            this.deleteNodeBtn.Name = "deleteNodeBtn";
            this.deleteNodeBtn.Size = new System.Drawing.Size(208, 52);
            this.deleteNodeBtn.TabIndex = 2;
            this.deleteNodeBtn.Text = "Delete Node";
            this.deleteNodeBtn.UseVisualStyleBackColor = true;
            this.deleteNodeBtn.Click += new System.EventHandler(this.deleteNodeBtn_Click);
            // 
            // mainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deleteNodeBtn);
            this.Controls.Add(this.addNodeBtn);
            this.Controls.Add(this.documentTrv);
            this.Name = "mainFrm";
            this.Text = "JSON Editor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView documentTrv;
        private System.Windows.Forms.Button addNodeBtn;
        private System.Windows.Forms.Button deleteNodeBtn;
    }
}

