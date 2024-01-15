using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{

    public struct Task
    {
        public string Name { get; set; }
        public bool IsCompleted { get; set; }

        public Task(string name)
        {
            Name = name;
            IsCompleted = false;
        }

    }
    public class TodoList
    {
        public List<Task> Tasks { get; set; }

        public TodoList() 
        {
            Tasks = new List<Task>();
        }

        public bool addTask(string taskName)
        {

            Tasks.Add(new Task(taskName));


            return true;
        }

        public string viewTasks()
        {
            string result = "";

            foreach (Task task in Tasks) 
            { 
                result = result + task.Name+"," + task.IsCompleted.ToString() + ",";
            }

            if(result.Length > 0)
            {
                result = result.Substring(0, result.Length - 1);
            }


            return result;
        }
        public bool switchStatus(string taskName)
        {
            Task temp = new Task(taskName);
            bool result = false;
            if(Tasks.Contains(temp) == true)
            {
                Tasks.Remove(temp);
                temp.IsCompleted = true;
                Tasks.Add(temp);
                result = true;
            }
            return result;

        }
        public List<Task> onlyCompleted()
        {

            List<Task> complete = new List<Task>();

            foreach(Task task in Tasks)
            {
                if(task.IsCompleted == true)
                {
                    complete.Add(task);
                }
            }


            return complete;
        }
        public List<Task> onlyIncomplete()
        {
            List<Task> incomplete = new List<Task>();

            foreach (Task task in Tasks)
            {
                if (task.IsCompleted != true)
                {
                    incomplete.Add(task);
                }
            }

            return incomplete;
        }
        public string search(string taskName)
        {
            bool exists = Tasks.Contains(new Task(taskName));

            if(exists == true)
            {
                return "Task exists.";
            }else
            {
                return "Task does not exist.";
            }

        }
        public bool removeTask(string taskName)
        {
            if(Tasks.Contains(new Task(taskName)))
            {
                Tasks.Remove(new Task(taskName));
                return true;
            }
            else
            {
                return false;
            }
        }
        public string viewAlphabet()
        {
            string result = "";
          
            Tasks.Sort(delegate (Task x, Task y)
            {
                if (x.Name == null && y.Name == null) return 0;
                else if (x.Name == null) return -1;
                else if (y.Name == null) return 1;
                else return x.Name.CompareTo(y.Name);
            });

            foreach (Task task in Tasks)
            {
                result = result + task.Name + "," + task.IsCompleted.ToString() + ",";
            }

            if (result.Length > 0)
            {
                result = result.Substring(0, result.Length - 1);
            }

            return result;
        }
        public string viewDescend()
        {
            string result = "";

            Tasks.Sort(delegate (Task x, Task y)
            {
                if (x.Name == null && y.Name == null) return 0;
                else if (x.Name == null) return -1;
                else if (y.Name == null) return 1;
                else return x.Name.CompareTo(y.Name);
            });
            Tasks.Reverse();

            foreach (Task task in Tasks)
            {
                result = result + task.Name + "," + task.IsCompleted.ToString() + ",";
            }

            if (result.Length > 0)
            {
                result = result.Substring(0, result.Length - 1);
            }
            Console.WriteLine(result);
            return result;
        }


    }
}
