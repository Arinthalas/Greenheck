namespace Greenheck_Project
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
            this.tabOverview = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvOverview = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.cbDept = new System.Windows.Forms.ComboBox();
            this.lblQuarter = new System.Windows.Forms.Label();
            this.cbQuarter = new System.Windows.Forms.ComboBox();
            this.lblTeam = new System.Windows.Forms.Label();
            this.cbTeams = new System.Windows.Forms.ComboBox();
            this.tabTeam = new System.Windows.Forms.TabPage();
            this.txtDeptID = new System.Windows.Forms.TextBox();
            this.lblDeptID = new System.Windows.Forms.Label();
            this.btnDelTeam = new System.Windows.Forms.Button();
            this.btnCreateTeam = new System.Windows.Forms.Button();
            this.txtTeamID = new System.Windows.Forms.TextBox();
            this.txtTeamName = new System.Windows.Forms.TextBox();
            this.lblTeamID = new System.Windows.Forms.Label();
            this.lblTeams = new System.Windows.Forms.Label();
            this.cbDelTeam = new System.Windows.Forms.ComboBox();
            this.clmYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmQuarter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBackLog = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOngoing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmHiatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCancelled = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabOverview.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverview)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabTeam.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabOverview
            // 
            this.tabOverview.Controls.Add(this.tabPage1);
            this.tabOverview.Controls.Add(this.tabPage2);
            this.tabOverview.Controls.Add(this.tabTeam);
            this.tabOverview.Location = new System.Drawing.Point(12, 75);
            this.tabOverview.Name = "tabOverview";
            this.tabOverview.SelectedIndex = 0;
            this.tabOverview.Size = new System.Drawing.Size(725, 401);
            this.tabOverview.TabIndex = 0;
            this.tabOverview.Tag = "";
            this.tabOverview.SelectedIndexChanged += new System.EventHandler(this.tabOverview_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvOverview);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(717, 375);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Overview";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvOverview
            // 
            this.dgvOverview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmYear,
            this.clmQuarter,
            this.clmBackLog,
            this.clmOngoing,
            this.clmDone,
            this.clmHiatus,
            this.clmCancelled});
            this.dgvOverview.Location = new System.Drawing.Point(6, 70);
            this.dgvOverview.Name = "dgvOverview";
            this.dgvOverview.RowHeadersVisible = false;
            this.dgvOverview.Size = new System.Drawing.Size(705, 150);
            this.dgvOverview.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblDepartment);
            this.tabPage2.Controls.Add(this.cbDept);
            this.tabPage2.Controls.Add(this.lblQuarter);
            this.tabPage2.Controls.Add(this.cbQuarter);
            this.tabPage2.Controls.Add(this.lblTeam);
            this.tabPage2.Controls.Add(this.cbTeams);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(678, 375);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Selection";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(31, 26);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(93, 13);
            this.lblDepartment.TabIndex = 5;
            this.lblDepartment.Text = "Department Name";
            // 
            // cbDept
            // 
            this.cbDept.FormattingEnabled = true;
            this.cbDept.Location = new System.Drawing.Point(130, 23);
            this.cbDept.Name = "cbDept";
            this.cbDept.Size = new System.Drawing.Size(121, 21);
            this.cbDept.TabIndex = 4;
            this.cbDept.SelectedIndexChanged += new System.EventHandler(this.cbDept_SelectedIndexChanged);
            // 
            // lblQuarter
            // 
            this.lblQuarter.AutoSize = true;
            this.lblQuarter.Location = new System.Drawing.Point(28, 107);
            this.lblQuarter.Name = "lblQuarter";
            this.lblQuarter.Size = new System.Drawing.Size(42, 13);
            this.lblQuarter.TabIndex = 3;
            this.lblQuarter.Text = "Quarter";
            this.lblQuarter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cbQuarter
            // 
            this.cbQuarter.FormattingEnabled = true;
            this.cbQuarter.Location = new System.Drawing.Point(130, 104);
            this.cbQuarter.Name = "cbQuarter";
            this.cbQuarter.Size = new System.Drawing.Size(121, 21);
            this.cbQuarter.TabIndex = 2;
            // 
            // lblTeam
            // 
            this.lblTeam.AutoSize = true;
            this.lblTeam.Location = new System.Drawing.Point(28, 68);
            this.lblTeam.Name = "lblTeam";
            this.lblTeam.Size = new System.Drawing.Size(65, 13);
            this.lblTeam.TabIndex = 1;
            this.lblTeam.Text = "Team Name";
            this.lblTeam.UseMnemonic = false;
            // 
            // cbTeams
            // 
            this.cbTeams.FormattingEnabled = true;
            this.cbTeams.Location = new System.Drawing.Point(130, 65);
            this.cbTeams.Name = "cbTeams";
            this.cbTeams.Size = new System.Drawing.Size(121, 21);
            this.cbTeams.TabIndex = 0;
            // 
            // tabTeam
            // 
            this.tabTeam.Controls.Add(this.cbDelTeam);
            this.tabTeam.Controls.Add(this.txtDeptID);
            this.tabTeam.Controls.Add(this.lblDeptID);
            this.tabTeam.Controls.Add(this.btnDelTeam);
            this.tabTeam.Controls.Add(this.btnCreateTeam);
            this.tabTeam.Controls.Add(this.txtTeamID);
            this.tabTeam.Controls.Add(this.txtTeamName);
            this.tabTeam.Controls.Add(this.lblTeamID);
            this.tabTeam.Controls.Add(this.lblTeams);
            this.tabTeam.Location = new System.Drawing.Point(4, 22);
            this.tabTeam.Name = "tabTeam";
            this.tabTeam.Padding = new System.Windows.Forms.Padding(3);
            this.tabTeam.Size = new System.Drawing.Size(520, 375);
            this.tabTeam.TabIndex = 2;
            this.tabTeam.Text = "Teams";
            this.tabTeam.UseVisualStyleBackColor = true;
            // 
            // txtDeptID
            // 
            this.txtDeptID.Location = new System.Drawing.Point(127, 91);
            this.txtDeptID.Name = "txtDeptID";
            this.txtDeptID.Size = new System.Drawing.Size(100, 20);
            this.txtDeptID.TabIndex = 7;
            // 
            // lblDeptID
            // 
            this.lblDeptID.AutoSize = true;
            this.lblDeptID.Location = new System.Drawing.Point(34, 94);
            this.lblDeptID.Name = "lblDeptID";
            this.lblDeptID.Size = new System.Drawing.Size(79, 13);
            this.lblDeptID.TabIndex = 6;
            this.lblDeptID.Text = "Department ID:";
            // 
            // btnDelTeam
            // 
            this.btnDelTeam.Location = new System.Drawing.Point(344, 58);
            this.btnDelTeam.Name = "btnDelTeam";
            this.btnDelTeam.Size = new System.Drawing.Size(99, 23);
            this.btnDelTeam.TabIndex = 5;
            this.btnDelTeam.Text = "Remove Team";
            this.btnDelTeam.UseVisualStyleBackColor = true;
            this.btnDelTeam.Click += new System.EventHandler(this.btnDelTeam_Click);
            // 
            // btnCreateTeam
            // 
            this.btnCreateTeam.Location = new System.Drawing.Point(74, 136);
            this.btnCreateTeam.Name = "btnCreateTeam";
            this.btnCreateTeam.Size = new System.Drawing.Size(99, 23);
            this.btnCreateTeam.TabIndex = 4;
            this.btnCreateTeam.Text = "Create Team";
            this.btnCreateTeam.UseVisualStyleBackColor = true;
            this.btnCreateTeam.Click += new System.EventHandler(this.btnCreateTeam_Click);
            // 
            // txtTeamID
            // 
            this.txtTeamID.Location = new System.Drawing.Point(127, 60);
            this.txtTeamID.Name = "txtTeamID";
            this.txtTeamID.Size = new System.Drawing.Size(100, 20);
            this.txtTeamID.TabIndex = 3;
            // 
            // txtTeamName
            // 
            this.txtTeamName.Location = new System.Drawing.Point(127, 28);
            this.txtTeamName.Name = "txtTeamName";
            this.txtTeamName.Size = new System.Drawing.Size(100, 20);
            this.txtTeamName.TabIndex = 2;
            // 
            // lblTeamID
            // 
            this.lblTeamID.AutoSize = true;
            this.lblTeamID.Location = new System.Drawing.Point(31, 63);
            this.lblTeamID.Name = "lblTeamID";
            this.lblTeamID.Size = new System.Drawing.Size(51, 13);
            this.lblTeamID.TabIndex = 1;
            this.lblTeamID.Text = "Team ID:";
            // 
            // lblTeams
            // 
            this.lblTeams.AutoSize = true;
            this.lblTeams.Location = new System.Drawing.Point(31, 31);
            this.lblTeams.Name = "lblTeams";
            this.lblTeams.Size = new System.Drawing.Size(68, 13);
            this.lblTeams.TabIndex = 0;
            this.lblTeams.Text = "Team Name:";
            // 
            // cbDelTeam
            // 
            this.cbDelTeam.FormattingEnabled = true;
            this.cbDelTeam.Location = new System.Drawing.Point(332, 28);
            this.cbDelTeam.Name = "cbDelTeam";
            this.cbDelTeam.Size = new System.Drawing.Size(121, 21);
            this.cbDelTeam.TabIndex = 8;
            // 
            // clmYear
            // 
            this.clmYear.HeaderText = "Fiscal Year";
            this.clmYear.Name = "clmYear";
            // 
            // clmQuarter
            // 
            this.clmQuarter.HeaderText = "Quarter";
            this.clmQuarter.Name = "clmQuarter";
            this.clmQuarter.ReadOnly = true;
            // 
            // clmBackLog
            // 
            this.clmBackLog.HeaderText = "Not Started";
            this.clmBackLog.Name = "clmBackLog";
            this.clmBackLog.ReadOnly = true;
            // 
            // clmOngoing
            // 
            this.clmOngoing.HeaderText = "In Progress";
            this.clmOngoing.Name = "clmOngoing";
            this.clmOngoing.ReadOnly = true;
            // 
            // clmDone
            // 
            this.clmDone.HeaderText = "Completed";
            this.clmDone.Name = "clmDone";
            this.clmDone.ReadOnly = true;
            // 
            // clmHiatus
            // 
            this.clmHiatus.HeaderText = "On Hiatus";
            this.clmHiatus.Name = "clmHiatus";
            this.clmHiatus.ReadOnly = true;
            // 
            // clmCancelled
            // 
            this.clmCancelled.HeaderText = "Cancelled";
            this.clmCancelled.Name = "clmCancelled";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 488);
            this.Controls.Add(this.tabOverview);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabOverview.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOverview)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabTeam.ResumeLayout(false);
            this.tabTeam.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabOverview;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblQuarter;
        private System.Windows.Forms.ComboBox cbQuarter;
        private System.Windows.Forms.Label lblTeam;
        private System.Windows.Forms.ComboBox cbTeams;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.ComboBox cbDept;
        private System.Windows.Forms.TabPage tabTeam;
        private System.Windows.Forms.Button btnDelTeam;
        private System.Windows.Forms.Button btnCreateTeam;
        private System.Windows.Forms.TextBox txtTeamID;
        private System.Windows.Forms.TextBox txtTeamName;
        private System.Windows.Forms.Label lblTeamID;
        private System.Windows.Forms.Label lblTeams;
        private System.Windows.Forms.TextBox txtDeptID;
        private System.Windows.Forms.Label lblDeptID;
        private System.Windows.Forms.DataGridView dgvOverview;
        private System.Windows.Forms.ComboBox cbDelTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmQuarter;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBackLog;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOngoing;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDone;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmHiatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCancelled;
    }
}

