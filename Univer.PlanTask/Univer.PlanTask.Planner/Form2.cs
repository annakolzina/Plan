using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Univer.PlanTask.Core;

namespace Univer.PlanTask.Planner
{
    public partial class Form2 : Form
    {
        private FormMain Form1;

        public Form2()
        {
            InitializeComponent();
        }
        public Form2(FormMain frm1)
        {
            InitializeComponent();
            Form1 = frm1;
        }



        public void label1_Click(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
            var task = new Task(textBox1.Text, dateTime1.Value.Hour, dateTime1.Value.Minute,  dateTime1.Value.Day, dateTime1.Value ,dateTime2.Value);

            Form1.AddTask(task);
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
