using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        //public Dictionary<string, bool> todoList = new Dictionary<string, bool>();
        public List<pTask> todoList = new List<pTask>();
        
        public TodoList() { }

        public bool addTask(string task)
        {
            //Check if name exists, if there is no duplicate, add it
            if (!todoList.Any(item => item.ptask == task)) {
                todoList.Add(new pTask() {ptask=task,isComplete=false });
                return true; 
            }
            return false;
        }
        public List<pTask> getList()
        {
            
            return todoList.ToList();
            
        }
        public bool editTask(string task,bool status) 
        {
            pTask t = todoList.FirstOrDefault(item => item.ptask == task);
            if (t != null) 
            {
                t.isComplete = status;
                return true;
            }
            return false;
        }
        public List<pTask> getCompleted()
        {
            return todoList.Where(t=> t.isComplete==true).ToList();
        }

    }
}
