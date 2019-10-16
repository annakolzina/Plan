using System;
using Univer.PlanTask.Core;
using Univer.PlanTask.Core.Store;
using Univer.PlanTask.Core.Store.Impl;

namespace Univer.PlanTask.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            IBaseStore store = new FileStore<Task>();

            var task1 = new Task() { Id = 1, Name = "1" };
            var task2 = new Task() { Id = 2, Name = "2" };
            var task3 = new Task() { Id = 3, Name = "3" };
            
            store.Create(task1);
            store.Create(task2);
            store.Create(task3);

            var objs = store.GetAll();

            foreach (var item in objs)
            {
                Console.WriteLine(item.Id);
            }

            Console.ReadKey();
        }
    }
}
