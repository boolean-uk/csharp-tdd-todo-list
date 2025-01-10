using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class Task
    {
        public string task;
        public bool isCompleted = false;
        private static int _currentId = 1;
        public int id;
        public DateTime createdAt;

        public Task() { }

        public Task(string task)
        {
            this.id = _currentId++;
            this.task = task;
            this.isCompleted = false;
            this.createdAt = DateTime.Now;
        }
        public Task (string task, bool isCompleted)
        {
            this.id = _currentId++;
            this.task = task;
            this.isCompleted = isCompleted;
            this.createdAt = DateTime.Now;
        }

        public override string ToString()
        {
            return task;
        }

        public static void ResetId()
        {
            _currentId = 1;
        }
    }
}
