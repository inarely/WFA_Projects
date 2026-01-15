using System.ComponentModel;
using System.Text.Json;
using System.IO;

namespace WFA_Task_Manager
{
    public partial class Form1 : Form
    {
        private BindingList<TaskItem> _tasks = new BindingList<TaskItem>();
        private const string FileName = "tasks.json";
        private string _dataDir;
        private string _filePath;
        private static string FindProjectRoot(string startDir)
        {
            DirectoryInfo dir = new DirectoryInfo(startDir);

            while (dir != null)
            {
                if (dir.GetFiles("*.csproj").Length > 0)
                    return dir.FullName;
                dir = dir.Parent;
            }
            return startDir; // fallback
        }


        public Form1()
        {

            InitializeComponent();
            string baseDir = AppDomain.CurrentDomain.BaseDirectory;
            string projectDir = FindProjectRoot(baseDir);

            _dataDir = Path.Combine(projectDir, "Data");
            _filePath = Path.Combine(_dataDir, "tasks.json");

            dgvTasks.AutoGenerateColumns = true;
            dgvTasks.ReadOnly = true;
            dgvTasks.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvTasks.MultiSelect = false;

            dgvTasks.DataSource = _tasks;

            dgvTasks.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvTasks.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;

            dgvTasks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTasks.Columns["Title"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;


            // defaults for comboboxes
            cmbPriority.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbStatus.DropDownStyle = ComboBoxStyle.DropDownList;

            cmbPriority.Items.Clear();
            cmbPriority.Items.AddRange(new object[] { "Low", "Medium", "High" });

            cmbStatus.Items.Clear();
            cmbStatus.Items.AddRange(new object[] { "New", "In Progress", "Done" });

            cmbPriority.SelectedIndex = 0;
            cmbStatus.SelectedIndex = 0;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<TaskItem> tasks = new List<TaskItem>();

        }

        private void cmbPriority_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();

            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Title cannot be empty.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var task = new TaskItem
            {
                Title = title,
                DueDate = dtpDueDate.Value.Date,
                Priority = cmbPriority.SelectedItem.ToString(),
                Status = cmbStatus.SelectedItem.ToString()
            };

            _tasks.Add(task);
            dgvTasks.Columns["Title"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            txtTitle.Clear();
            txtTitle.Focus();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvTasks.CurrentRow == null)
            {
                MessageBox.Show("Select a task first.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int index = dgvTasks.CurrentRow.Index;

            var confirm = MessageBox.Show("Delete selected task?", "Confirm",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
                _tasks.RemoveAt(index);
        }

        private void btnMarkDown_Click(object sender, EventArgs e)
        {
            if (dgvTasks.CurrentRow == null)
            {
                MessageBox.Show("Select a task first.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int index = dgvTasks.CurrentRow.Index;
            _tasks[index].Status = "Done";

            dgvTasks.Refresh();
        }

        private void dgvTasks_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvTasks.CurrentRow == null) return;

            int index = dgvTasks.CurrentRow.Index;
            if (index < 0 || index >= _tasks.Count) return;

            var task = _tasks[index];

            txtTitle.Text = task.Title;
            dtpDueDate.Value = task.DueDate;

            cmbPriority.SelectedItem = task.Priority;
            cmbStatus.SelectedItem = task.Status;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvTasks.CurrentRow == null)
            {
                MessageBox.Show("Select a task first.", "Info",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int index = dgvTasks.CurrentRow.Index;
            if (index < 0 || index >= _tasks.Count) return;

            string title = txtTitle.Text.Trim();
            if (string.IsNullOrWhiteSpace(title))
            {
                MessageBox.Show("Title cannot be empty.", "Validation",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var task = _tasks[index];
            task.Title = title;
            task.DueDate = dtpDueDate.Value.Date;
            task.Priority = cmbPriority.SelectedItem.ToString();
            task.Status = cmbStatus.SelectedItem.ToString();

            dgvTasks.Refresh();

            MessageBox.Show("Task updated.", "Done",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Directory.CreateDirectory(_dataDir);

                var options = new JsonSerializerOptions { WriteIndented = true };
                string json = JsonSerializer.Serialize(_tasks.ToList(), options);

                File.WriteAllText(_filePath, json);

                MessageBox.Show("Saved successfully.\n\nPath:\n" + _filePath, "Save",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Save failed: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(_filePath))
                {
                    MessageBox.Show("No saved file found.\n\nPath:\n" + _filePath, "Load",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                string json = File.ReadAllText(_filePath);
                var loaded = JsonSerializer.Deserialize<List<TaskItem>>(json);

                if (loaded == null)
                {
                    MessageBox.Show("File is empty or corrupted.", "Load",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                _tasks.Clear();
                foreach (var task in loaded)
                    _tasks.Add(task);

                MessageBox.Show("Loaded successfully.", "Load",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Load failed: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
