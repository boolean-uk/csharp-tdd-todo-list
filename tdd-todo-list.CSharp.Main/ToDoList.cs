using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{

    public class TodoObject
    {
        private readonly int id;
        public string TaskStr { get; set; } = " ";
        public string Priority { get; set; } = " ";
        public bool Completed { get; set; } = false;
        public DateTime CompleteDate { get; set; }

        public TodoObject(int id, string taskStr) 
        {
            this.id = id;
            this.TaskStr = taskStr;
        }

        public TodoObject(int id,string taskStr, string priority)
        {
            this.id = id;
            this.TaskStr = taskStr;
            this.Priority = priority;
        }
    }

    public class TodoList
    {
        private int _UNIQUE_IDS = 0;
        public Dictionary<int, TodoObject> Todo = new Dictionary<int, TodoObject>();

        public void Add(string task)
        {
            TodoObject newTask = new TodoObject(_UNIQUE_IDS, task);
            Todo[_UNIQUE_IDS] = newTask;
            _UNIQUE_IDS++;
        }

        public List<TodoObject> GetAllTasks() 
        {
            return Todo.Values.ToList();
        }

        public List<string> GetAllStringTasks()
        {
            List<string> tasks = new List<string>();
            foreach (TodoObject task in Todo.Values)
            {
                tasks.Add(task.TaskStr);
            }
            return tasks;
        }

        public List<TodoObject> GetAllCompleteTasks(bool complete = true)
        {
            List<TodoObject> completedTasks = new List<TodoObject>();
            foreach (TodoObject task in Todo.Values)
            {
                if (task.Completed == complete) { 
                    completedTasks.Add(task);
                }
            }
            return completedTasks;
        }

        public List<TodoObject> GetAllIncompleteTasks()
        {
            List<TodoObject> incompletedTasks = GetAllCompleteTasks(false);
            return incompletedTasks;
        }

        public bool SearchFor(string searchTask)
        {
            bool foundTask = false;
            foreach (TodoObject task in Todo.Values)
            {
                if (task.TaskStr == searchTask)
                {
                    foundTask = true;
                }
            }
            return foundTask;
        }

        public void Remove(int id)
        {
            Todo.Remove(id);
        }

        public List<TodoObject> OrderList(bool ascending = true)
        {
            if (ascending)
            {
                List<TodoObject> sortedList = Todo.Values.OrderBy(o => o.TaskStr).ToList();
                return sortedList;

            }
            else
            {
                List<TodoObject> sortedList = Todo.Values.OrderByDescending(o => o.TaskStr).ToList();
                return sortedList;
            }
        }

        public void PrioritiseTask(int id, string priority)
        {
            Todo[id].Priority = priority;
        }

        public List<TodoObject> GetPriority(string priority)
        {
            List<TodoObject> priorityTasks = new List<TodoObject>();
            foreach (TodoObject task in Todo.Values)
            {
                if (task.Priority == priority)
                {
                    priorityTasks.Add(task);
                }
            }
            return priorityTasks;
        }
    }
}
