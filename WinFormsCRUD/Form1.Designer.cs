namespace WinFormsCRUD
{
    partial class Form1
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
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            splitContainer3 = new SplitContainer();
            splitContainer4 = new SplitContainer();
            label2 = new Label();
            label1 = new Label();
            splitContainer5 = new SplitContainer();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            btnUpdate = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            dgvEmployeeList = new DataGridView();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer5).BeginInit();
            splitContainer5.Panel1.SuspendLayout();
            splitContainer5.Panel2.SuspendLayout();
            splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEmployeeList).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(10, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(1083, 661);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(splitContainer1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(10);
            groupBox1.Size = new Size(1083, 661);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "EMPLOYEE REGISTER";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(10, 26);
            splitContainer1.Margin = new Padding(5);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dgvEmployeeList);
            splitContainer1.Panel2.Padding = new Padding(10);
            splitContainer1.Size = new Size(1063, 625);
            splitContainer1.SplitterDistance = 371;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(splitContainer3);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(btnUpdate);
            splitContainer2.Panel2.Controls.Add(btnSave);
            splitContainer2.Panel2.Controls.Add(btnDelete);
            splitContainer2.Panel2.Padding = new Padding(10);
            splitContainer2.Size = new Size(1063, 371);
            splitContainer2.SplitterDistance = 299;
            splitContainer2.TabIndex = 0;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(splitContainer4);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(splitContainer5);
            splitContainer3.Panel2.Padding = new Padding(25);
            splitContainer3.Size = new Size(1063, 299);
            splitContainer3.SplitterDistance = 344;
            splitContainer3.TabIndex = 0;
            // 
            // splitContainer4
            // 
            splitContainer4.Dock = DockStyle.Fill;
            splitContainer4.Location = new Point(0, 0);
            splitContainer4.Margin = new Padding(15);
            splitContainer4.Name = "splitContainer4";
            splitContainer4.Orientation = Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            splitContainer4.Panel1.Controls.Add(label2);
            // 
            // splitContainer4.Panel2
            // 
            splitContainer4.Panel2.Controls.Add(label1);
            splitContainer4.Size = new Size(344, 299);
            splitContainer4.SplitterDistance = 137;
            splitContainer4.TabIndex = 0;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Location = new Point(141, 61);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 1;
            label2.Text = "FirstName :";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(137, 72);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 2;
            label1.Text = "LastName :";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // splitContainer5
            // 
            splitContainer5.Dock = DockStyle.Fill;
            splitContainer5.Location = new Point(25, 25);
            splitContainer5.Name = "splitContainer5";
            splitContainer5.Orientation = Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            splitContainer5.Panel1.Controls.Add(txtFirstName);
            splitContainer5.Panel1.Padding = new Padding(20);
            // 
            // splitContainer5.Panel2
            // 
            splitContainer5.Panel2.Controls.Add(txtLastName);
            splitContainer5.Panel2.Padding = new Padding(20);
            splitContainer5.Size = new Size(665, 249);
            splitContainer5.SplitterDistance = 112;
            splitContainer5.TabIndex = 0;
            // 
            // txtFirstName
            // 
            txtFirstName.Dock = DockStyle.Fill;
            txtFirstName.Location = new Point(20, 20);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(625, 23);
            txtFirstName.TabIndex = 0;
            // 
            // txtLastName
            // 
            txtLastName.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtLastName.Location = new Point(20, 55);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(625, 23);
            txtLastName.TabIndex = 1;
            // 
            // btnUpdate
            // 
            btnUpdate.Dock = DockStyle.Left;
            btnUpdate.Location = new Point(10, 10);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(110, 48);
            btnUpdate.TabIndex = 2;
            btnUpdate.Text = "UPDATE";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Right;
            btnSave.Location = new Point(833, 10);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 48);
            btnSave.TabIndex = 1;
            btnSave.Text = "SAVE";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Dock = DockStyle.Right;
            btnDelete.Location = new Point(943, 10);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(110, 48);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvEmployeeList
            // 
            dgvEmployeeList.AllowUserToAddRows = false;
            dgvEmployeeList.AllowUserToDeleteRows = false;
            dgvEmployeeList.AllowUserToResizeColumns = false;
            dgvEmployeeList.AllowUserToResizeRows = false;
            dgvEmployeeList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvEmployeeList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvEmployeeList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployeeList.Dock = DockStyle.Fill;
            dgvEmployeeList.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvEmployeeList.Location = new Point(10, 10);
            dgvEmployeeList.Name = "dgvEmployeeList";
            dgvEmployeeList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmployeeList.Size = new Size(1043, 230);
            dgvEmployeeList.TabIndex = 0;
            dgvEmployeeList.DoubleClick += dgvEmployeeList_DoubleClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1103, 681);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Name = "Form1";
            Padding = new Padding(10);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PROFILING";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel1.PerformLayout();
            splitContainer4.Panel2.ResumeLayout(false);
            splitContainer4.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
            splitContainer5.Panel1.ResumeLayout(false);
            splitContainer5.Panel1.PerformLayout();
            splitContainer5.Panel2.ResumeLayout(false);
            splitContainer5.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer5).EndInit();
            splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEmployeeList).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private SplitContainer splitContainer1;
        private DataGridView dgvEmployeeList;
        private SplitContainer splitContainer2;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSave;
        private SplitContainer splitContainer3;
        private Label label2;
        private SplitContainer splitContainer4;
        private Label label1;
        private SplitContainer splitContainer5;
        private TextBox txtFirstName;
        private TextBox txtLastName;
    }
}
