using NUnit.Framework.Constraints;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {

        public List<ExtensionTodoTask> _extensionTasks = new List<ExtensionTodoTask>();

        public TodoListExtension() 
        { 
        
        }

        public void Add(string description)
        {

            ExtensionTodoTask task = new ExtensionTodoTask(description, false);
            _extensionTasks.Add(task);
        }

        public ExtensionTodoTask getTaskWithID(Guid ID)
        {
                return _extensionTasks.Single(x => x._ID == ID);
        }

        public void UpdateItem(Guid ID, string new_description)
        {
            _extensionTasks.Where(x => x._ID == ID).ToList().ForEach(s => s._description = new_description);
        }

        public void UpdateTaskStatus(Guid ID, bool value)
        {
            _extensionTasks.Where(x => x._ID == ID).ToList().ForEach(s => s._done = value);
        }

        public DateTime GetTaskDateTimeByID(Guid ID)
        {
            DateTime dt = _extensionTasks.Where(x => x._ID == ID).ToList().Single().DateTime;
            return dt;
        }

        public Dictionary<string, DateTime> GetDateTimeDict() 
        {
            Dictionary<string, DateTime> res = new Dictionary<string, DateTime>();

            foreach (ExtensionTodoTask task in _extensionTasks)
            {
                res[task._description] = task.DateTime;
            }

            return res;
        }

    }

    public class ExtensionTodoTask
    {
        public string _description { get; set; }
        public bool _done { get; set; }

        public Guid _ID = Guid.NewGuid();

        public DateTime DateTime = DateTime.Now;

        public ExtensionTodoTask(string description, bool done)
        {
            _description = description;
            _done = done;

        }
    }
}
