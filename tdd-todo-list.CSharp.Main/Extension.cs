using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension : TodoList
    {
        private Dictionary<string, (int ID, DateTime time)> taskToInfo = new Dictionary<string, (int, DateTime)>();
        private int counter = 0;

        public TodoListExtension() : base() { }

        public void addTask( string v ) {
            base.addTask(v);
            taskToInfo.Add(v, (counter++, DateTime.Now));
        }

        public void addTask ( string v, (int ID, DateTime time) transfer)
        {
            base.addTask(v);
            taskToInfo.Add(v, transfer);
        }

        public void removeTask(string v){
            base.removeTask(v);
            taskToInfo.Remove(v);
        }

        public int getID(string v)
        {
            return taskToInfo[v].ID;
        }

        public string getTaskByID(int ID)
        {
            return taskToInfo.FirstOrDefault(x => x.Value.ID == ID).Key;
        }

        public void updateName(int iD, string v)
        {
            string oldName = getTaskByID(iD);
            (int, DateTime) transfer = taskToInfo[oldName];
            removeTask(oldName);
            addTask(v, transfer);
        }

        public void updateStatus(int iD)
        {
            string task = getTaskByID(iD);
            base.changeStatus(task);
        }

        public string whenCreated(int ID)
        {
            string name = getTaskByID(ID);
            return $"This task was created {taskToInfo[name].time.ToString("de-DE")}";
        }
    }
}
