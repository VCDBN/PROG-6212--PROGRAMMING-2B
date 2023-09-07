using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LINQExample
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            InitializeTasks();// Here I setup a method to populate my datagridview on runtime

            comboBox1.Items.Add("Completed");
            comboBox1.Items.Add("Pending");
            comboBox1.Items.Add("All");
        }
        //Setup your properties
        public class Task
        {
            public string Title { get; set; }
            public DateTime DueDate { get; set; }
            public TaskStatus Status { get; set; }
        }
        //List<Task> taskList = new List<Task>
        //{
        // new Task { Title = "Meeting with Supervisor", DueDate = DateTime.Today.AddDays(3), Status = TaskStatus.Pending },
        // new Task { Title = "Staff Workshop", DueDate = DateTime.Today, Status = TaskStatus.Completed },
        // new Task { Title = "Call a client", DueDate = DateTime.Today.AddDays(2), Status = TaskStatus.Pending },
        // new Task { Title = "Send clothes to laundry", DueDate = DateTime.Today, Status = TaskStatus.Completed },
        // new Task { Title = "Update Calendar ", DueDate = DateTime.Today.AddDays(2), Status = TaskStatus.Pending },
        //  new Task { Title = "Attend doctors appointment", DueDate = DateTime.Today.AddDays(-2), Status = TaskStatus.Completed }
        //};

        // dataGridView1.DataSource = taskList;
        // dataGridView1.Columns["Status"].Visible = true; // This is optional - you don't have to set up this
        //}

        public void InitializeTasks()//Populating my Datgridview
        {
            dataGridView1.DataSource = tasksData;
            //   dataGridView1.DataSource = new[]
            //   {
            //      new Task { Title = "Meeting with Supervisor", DueDate = DateTime.Today.AddDays(3), Status = TaskStatus.Pending },
            //      new Task { Title = "Staff Workshop", DueDate = DateTime.Today, Status = TaskStatus.Completed },
            //      new Task { Title = "Call a client A", DueDate = DateTime.Today.AddDays(2), Status = TaskStatus.Pending },
            //       new Task { Title = "Send clothes to laundry", DueDate = DateTime.Today, Status = TaskStatus.Completed },
            //      new Task { Title = "Update Calendar ", DueDate = DateTime.Today.AddDays(2), Status = TaskStatus.Pending },
            //      new Task { Title = "Attend doctors appointment", DueDate = DateTime.Today.AddDays(-2), Status = TaskStatus.Completed },
            //       new Task { Title = "Call a client B", DueDate = DateTime.Today.AddDays(5), Status = TaskStatus.Pending },
            //    };

            //    dataGridView1.Columns["Status"].Visible = true;//This is optional- you dont have to setup this
        }

        public static Task[] tasksData = new Task[]
     {
            new Task { Title = "Meeting with Supervisor", DueDate = DateTime.Today.AddDays(3), Status = TaskStatus.Pending },
            new Task { Title = "Meeting with client", DueDate = DateTime.Today.AddDays(1), Status = TaskStatus.Pending },
            new Task { Title = "Staff Workshop", DueDate = DateTime.Today, Status = TaskStatus.Completed },
            new Task { Title = "Call a client A", DueDate = DateTime.Today.AddDays(2), Status = TaskStatus.Pending },
            new Task { Title = "Send clothes to laundry", DueDate = DateTime.Today, Status = TaskStatus.Completed },
            new Task { Title = "Update Calendar ", DueDate = DateTime.Today.AddDays(2), Status = TaskStatus.Pending },
            new Task { Title = "Attend doctors appointment", DueDate = DateTime.Today.AddDays(-2), Status = TaskStatus.Completed },
            new Task { Title = "Call a client B", DueDate = DateTime.Today.AddDays(5), Status = TaskStatus.Pending }
     };

        public enum TaskStatus//Setup my predefined constants
        {
            Pending,
            Completed
        }
        private void btnTaskCompleted_Click(object sender, EventArgs e)
        {
            // this button is for tasks that are completed

            if (dataGridView1.SelectedRows.Count > 0)
            {

                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    var task = row.DataBoundItem as Task;
                    if (task != null)
                    {
                        task.Status = TaskStatus.Completed;
                    }
                }
                RefreshDataGridView();//See Method below

                dataGridView1.Columns["Status"].Visible = true;
            }
        }

        private void RefreshDataGridView()// As the Method Shows
        {
            dataGridView1.Refresh();
        }

        private void BtnPending_Click(object sender, EventArgs e)
        {
            var pendingTasks = dataGridView1.DataSource as Task[];
            //   ?? throw new InvalidOperationException("Invalid data source");

            dataGridView1.DataSource = pendingTasks
                .Where(task => task.Status != TaskStatus.Completed)
                .ToArray();
        }

        private void btnDueDate_Click(object sender, EventArgs e)
        {
            var sortedTasks = dataGridView1.DataSource as Task[];
            //?? throw new InvalidOperationException("Invalid data source");

            dataGridView1.DataSource = sortedTasks
                .OrderBy(task => task.DueDate)
                .ToArray();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnShowCompleted_Click(object sender, EventArgs e)
        {
            var completedTasks = dataGridView1.DataSource as Task[];
            dataGridView1.DataSource = completedTasks
            .Where(task => task.Status == TaskStatus.Completed)
            .ToArray();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var allTasks = dataGridView1.DataSource as Task[];
            TaskStatus filterStatus;

            // Determine the filter status based on the selected ComboBox item.
            switch (comboBox1.SelectedItem.ToString())
            {
                case "Completed":
                    filterStatus = TaskStatus.Completed;
                    break;
                case "Pending":
                    filterStatus = TaskStatus.Pending;
                    break;
                default:
                    // If "All" or an unrecognized option is selected, no filtering is applied.
                    dataGridView1.DataSource = allTasks;
                    return;

            }
            // Apply the filter based on the selected status.
            var filteredTasks = allTasks.Where(task => task.Status == filterStatus).ToArray();
            // Update the DataGridView's data source.
            dataGridView1.DataSource = filteredTasks;


        }

        private void btnKeyword_Click(object sender, EventArgs e)
        {
            var tasks = dataGridView1.DataSource as Task[];

            if (tasks == null)
            {
                return;
            }

            string SpecialKeyword;
            SpecialKeyword = textBox1.Text;

            var filteredTasks = tasks.Where(task => task.Title.Contains(SpecialKeyword)).ToArray();

            dataGridView1.DataSource = filteredTasks;
        }






        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Retrieve existing tasks
            var existingTasks = dataGridView1.DataSource as Task[] ?? new Task[0];

            // Create a new task
            var newTask = new Task
            {
                Title = "New Task",
                DueDate = DateTime.Today.AddDays(7),
                Status = TaskStatus.Pending
            };

            // Append the new task to the existing tasks
            var updatedTasks = existingTasks.Concat(new[] { newTask }).ToArray();

            // Update DataGridView data source and refresh
            dataGridView1.DataSource = updatedTasks;
            dataGridView1.Refresh();
        }




        private void BtnFilter_Click(object sender, EventArgs e)
        {
            var tasks = dataGridView1.DataSource as Task[];

            DateTime startDate = dateTimePickerStartDate.Value;

            DateTime endDate = dateTimePickerEndDate.Value;

            dataGridView1.DataSource = tasks
                .Where(task => task.DueDate >= startDate && task.DueDate <= endDate)
                .ToArray();
        }





        private void btnCountPendingTasks_Click(object sender, EventArgs e)
        {
            var tasks = dataGridView1.DataSource as Task[];
            int pendingCount = tasks.Count(task => task.Status == TaskStatus.Pending);
            MessageBox.Show("You have " + pendingCount + " Task(s) pending", "Pending Tasks Status");
        }

        private void btnCountCompletedTasks_Click(object sender, EventArgs e)
        {
            var tasks = dataGridView1.DataSource as Task[];
            int completedCount = tasks.Count(task => task.Status == TaskStatus.Completed);
            MessageBox.Show("You have " + completedCount + " Task(s completed", "Completed Tasks Status");
        }


        private void btnGroupBy_Click(object sender, EventArgs e)
        {
            var tasks = dataGridView1.DataSource as Task[];

            var groupedTasks = tasks
                .GroupBy(task => task.Status)
                .SelectMany(group => group)
                .ToArray();
             dataGridView1.DataSource = groupedTasks;
        }

        private void btnTaskStatusProjection_Click(object sender, EventArgs e)
        {
            var tasks = dataGridView1.DataSource as Task[];
            var simplifiedTasks = tasks
            .Select(task => new { Title = task.Title, DueDate = task.DueDate })
            .ToArray();

            dataGridView1.DataSource = simplifiedTasks;
        }
    }
}
