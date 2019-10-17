using System;
using Univer.PlanTask.Core.Store;

namespace Univer.PlanTask.Core
{
    public class Task : IEntity
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public DateTime Deadline { get; set; }

        public DateTime StartDate { get; set; }

        public int Status { get; set; }

        public Task(string n, DateTime st, DateTime dt, int s)
        {
            StartDate = st;
            Deadline = dt;
            Name = n;
            Id = 0;
            Status = s;
        }

        public Task()
        {
            StartDate = new DateTime();
            Deadline = new DateTime();
            Name = "";
            Id = 0;
            Status = 0;
        }
    }
}
