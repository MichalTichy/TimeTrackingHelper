namespace TimeTrackingHelper
{
    partial class TimeTrackingHelper
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
            this.components = new System.ComponentModel.Container();
            this.lStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lWStarted = new System.Windows.Forms.Label();
            this.lEfficiency = new System.Windows.Forms.Label();
            this.lTotalWorkTime = new System.Windows.Forms.Label();
            this.lTotelRestTime = new System.Windows.Forms.Label();
            this.lCurrentRestTime = new System.Windows.Forms.Label();
            this.butWorkControl = new System.Windows.Forms.Button();
            this.butPauseControl = new System.Windows.Forms.LinkLabel();
            this.lAwerageWorkLenght = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lAwerageRestLenght = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lTotalTime = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.listView = new System.Windows.Forms.ListView();
            this.cType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cStart = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cEnd = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cDuration = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.timerUIUpdate = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lStatus
            // 
            this.lStatus.AutoSize = true;
            this.lStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lStatus.Location = new System.Drawing.Point(544, 9);
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(141, 29);
            this.lStatus.TabIndex = 1;
            this.lStatus.Text = "WORKING";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(544, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Work started:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(565, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Efficiency:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(511, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Total working time:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(500, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(535, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Total rest time:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(497, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Current rest lenght:";
            // 
            // lWStarted
            // 
            this.lWStarted.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lWStarted.Location = new System.Drawing.Point(646, 49);
            this.lWStarted.Name = "lWStarted";
            this.lWStarted.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lWStarted.Size = new System.Drawing.Size(87, 17);
            this.lWStarted.TabIndex = 8;
            // 
            // lEfficiency
            // 
            this.lEfficiency.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEfficiency.Location = new System.Drawing.Point(646, 66);
            this.lEfficiency.Name = "lEfficiency";
            this.lEfficiency.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lEfficiency.Size = new System.Drawing.Size(87, 17);
            this.lEfficiency.TabIndex = 9;
            // 
            // lTotalWorkTime
            // 
            this.lTotalWorkTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotalWorkTime.Location = new System.Drawing.Point(646, 100);
            this.lTotalWorkTime.Name = "lTotalWorkTime";
            this.lTotalWorkTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lTotalWorkTime.Size = new System.Drawing.Size(87, 17);
            this.lTotalWorkTime.TabIndex = 10;
            // 
            // lTotelRestTime
            // 
            this.lTotelRestTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotelRestTime.Location = new System.Drawing.Point(646, 117);
            this.lTotelRestTime.Name = "lTotelRestTime";
            this.lTotelRestTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lTotelRestTime.Size = new System.Drawing.Size(87, 17);
            this.lTotelRestTime.TabIndex = 11;
            // 
            // lCurrentRestTime
            // 
            this.lCurrentRestTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lCurrentRestTime.Location = new System.Drawing.Point(646, 175);
            this.lCurrentRestTime.Name = "lCurrentRestTime";
            this.lCurrentRestTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lCurrentRestTime.Size = new System.Drawing.Size(87, 17);
            this.lCurrentRestTime.TabIndex = 12;
            // 
            // butWorkControl
            // 
            this.butWorkControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butWorkControl.Location = new System.Drawing.Point(500, 218);
            this.butWorkControl.Name = "butWorkControl";
            this.butWorkControl.Size = new System.Drawing.Size(230, 23);
            this.butWorkControl.TabIndex = 13;
            this.butWorkControl.Text = "START";
            this.butWorkControl.UseVisualStyleBackColor = true;
            this.butWorkControl.Click += new System.EventHandler(this.butWorkControl_Click);
            // 
            // butPauseControl
            // 
            this.butPauseControl.LinkColor = System.Drawing.Color.Red;
            this.butPauseControl.Location = new System.Drawing.Point(500, 192);
            this.butPauseControl.Name = "butPauseControl";
            this.butPauseControl.Size = new System.Drawing.Size(230, 23);
            this.butPauseControl.TabIndex = 14;
            this.butPauseControl.TabStop = true;
            this.butPauseControl.Text = "start pause";
            this.butPauseControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.butPauseControl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.butPauseControl_LinkClicked);
            // 
            // lAwerageWorkLenght
            // 
            this.lAwerageWorkLenght.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAwerageWorkLenght.Location = new System.Drawing.Point(646, 134);
            this.lAwerageWorkLenght.Name = "lAwerageWorkLenght";
            this.lAwerageWorkLenght.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lAwerageWorkLenght.Size = new System.Drawing.Size(87, 17);
            this.lAwerageWorkLenght.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(496, 134);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Average work lenght:";
            // 
            // lAwerageRestLenght
            // 
            this.lAwerageRestLenght.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAwerageRestLenght.Location = new System.Drawing.Point(646, 151);
            this.lAwerageRestLenght.Name = "lAwerageRestLenght";
            this.lAwerageRestLenght.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lAwerageRestLenght.Size = new System.Drawing.Size(87, 17);
            this.lAwerageRestLenght.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(501, 151);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(136, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = "Average rest lenght:";
            // 
            // lTotalTime
            // 
            this.lTotalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTotalTime.Location = new System.Drawing.Point(646, 83);
            this.lTotalTime.Name = "lTotalTime";
            this.lTotalTime.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lTotalTime.Size = new System.Drawing.Size(87, 17);
            this.lTotalTime.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(563, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 17);
            this.label9.TabIndex = 19;
            this.label9.Text = "Total time:";
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cType,
            this.cStart,
            this.cEnd,
            this.cDuration});
            this.listView.FullRowSelect = true;
            this.listView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView.LabelWrap = false;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(490, 243);
            this.listView.TabIndex = 21;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // cType
            // 
            this.cType.Text = "Type";
            // 
            // cStart
            // 
            this.cStart.Text = "Start";
            this.cStart.Width = 150;
            // 
            // cEnd
            // 
            this.cEnd.Text = "End";
            this.cEnd.Width = 150;
            // 
            // cDuration
            // 
            this.cDuration.Text = "Duration";
            this.cDuration.Width = 125;
            // 
            // timerUIUpdate
            // 
            this.timerUIUpdate.Interval = 1000;
            this.timerUIUpdate.Tick += new System.EventHandler(this.timerUIUpdate_Tick);
            // 
            // TimeTrackingHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 243);
            this.Controls.Add(this.listView);
            this.Controls.Add(this.lTotalTime);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lAwerageRestLenght);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lAwerageWorkLenght);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.butPauseControl);
            this.Controls.Add(this.butWorkControl);
            this.Controls.Add(this.lCurrentRestTime);
            this.Controls.Add(this.lTotelRestTime);
            this.Controls.Add(this.lTotalWorkTime);
            this.Controls.Add(this.lEfficiency);
            this.Controls.Add(this.lWStarted);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "TimeTrackingHelper";
            this.Text = "Time Tracking Helper";
            this.Shown += new System.EventHandler(this.TimeTrackingHelper_Shown);
            this.SizeChanged += new System.EventHandler(this.TimeTrackingHelper_SizeChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lWStarted;
        private System.Windows.Forms.Label lEfficiency;
        private System.Windows.Forms.Label lTotalWorkTime;
        private System.Windows.Forms.Label lTotelRestTime;
        private System.Windows.Forms.Label lCurrentRestTime;
        private System.Windows.Forms.Button butWorkControl;
        private System.Windows.Forms.LinkLabel butPauseControl;
        private System.Windows.Forms.Label lAwerageWorkLenght;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lAwerageRestLenght;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lTotalTime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Timer timerUIUpdate;
        private System.Windows.Forms.ColumnHeader cType;
        private System.Windows.Forms.ColumnHeader cStart;
        private System.Windows.Forms.ColumnHeader cEnd;
        private System.Windows.Forms.ColumnHeader cDuration;
    }
}

