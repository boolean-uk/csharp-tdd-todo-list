using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class ExtensionTask
    {
        public int id;
        public string name;
        public bool isComplete = false;
        public DateTime timestamp;


        public ExtensionTask(string name) {
            this.name = name;
            this.timestamp = DateTime.Now;
        }

        public ExtensionTask(string name, bool isComplete)
        {
            this.name = name;
            this.isComplete = isComplete;
            this.timestamp = DateTime.Now;
        }
    }

    public class TodoListExtension
    {
        public List<ExtensionTask> tasks;

        public TodoListExtension()
        {
            this.tasks = new List<ExtensionTask>();
        }

        public void AddTask(ExtensionTask task)
        {
            task.id = tasks.Count;
            tasks.Add(task);
        }

        public ExtensionTask getTaskById(int id)
        {
            return tasks[id];
        }

        public void updateNameById(int id, string str)
        {
            tasks[id].name = str;
        }

        public void changeStatusById(int id)
        {
            tasks[id].isComplete = !tasks[id].isComplete;
        }

        public string seeDateTimeOfCreation(int id)
        {
            return "The task was created on " + tasks[id].timestamp.ToString("MMMM dd, yyyy H:mm:ss");
        }
    }
}
