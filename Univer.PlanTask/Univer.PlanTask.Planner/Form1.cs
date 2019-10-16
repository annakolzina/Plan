using System;
using System.Linq;
using System.Windows.Forms;
using Univer.PlanTask.Core;
using Univer.PlanTask.Core.Store;
using Univer.PlanTask.Core.Store.Impl;

namespace Univer.PlanTask.Planner
{
    public partial class FormMain : Form
    {
        public IBaseStore store = null;

        public Task i;

        public FormMain()
        {
            InitializeComponent();
        }

        public void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            Filter(e.Start);
        }

        private void Filter(DateTime date)
        {
            cbTasks.Items.Clear();

            var tasks = store.GetAll()
                .Cast<Task>()
                .Where(task =>
                    task.Deadline.Date >= date.Date &&
                    task.StarDate.Date <= date.Date
                );

            foreach (var task in tasks)
            {
                AddTask(task);
            }
        }
        public DateTime DataDay(object sender, DateRangeEventArgs e)
        {
            return e.Start;
        }
        public void FormMain_Load(object sender, System.EventArgs e)
        {
            
            store = new FileStore<Task>();

            Filter(DateTime.Today);
        }

        public void AddTask(Task item)
        {
            cbTasks.Items.Add(item.Name + " с " + item.StartTimeHour+" : "+item.StartTimeMin + " до " + item.Deadline);
        }

        public void button2_Click(object sender, System.EventArgs e)
        {
            Form2 newForm = new Form2(this);
            newForm.Show();
        }

        public void cbTasks_SelectedIndexChanged(object sender, System.EventArgs e)
        {

        }

        private void FlowMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
