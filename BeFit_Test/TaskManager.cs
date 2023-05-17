using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeFit_Test
{
    public delegate void TaskDelegate();

    internal class TaskManager
    {
        private List<TaskDelegate> tasks;

        public TaskManager()
        {
            tasks = new List<TaskDelegate>();
        }

        public void AddTask(TaskDelegate task)
        {
            tasks.Add(task);
        }

        public async Task ProcessTasksAsync()
        {
            foreach (var task in tasks)
            {
                await Task.Run(() => task());
            }
        }

        public async Task WaitAllTasksAsync()
        {
            await Task.WhenAll(tasks.Select(task => Task.Run(() => task())));
        }
    }
}
