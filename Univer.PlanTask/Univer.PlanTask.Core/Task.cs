using System;
using Univer.PlanTask.Core.Store;

namespace Univer.PlanTask.Core
{
    public class Task : IEntity
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public int Day { get; set; }

        public DateTime Deadline { get; set; }

        public DateTime StarDate { get; set; }

        public int StartTimeHour { get; set; }


        public int StartTimeMin { get; set; }

        public TaskStatus Status { get; set; }

        public Task(string n, int s, int sm, int d, DateTime st, DateTime dt)
        {
            StarDate = st;
            Day = d;
            Deadline = dt;
            StartTimeHour = s;
            StartTimeMin = sm;
            Name = n;
            Id = 0;
            Status = new TaskStatus();
        }

        public Task()
        {
            StarDate = new DateTime();
            Day = 0;
            StartTimeHour = 0;
            StartTimeMin = 0;
            Deadline = new DateTime();
            Name = "";
            Id = 0;
            Status = new TaskStatus();
        }
    }
}
