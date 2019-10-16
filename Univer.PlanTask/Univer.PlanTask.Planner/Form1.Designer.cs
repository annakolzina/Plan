namespace Univer.PlanTask.Planner
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.flowTop = new System.Windows.Forms.FlowLayoutPanel();
            this.flowMain = new System.Windows.Forms.FlowLayoutPanel();
            this.calendar = new System.Windows.Forms.MonthCalendar();
            this.flowLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.cbTasks = new System.Windows.Forms.CheckedListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.flowMain.SuspendLayout();
            this.flowLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowTop
            // 
            resources.ApplyResources(this.flowTop, "flowTop");
            this.flowTop.Name = "flowTop";
            // 
            // flowMain
            // 
            this.flowMain.Controls.Add(this.calendar);
            resources.ApplyResources(this.flowMain, "flowMain");
            this.flowMain.Name = "flowMain";
            this.flowMain.Paint += new System.Windows.Forms.PaintEventHandler(this.FlowMain_Paint);
            // 
            // calendar
            // 
            resources.ApplyResources(this.calendar, "calendar");
            this.calendar.Name = "calendar";
            this.calendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.calendar_DateChanged);
            // 
            // flowLeft
            // 
            this.flowLeft.Controls.Add(this.cbTasks);
            this.flowLeft.Controls.Add(this.button2);
            resources.ApplyResources(this.flowLeft, "flowLeft");
            this.flowLeft.Name = "flowLeft";
            // 
            // cbTasks
            // 
            this.cbTasks.FormattingEnabled = true;
            this.cbTasks.Items.AddRange(new object[] {
            resources.GetString("cbTasks.Items"),
            resources.GetString("cbTasks.Items1"),
            resources.GetString("cbTasks.Items2"),
            resources.GetString("cbTasks.Items3")});
            resources.ApplyResources(this.cbTasks, "cbTasks");
            this.cbTasks.Name = "cbTasks";
            this.cbTasks.SelectedIndexChanged += new System.EventHandler(this.cbTasks_SelectedIndexChanged);
            // 
            // button2
            // 
            resources.ApplyResources(this.button2, "button2");
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLeft);
            this.Controls.Add(this.flowMain);
            this.Controls.Add(this.flowTop);
            this.Name = "FormMain";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.flowMain.ResumeLayout(false);
            this.flowLeft.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowTop;
        private System.Windows.Forms.FlowLayoutPanel flowMain;
        private System.Windows.Forms.MonthCalendar calendar;
        private System.Windows.Forms.FlowLayoutPanel flowLeft;
        private System.Windows.Forms.CheckedListBox cbTasks;
        private System.Windows.Forms.Button button2;
    }
}

