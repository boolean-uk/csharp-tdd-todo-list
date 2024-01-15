using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {
        private List<ToDoTask> _tasks = new List<ToDoTask>();

        public List<ToDoTask> Tasks { get { return _tasks; } set { _tasks = value; } }

        public void Add(int id, string name)
        {
            ToDoTask newTask = new ToDoTask(id, name);
            Tasks.Add(newTask);
        }

        public string getCreationTime(int id)
        {
            string date = "01.01.2000 00:00:00";
            foreach (var task in Tasks)
            {
                if (task.TaskID == id)
                {
                    date = task.Created.ToString();
                }
            }
            return date;
        }

        public ToDoTask getTaskByID(int id)
        {
            ToDoTask returnedTask = new ToDoTask(0, "not found");
            foreach (var task in Tasks)
            {
                if (task.TaskID == id)
                {
                    returnedTask = task;
                }
            }
            return returnedTask;
        }

        public bool setStatusByID(int id, bool isCompleted)
        {
            bool statusChanged = false;
            ToDoTask returnedTask = new ToDoTask(0, "not found");
            foreach (var task in Tasks)
            {
                if (task.TaskID == id)
                {
                    task.IsCompleted = isCompleted;
                    statusChanged = true;
                }
            }
            return statusChanged;
        }

        public string updateName(int id, string newName)
        {
            string name = "noname";
            foreach (var task in Tasks)
            {
                if (task.TaskID == id)
                {
                    task.TaskName = newName;
                    name = task.TaskName;
                }
            }
            return name;
        }
    }


    public class ToDoTask
    {
        //private static int _idCounter; This sadly did not work :C I wanted it to automatically iterate
        private int _taskID;
        private string _taskName;
        private bool _isCompleted;
        private DateTime _created = new DateTime();

        //public static int IDCounter { get { return _idCounter; } set { _idCounter = value; } }
        public int TaskID { get { return _taskID; } set { _taskID = value; } }
        public string TaskName { get { return _taskName; } set { _taskName = value; } }
        public bool IsCompleted { get { return _isCompleted; } set { _isCompleted = value; } }
        public DateTime Created { get { return _created; } set { _created = value; } }

        public ToDoTask(int id, string taskName)
        {
            //TaskID = ++IDCounter;
            TaskID = id; //I have to manually set the ID (boring!)
            TaskName = taskName;
            IsCompleted = false;
            Created = DateTime.Now;
        }
    }
}
