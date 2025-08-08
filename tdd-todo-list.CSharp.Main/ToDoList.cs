using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        private List<Task> _toDoList = new List<Task>();
        private int _amout_tasks = 0;
        private int _id = 0;
        
        
        public bool Add(string name)
        {
            Task task = new Task(name);
            _toDoList.Add(task);
            _amout_tasks++;
            task.Id = _id;
            _id++;
            return true;
        }

        public bool Remove(string name)
        {
            for (int i = 0; i < _amout_tasks; i++)
            {
                if (_toDoList[i].Name == name)
                {
                    _toDoList.Remove(_toDoList[i]);
                    _amout_tasks--;
                    return true;
                }
                else
                {
                    Console.WriteLine($"{name} is not a task in the to do list ://");
                    break;
                }
            }
            return false; 
        }

        public void ChangeStatus(string name)
        {
            for (int i = 0; i < _amout_tasks; i++)
            {
                if (_toDoList[i].Name == name)
                {
                    if (_toDoList[i].Status)
                    {
                        _toDoList[i].Status = false;
                        break;
                    }
                    else
                    {
                        _toDoList[i].Status = true;
                        break;
                    }
                }
            }
        }

        public TodoList CompleteTasks()
        {
            TodoList new_list = new TodoList();
            foreach (Task t in _toDoList) 
            {
                if (t.Status)
                {
                    new_list.Add(t.Name);
                }
            }
            return new_list;
        }

        public TodoList IncompleteTasks()
        {
            TodoList new_list = new TodoList();
            foreach (Task t in _toDoList)
            {
                if (!t.Status)
                {
                    new_list.Add(t.Name);
                }
            }
            return new_list;
        }

        public bool Search(string name)
        {
            foreach (Task t in _toDoList)
            {
                if (t.Name == name)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine($"{name} is not a task in the to do list ://");
                    break;
                }
            }
            return false;
        }

        public TodoList AlphabetA()
        {
            TodoList sorted = new TodoList();
            List<string> tasks = new List<string>();
            foreach(Task t in _toDoList)
            {
                tasks.Add(t.Name);
            }
            tasks.Sort();

            foreach (String s in tasks)
            {
                sorted.Add(s);
            }

            return sorted; 
        }
        public TodoList AlphabetD()
        {
            TodoList sorted = new TodoList();
            List<string> tasks = new List<string>();
            foreach (Task t in _toDoList)
            {
                tasks.Add(t.Name);
            }
            tasks.Sort();
            tasks.Reverse();

            foreach (String s in tasks)
            {   
                sorted.Add(s);
            }

            return sorted;
        }

        public bool Prioritise(string name, Priority prio)
        {
            foreach(Task t in _toDoList)
            {
                if (t.Name == name)
                {
                    t.Priority = prio;
                    return true;
                }
            }
            return false; 

        }

        public List<Task> SeeTaskByPriority()
        {
           return _toDoList.OrderBy(task => task.Priority).ToList();
        }

        public List<Task> ToDoList
        {
            get { return _toDoList; }
        }

        public int Amout_tasks
        {
            get { return _amout_tasks;  }
        }
    }
}