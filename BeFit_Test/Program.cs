using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFit_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StartTaskAsync();
            Console.ReadLine();
        }
        private static async Task StartTaskAsync()
        {
            var taskManager = new TaskManager();

            taskManager.AddTask(() => { Console.WriteLine("Задача 1"); });
            taskManager.AddTask(() => { Console.WriteLine("Задача 2"); });
            taskManager.AddTask(() => { Console.WriteLine("Задача 3"); });

            await taskManager.ProcessTasksAsync();

            await taskManager.WaitAllTasksAsync();
        }
    }
}
