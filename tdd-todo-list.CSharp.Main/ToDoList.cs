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

        public void Add(string task)
        {
            _IDCOUNTER++;

            ToDoTask newTask = new ToDoTask(task, _IDCOUNTER);

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
                    if (task.getStatus()) { completed.Add(task); }
            }
            return completed;
        }

        public List<ToDoTask> ViewIncompleted()
        {
            List<ToDoTask> incompleted = new List<ToDoTask>();
            foreach (var task in Todo.Values)
            {
                if (!task.getStatus()) { incompleted.Add(task); }
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
                if (t.getName() == task) { return true; }
            }
            return false;
        }

        public void Remove(int id)
        {
            Todo.Remove(id);
        }

        public List<string> ViewByPriority()
        {
            List<string> low = new List<string>();
            List<string> medium = new List<string>();
            List<string> High = new List<string>();

            foreach (var t in Todo.Values)
            {
                if (t.getPriority() == 0) { low.Add(t.getName()); }
                else if (t.getPriority() == 1) { medium.Add(t.getName()); }
                else { High.Add(t.getName()); }
            }

            return High.Concat(medium).Concat(low).ToList();
        }

        public List<string> ViewAlphabetical()
        {
            List<string> list = new List<string>();
            List<ToDoTask> toDoTasks = Todo.Values.ToList();
            foreach (var t in toDoTasks)
            {
                list.Add(t.getName());
            }

            list.Sort();
        return list;
        }

        public List<string> ViewDescendingAlphabetical()
        {
            List<string> list = new List<string>();
            List<ToDoTask> toDoTasks = Todo.Values.ToList();
            foreach (var t in toDoTasks)
            {
                list.Add(t.getName());
            }

            list.Sort();
            list.Reverse();
            
            return list;
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
                Todo[id].setName(newName);
            }
        }

        public void UpdateStatusById(int id, bool status)
        {
            if (IsPresent(id))
            {
                Todo[id].setStatus(status);
            }
        }


    }
}
