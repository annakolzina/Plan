using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web.Script.Serialization;
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

        public object JsonConvert { get; private set; }

        public FormMain()
        {
            InitializeComponent();
        }

        public void calendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            Filter(e.Start);
        }

        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            using (var taskDialog = new Form2())
            {
                taskDialog.StartDate = calendar.SelectionStart;
                taskDialog.Deadline = calendar.SelectionEnd;
                if (taskDialog.ShowDialog() == DialogResult.OK)
                {
                    if (!string.IsNullOrWhiteSpace(taskDialog.FormName))
                    {
                        var newTask = new Task()
                        {
                            Name = taskDialog.FormName,
                            Deadline = taskDialog.Deadline,
                            StartDate = taskDialog.StartDate,
                            Status = 0,
                        };
                        store.Create(newTask);
                        AddTask(newTask);
                    }
                }
            }
        }
        private void Filter(DateTime date)
        {
            cbTasks.Items.Clear();
            listBox1.Items.Clear();
            listBox2.Items.Clear();

            var tasks = store.GetAll()
                .Cast<Task>()
                .Where(task =>
                    task.Deadline.Date >= date.Date &&
                    task.StartDate.Date <= date.Date
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

        private List<Task> listoftasks = new List<Task>();
        public void AddTask(Task item)
        {
            store.Create(item);
            store.Get(item.Id);
            cbTasks.Items.Add(item.Name);
            listBox2.Items.Add("в процессе");
            if (item.StartDate.Date == item.Deadline.Date)
            {
                listBox1.Items.Add("c " + item.StartDate.Hour + ":" + item.StartDate.Minute + " по " + item.Deadline.Hour + ":" + item.Deadline.Minute);
            }
            else
            {
                listBox1.Items.Add("c " + item.StartDate + " по " + item.Deadline);
            }
            listoftasks.Add(item);
        }

        private JavaScriptSerializer Serializer = new JavaScriptSerializer();

        /// <summary>
        /// Запись в файл
        /// </summary>
        /// <param name="item">объект типа Task</param>
        public void FileSt(Task item)
        {
            var json = Serializer.Serialize(listoftasks);
            File.WriteAllText(@"E:\path.json", json);
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

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// вызов контекстного меню при нажатии на правую кнопку мыши из эл cbTask
        /// </summary>
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
              {
              switch (e.Button)
        {
        case MouseButtons.Right:
        {
            contextMenuStrip1.Show(this, new Point(e.X, e.Y));//places the menu at the pointer position
        }
        break;
    }
}
        /// <summary>
        /// вызов контекстного меню - изменение времени
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        ///
    private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
    {
        switch (e.Button)
        {
            case MouseButtons.Right:
                {
                    contextMenuStrip2.Show(this, new Point(e.X, e.Y));//places the menu at the pointer position
                }
                break;
        }
    }
        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Right:
                    {
                        contextMenuStrip3.Show(this, new Point(e.X, e.Y));//places the menu at the pointer position
                    }
                    break;
            }
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }
        private void ВыполнитьЗадачуToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void РедактироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }

}
