using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{

    
    public class TodoList
    {
        private Dictionary<int, TaskEntry> _tasks = new Dictionary<int, TaskEntry>();         
        public int NrOfTasks { get => _tasks.Count; }

        private IComparer<TaskEntry> _orderComparable = TaskEntry.get_SortByDate();
        public TodoList() { }
        
        private static int _uniqueId = -1;
        private static int getUniqueId()
        {
            return ++_uniqueId;
        }


        public int AddTask(string taskName)
        {
            int uniqueId = TodoList.getUniqueId();
            TaskEntry newTask = new TaskEntry(taskName, uniqueId);
            _tasks.Add(uniqueId, newTask);

            return uniqueId;
            
        }
        public TaskEntry? GetTask(int taskId)
        {
            
            if(this._tasks.ContainsKey(taskId))
                return this._tasks[taskId];

            return null;
            
        }
        public void RemoveTask(int taskId)
        {
            
            if(!this._tasks.ContainsKey(taskId))
                return;

            this._tasks.Remove(taskId);
            
        }
        public void EditTaskName(int taskId, string newName)
        {
            
            if(!this._tasks.ContainsKey(taskId))
                return;

            this._tasks[taskId].Name = newName;
            
        }
        public void ToggleTaskCompletion(int taskId)
        {
            this._tasks[taskId].Completed = !this._tasks[taskId].Completed;
        }
        
        public List<TaskEntry> SearchTask(string searchTerm)
        {
            return this._tasks.ToList().Where(x => x.Value.Name.Contains(searchTerm)).Select(x=> x.Value).ToList();
        }

        public void SetTaskOrder_Ascending() {
            this._orderComparable = TaskEntry.get_SortByName_ascending();
        }
        public void SetTaskOrder_Descending() {
            this._orderComparable = TaskEntry.get_SortByName_descending();
        }
        public void SetTaskOrder_asAdded() {
            this._orderComparable = TaskEntry.get_SortByDate();
        }

        public List<TaskEntry> GetTaskList_all()
        {
            return this._tasks.Values.Order(_orderComparable).ToList();
        }
        public List<TaskEntry> GetTaskList_completed()
        {
            
            return this._tasks.Values.ToList().Where(x =>  x.Completed).Order(_orderComparable).ToList();
        }
        public List<TaskEntry> GetTaskList_incompleted()
        {
            return this._tasks.Values.ToList().Where(x => !x.Completed).Order(_orderComparable).ToList();
        }

    }
}
