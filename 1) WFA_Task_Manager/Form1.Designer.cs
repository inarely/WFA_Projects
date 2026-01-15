namespace WFA_Task_Manager
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dtpDueDate = new DateTimePicker();
            txtTitle = new TextBox();
            Title = new Label();
            label1 = new Label();
            Priority = new Label();
            cmbPriority = new ComboBox();
            Status = new Label();
            cmbStatus = new ComboBox();
            dgvTasks = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnMarkDown = new Button();
            btnSave = new Button();
            btnLoad = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTasks).BeginInit();
            SuspendLayout();
            // 
            // dtpDueDate
            // 
            dtpDueDate.Location = new Point(12, 412);
            dtpDueDate.Name = "dtpDueDate";
            dtpDueDate.Size = new Size(300, 31);
            dtpDueDate.TabIndex = 0;
            // 
            // txtTitle
            // 
            txtTitle.BorderStyle = BorderStyle.FixedSingle;
            txtTitle.Location = new Point(12, 36);
            txtTitle.Multiline = true;
            txtTitle.Name = "txtTitle";
            txtTitle.ScrollBars = ScrollBars.Vertical;
            txtTitle.Size = new Size(300, 346);
            txtTitle.TabIndex = 1;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Location = new Point(12, 9);
            Title.Name = "Title";
            Title.Size = new Size(49, 24);
            Title.TabIndex = 2;
            Title.Text = "Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 385);
            label1.Name = "label1";
            label1.Size = new Size(87, 24);
            label1.TabIndex = 3;
            label1.Text = "Due Date";
            // 
            // Priority
            // 
            Priority.AutoSize = true;
            Priority.Location = new Point(12, 446);
            Priority.Name = "Priority";
            Priority.Size = new Size(71, 24);
            Priority.TabIndex = 4;
            Priority.Text = "Priority";
            // 
            // cmbPriority
            // 
            cmbPriority.FormattingEnabled = true;
            cmbPriority.Items.AddRange(new object[] { "Low", "Medium", "High" });
            cmbPriority.Location = new Point(12, 473);
            cmbPriority.Name = "cmbPriority";
            cmbPriority.Size = new Size(300, 32);
            cmbPriority.TabIndex = 5;
            cmbPriority.Text = "Choose an option...";
            cmbPriority.SelectedIndexChanged += cmbPriority_SelectedIndexChanged;
            // 
            // Status
            // 
            Status.AutoSize = true;
            Status.Location = new Point(12, 508);
            Status.Name = "Status";
            Status.Size = new Size(65, 24);
            Status.TabIndex = 6;
            Status.Text = "Status";
            // 
            // cmbStatus
            // 
            cmbStatus.FormattingEnabled = true;
            cmbStatus.Items.AddRange(new object[] { "New", "In Progress", "Done" });
            cmbStatus.Location = new Point(12, 535);
            cmbStatus.Name = "cmbStatus";
            cmbStatus.Size = new Size(300, 32);
            cmbStatus.TabIndex = 7;
            cmbStatus.Text = "Choose an option...";
            // 
            // dgvTasks
            // 
            dgvTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTasks.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTasks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvTasks.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTasks.Location = new Point(333, 36);
            dgvTasks.MultiSelect = false;
            dgvTasks.Name = "dgvTasks";
            dgvTasks.ReadOnly = true;
            dgvTasks.RowHeadersWidth = 62;
            dgvTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTasks.Size = new Size(933, 531);
            dgvTasks.TabIndex = 8;
            dgvTasks.SelectionChanged += dgvTasks_SelectionChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 592);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(410, 60);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Location = new Point(12, 659);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(410, 60);
            btnEdit.TabIndex = 10;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(430, 592);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(410, 60);
            btnDelete.TabIndex = 11;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnMarkDown
            // 
            btnMarkDown.Location = new Point(430, 659);
            btnMarkDown.Name = "btnMarkDown";
            btnMarkDown.Size = new Size(410, 60);
            btnMarkDown.TabIndex = 12;
            btnMarkDown.Text = "Mark Done";
            btnMarkDown.UseVisualStyleBackColor = true;
            btnMarkDown.Click += btnMarkDown_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(846, 592);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(420, 60);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(846, 659);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(420, 60);
            btnLoad.TabIndex = 14;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1278, 744);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(btnMarkDown);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dgvTasks);
            Controls.Add(cmbStatus);
            Controls.Add(Status);
            Controls.Add(cmbPriority);
            Controls.Add(Priority);
            Controls.Add(label1);
            Controls.Add(Title);
            Controls.Add(txtTitle);
            Controls.Add(dtpDueDate);
            Name = "Form1";
            Text = "WinForms Task Manager";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvTasks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpDueDate;
        private TextBox txtTitle;
        private Label Title;
        private Label label1;
        private Label Priority;
        private ComboBox cmbPriority;
        private Label Status;
        private ComboBox cmbStatus;
        private DataGridView dgvTasks;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnMarkDown;
        private Button btnSave;
        private Button btnLoad;
    }
}
