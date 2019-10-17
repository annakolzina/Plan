using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Univer.PlanTask.Core;
using Univer.PlanTask.Core.Store.Impl;

namespace Univer.PlanTask.Planner
{
    public partial class Form2 : Form
    {
        public string FormName
        {
            get
            {
                return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
            }
        }
        private FormMain Form1;
        /// <summary>
        /// Дата начало
        /// </summary>
        public DateTime StartDate
        {
            get
            {
                return dateTime1.Value;
            }
            set
            {
                dateTime1.Value = value;
            }
        }

        /// <summary>
        /// Срок выполнения
        /// </summary>
        public DateTime Deadline
        {
            get
            {
                return dateTime2.Value;
            }
            set
            {
                dateTime2.Value = value;
            }
        }

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
            var task = new Task(textBox1.Text, dateTime1.Value ,dateTime2.Value, 0);

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
