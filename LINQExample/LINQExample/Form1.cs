using System.Windows.Forms;

namespace LINQExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeTasks();// Here I setup a method to populate my datagridview on runtime
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
    
        private void InitializeTasks()//Populating my Datgridview
        {
            dataGridView1.DataSource = new[]
            {
                new Task { Title = "Meeting with Supervisor", DueDate = DateTime.Today.AddDays(3), Status = TaskStatus.Pending },
                new Task { Title = "Staff Workshop", DueDate = DateTime.Today, Status = TaskStatus.Completed },
                new Task { Title = "Call a client", DueDate = DateTime.Today.AddDays(2), Status = TaskStatus.Pending },
                new Task { Title = "Send clothes to laundry", DueDate = DateTime.Today, Status = TaskStatus.Completed },
                new Task { Title = "Update Calendar ", DueDate = DateTime.Today.AddDays(2), Status = TaskStatus.Pending },
                new Task { Title = "Attend doctors appointment", DueDate = DateTime.Today.AddDays(-2), Status = TaskStatus.Completed }

            };

            dataGridView1.Columns["Status"].Visible = true;//This is optional- you dont have to setup this
        }

        public enum TaskStatus//Setup my predefined constants
        {
            Pending,
            Completed
        }
        private void btnTaskCompleted_Click(object sender, EventArgs e){
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
            var pendingTasks = dataGridView1.DataSource as Task[]
                            ?? throw new InvalidOperationException("Invalid data source");

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
    }
}