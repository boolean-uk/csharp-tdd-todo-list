using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {
        public List<ToDoTask> taskList = new List<ToDoTask>();

        public void AddTask(int id, string name, bool status)
        {
            ToDoTask task = new ToDoTask(id, name, status);
            taskList.Add(task);
        }
        public string getTaskById(int id)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var task in taskList)
            {
                if (task.Equals(id))
                {
                    sb.Append(task.ToString());
                }
                else
                {
                    return "Not found";
                }
            }
            return sb.ToString();
            
        }
    }

    public class ToDoTask
    {
        public int _id { get; set; }
        public string _name { get; set; }
        public bool _completed { get; set; }

        public ToDoTask(int id, string name, bool status)
        {
            _id = id;
            _name = name;
            _completed = status;
        }
    }
}
