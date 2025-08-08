using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        private int _IDCOUNTER = 0;
        public Dictionary<int, ToDoTask> Todo = new Dictionary<int, ToDoTask>();

        public void Add(string task, Type typeOfTask=Type.Standard)
        {
            _IDCOUNTER++;

            ToDoTask newTask = new ToDoTask(task, _IDCOUNTER, typeOfTask);

            Todo.Add(_IDCOUNTER, newTask);
        }

        public List<ToDoTask> ViewAll()
        {
            List<ToDoTask> tasks = new List<ToDoTask>();
            tasks = Todo.Values.ToList();

            return tasks;
        }

        public List<ToDoTask> ViewCompleted()
        {
            List<ToDoTask> completed = new List<ToDoTask>();
            foreach(var task in Todo.Values)
            {
                    if (task.Status) { completed.Add(task); }
            }
            return completed;
        }

        public List<ToDoTask> ViewIncompleted()
        {
            List<ToDoTask> incompleted = new List<ToDoTask>();
            foreach (var task in Todo.Values)
            {
                if (!task.Status) { incompleted.Add(task); }
            }
            return incompleted;
        }

        public bool IsPresent(int id)
        {
            if (Todo.ContainsKey(id)) {  return true; }
            return false;
        }
        public bool IsPresentName(string task)
        {
            foreach (var t in Todo.Values)
            {
                if (t.Name == task) { return true; }
            }
            return false;
        }

        public void Remove(int id)
        {
            Todo.Remove(id);
        }

        public List<ToDoTask> ViewByPriority()
        {
            return Todo.Values.OrderByDescending(t => t.getPriority()).ToList();
        }

        public List<ToDoTask> ViewAlphabetical()
        {
            List<ToDoTask> toDoTasks = Todo.Values.ToList();
            return toDoTasks.OrderBy(t => t.Name).ToList();
        }

        public List<ToDoTask> ViewDescendingAlphabetical()
        {
            List<ToDoTask> toDoTasks = Todo.Values.ToList();
            return toDoTasks.OrderByDescending(t => t.Name).ToList();
        }

        public ToDoTask getById(int id)
        {
            if (IsPresent(id))
            {
                return Todo[id];
            }
            else { return null; } 
        }

        public void UpdateById(int id, string newName)
        {
            if (IsPresent(id))
            {
                Todo[id].Name = newName;
            }
        }

        public void UpdateStatusById(int id, bool status)
        {
            if (IsPresent(id))
            {
                Todo[id].Status = status;
            }
        }

        public List<ToDoTask> ListAllByCategory()
        {
            return Todo.Values.OrderBy(t => t.TypeOfTask).ToList();
        }

        public ToDoTask LongestBeforeFinished()
        {
            return Todo.Values.OrderByDescending(t => t.TimeSpan).ToList()[0];
        }

        public ToDoTask ShortestBeforeFinished()
        {
            return Todo.Values.OrderBy(t => t.TimeSpan).ToList()[0];
        }
    }
}
