namespace TimeTrackingHelper
{
    partial class CurrentStatus
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
            this.butChangeStatus = new System.Windows.Forms.Button();
            this.labRestLength = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butChangeStatus
            // 
            this.butChangeStatus.BackColor = System.Drawing.Color.White;
            this.butChangeStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butChangeStatus.Location = new System.Drawing.Point(0, 0);
            this.butChangeStatus.Name = "butChangeStatus";
            this.butChangeStatus.Size = new System.Drawing.Size(20, 20);
            this.butChangeStatus.TabIndex = 0;
            this.butChangeStatus.UseVisualStyleBackColor = false;
            this.butChangeStatus.Click += new System.EventHandler(this.butChangeStatus_Click);
            // 
            // labRestLength
            // 
            this.labRestLength.ForeColor = System.Drawing.Color.Red;
            this.labRestLength.Location = new System.Drawing.Point(56, 0);
            this.labRestLength.Name = "labRestLength";
            this.labRestLength.Size = new System.Drawing.Size(189, 17);
            this.labRestLength.TabIndex = 1;
            this.labRestLength.Text = "XXXXX";
            this.labRestLength.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // CurrentStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(330, 20);
            this.Controls.Add(this.labRestLength);
            this.Controls.Add(this.butChangeStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CurrentStatus";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CurrentStatus";
            this.Load += new System.EventHandler(this.CurrentStatus_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butChangeStatus;
        private System.Windows.Forms.Label labRestLength;
    }
}