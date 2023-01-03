namespace week_9_db
{
    partial class frmIndex
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
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblStudentLast = new System.Windows.Forms.Label();
            this.lblStudentFirst = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtStudentLast = new System.Windows.Forms.TextBox();
            this.txtStudentFirst = new System.Windows.Forms.TextBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            this.StudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentFirst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentLast = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(17, 50);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(53, 13);
            this.lblStudentID.TabIndex = 0;
            this.lblStudentID.Text = "StudentId";
            // 
            // lblStudentLast
            // 
            this.lblStudentLast.AutoSize = true;
            this.lblStudentLast.Location = new System.Drawing.Point(3, 179);
            this.lblStudentLast.Name = "lblStudentLast";
            this.lblStudentLast.Size = new System.Drawing.Size(67, 13);
            this.lblStudentLast.TabIndex = 1;
            this.lblStudentLast.Text = "Student Last";
            // 
            // lblStudentFirst
            // 
            this.lblStudentFirst.AutoSize = true;
            this.lblStudentFirst.Location = new System.Drawing.Point(291, 50);
            this.lblStudentFirst.Name = "lblStudentFirst";
            this.lblStudentFirst.Size = new System.Drawing.Size(66, 13);
            this.lblStudentFirst.TabIndex = 2;
            this.lblStudentFirst.Text = "Student First";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(76, 47);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(186, 20);
            this.txtStudentID.TabIndex = 3;
            // 
            // txtStudentLast
            // 
            this.txtStudentLast.Location = new System.Drawing.Point(76, 176);
            this.txtStudentLast.Name = "txtStudentLast";
            this.txtStudentLast.Size = new System.Drawing.Size(186, 20);
            this.txtStudentLast.TabIndex = 4;
            // 
            // txtStudentFirst
            // 
            this.txtStudentFirst.Location = new System.Drawing.Point(363, 47);
            this.txtStudentFirst.Name = "txtStudentFirst";
            this.txtStudentFirst.Size = new System.Drawing.Size(186, 20);
            this.txtStudentFirst.TabIndex = 5;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(363, 167);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(190, 37);
            this.btnAddStudent.TabIndex = 6;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // dgvStudents
            // 
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentId,
            this.StudentNo,
            this.StudentFirst,
            this.StudentLast});
            this.dgvStudents.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvStudents.Location = new System.Drawing.Point(0, 237);
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.Size = new System.Drawing.Size(581, 287);
            this.dgvStudents.TabIndex = 7;
            // 
            // StudentId
            // 
            this.StudentId.DataPropertyName = "studentId";
            this.StudentId.HeaderText = "ID";
            this.StudentId.Name = "StudentId";
            // 
            // StudentNo
            // 
            this.StudentNo.DataPropertyName = "studentNo";
            this.StudentNo.HeaderText = "Student Number";
            this.StudentNo.Name = "StudentNo";
            // 
            // StudentFirst
            // 
            this.StudentFirst.DataPropertyName = "studentFirst";
            this.StudentFirst.HeaderText = "Student First Name";
            this.StudentFirst.Name = "StudentFirst";
            // 
            // StudentLast
            // 
            this.StudentLast.DataPropertyName = "studentLast";
            this.StudentLast.HeaderText = "Student Last Name";
            this.StudentLast.Name = "StudentLast";
            // 
            // frmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 524);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.txtStudentFirst);
            this.Controls.Add(this.txtStudentLast);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lblStudentFirst);
            this.Controls.Add(this.lblStudentLast);
            this.Controls.Add(this.lblStudentID);
            this.Name = "frmIndex";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmIndex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblStudentLast;
        private System.Windows.Forms.Label lblStudentFirst;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtStudentLast;
        private System.Windows.Forms.TextBox txtStudentFirst;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.DataGridView dgvStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentFirst;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentLast;
    }
}

