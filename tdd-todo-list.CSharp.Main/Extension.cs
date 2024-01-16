using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class ExtensionList
    {
        private List<ExtensionTask> _extensionTasks = new List<ExtensionTask>();
        public ExtensionList() { }
        public void AddTask(ExtensionTask taskA)
        {
            _extensionTasks.Add(taskA);
        }

        public ExtensionTask FindTAskByID(string v)
        {
            List<ExtensionTask> task = _extensionTasks.Where(t => t.ID() == v).ToList();
            if (task.Count == 0) { return task[0]; } //whatever
            else { return task[0]; }
        }

        public void UpdateCompletedByID(string v)
        {
            ExtensionTask task = FindTAskByID(v);
            task.ChangeCompleteStatus();

        }

        public void UpdateTaskNameByID(string v, string v1)
        {
            ExtensionTask task = FindTAskByID(v);
            task.Name(v1);
        }
    }
    public class ExtensionTask
    {
        private string _id;
        private string _name;
        private bool _completed;
        DateTime _created;

        public ExtensionTask(string id, string name)
        {
            _id = id;
            _name = name;
            _completed = false;
            _created = DateTime.Now;
        }

        public void ChangeCompleteStatus()
        {
            _completed = !_completed;
        }

        public DateTime GetDateTime()
        {
            return _created;
        }

        public string ID()
        {
            return _id;
        }

        public bool IsComplete()
        {
            return _completed;
        }

        public string Name() { return _name; }
        public void Name(string name) { _name = name; }
    }
}
