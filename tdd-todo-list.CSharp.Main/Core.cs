using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {

        public List<Tuple<int, string, bool>> tasks = new List<Tuple<int, string, bool>>();
        private int _totalTasks;


        public bool AddTask(string text, bool completed)
        {
            _totalTasks = tasks.Count();
            Tuple<int, string, bool> task = new Tuple<int, string, bool>(_totalTasks + 1, text, completed);
            tasks.Add(task);
            if (tasks.Count() > _totalTasks)
            {
                return true;
            }
            return false;
        }

        public void GetAllTasks()
        {
            foreach (var task in tasks)
            {
                Console.WriteLine($"Id: {task.Item1} Text: {task.Item2} Completed: {task.Item3}");
            }
        }

        public bool UpdateStatus(int id, bool changeStatus)
        {
            Tuple<int, string, bool> existingTask = tasks.FirstOrDefault(x => x.Item1 == id);
            if (existingTask != null)
            {
                Tuple<int, string, bool> updatedTask = new Tuple<int, string, bool>(id, existingTask.Item2, changeStatus);
                tasks.Remove(existingTask);
                tasks.Add(updatedTask);
                return true;
            }
            return false;
        }

        public void GetCompletedTasks()
        {
            foreach(var task in tasks)
            {
                if(task.Item3 == true)
                {
                    Console.WriteLine($"Id: {task.Item1} Text: {task.Item2} Completed: {task.Item3}");
                }
            }
        }

        public void GetIncompletedTasks()
        {
            foreach (var task in tasks)
            {
                if (task.Item3 == false)
                {
                    Console.WriteLine($"Id: {task.Item1} Text: {task.Item2} Completed: {task.Item3}");
                }
            }
        }

        public string SearchForATask(int id)
        {
            foreach (var task in tasks)
            {
                if (task.Item1 == id)
                {
                    return "Task found";
                }
            }
            return "Task wasn't found";
        }

        public void RemoveTask(int id)
        {
            foreach (var task in tasks)
            {
                if (task.Item1 == id)
                {
                    tasks.Remove(task);
                }
            }
        }

        /*
        // Dictionary is the above one which essentially is the task and the int is the id of each task
        public Dictionary<Dictionary<string, bool>, int> _tasks = new Dictionary<Dictionary<string, bool>, int>();

        public bool AddTask(string text, bool completed)
        {
            // string is the Text of the Task and bool is the completed field of the task
            Dictionary<string, bool> fieldsOfTask = new Dictionary<string, bool>();
            fieldsOfTask.Add(text, completed);
            _taskCount = _tasks.Count();
            _tasks.Add(fieldsOfTask, _taskCount + 1);
            
            if (_tasks.Count() > _taskCount)
            {
                return true;
            }
            return false;
        }

        public void GetAllTasks()
        {
            foreach (KeyValuePair<Dictionary<string, bool>, int> task in _tasks)
            {
                foreach (KeyValuePair<string, bool> kvp in task.Key)
                {
                    Console.WriteLine($"Id: {task.Key} Text: {kvp.Key} Completed: {kvp.Value}");
                }
            }
        }

        public void UpdateStatus(int id, bool complete)
        {
            Dictionary<Dictionary<string, bool>, int> existingTask = (Dictionary<Dictionary<string, bool>, int>) _tasks.Where(task => task.Value == id);

            if (existingTask != null)
            {
                foreach (KeyValuePair<Dictionary<string, bool>, int> task in existingTask)
                {
                    if (task.Value == id)
                    {
                        foreach (KeyValuePair<string, bool> kvp in task.Key)
                        {
                            Dictionary<Dictionary<string, bool>, int> updatedTask = new Dictionary<Dictionary<string, bool>, int>();
                            
                        }
                    }
                }
            }

            
        }*/
    }
}
