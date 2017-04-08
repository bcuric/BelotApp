namespace BelotApp
{
    partial class Form1
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
            this.txtUs = new System.Windows.Forms.TextBox();
            this.txtYou = new System.Windows.Forms.TextBox();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.lblUs = new System.Windows.Forms.Label();
            this.lblYou = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUs
            // 
            this.txtUs.Location = new System.Drawing.Point(12, 37);
            this.txtUs.Name = "txtUs";
            this.txtUs.Size = new System.Drawing.Size(62, 20);
            this.txtUs.TabIndex = 0;
            // 
            // txtYou
            // 
            this.txtYou.Location = new System.Drawing.Point(129, 37);
            this.txtYou.Name = "txtYou";
            this.txtYou.Size = new System.Drawing.Size(62, 20);
            this.txtYou.TabIndex = 1;
            // 
            // listBoxResult
            // 
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.Items.AddRange(new object[] {
            "100-82"});
            this.listBoxResult.Location = new System.Drawing.Point(70, 63);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(62, 134);
            this.listBoxResult.TabIndex = 2;
            // 
            // lblUs
            // 
            this.lblUs.AutoSize = true;
            this.lblUs.Location = new System.Drawing.Point(12, 63);
            this.lblUs.Name = "lblUs";
            this.lblUs.Size = new System.Drawing.Size(13, 13);
            this.lblUs.TabIndex = 3;
            this.lblUs.Text = "0";
            // 
            // lblYou
            // 
            this.lblYou.AutoSize = true;
            this.lblYou.Location = new System.Drawing.Point(178, 63);
            this.lblYou.Name = "lblYou";
            this.lblYou.Size = new System.Drawing.Size(13, 13);
            this.lblYou.TabIndex = 4;
            this.lblYou.Text = "0";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(80, 37);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(42, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 261);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblYou);
            this.Controls.Add(this.lblUs);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.txtYou);
            this.Controls.Add(this.txtUs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUs;
        private System.Windows.Forms.TextBox txtYou;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.Label lblUs;
        private System.Windows.Forms.Label lblYou;
        private System.Windows.Forms.Button btnAdd;
    }
}

