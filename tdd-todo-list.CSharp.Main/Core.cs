using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
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
                _totalTasks += 1;
                return true;
            }
            return false;
        }

        public int GetAllTasks()
        {
            foreach (var task in tasks)
            {
                Console.WriteLine($"Id: {task.Item1} Text: {task.Item2} Completed: {task.Item3}");
            }
            return tasks.Count();
        }

        public bool UpdateStatus(int id, bool changeStatus)
        {
            Tuple<int, string, bool> existingTask = tasks.FirstOrDefault(task => task.Item1 == id);
            if (existingTask != null)
            {
                Tuple<int, string, bool> updatedTask = new Tuple<int, string, bool>(id, existingTask.Item2, changeStatus);
                tasks.Remove(existingTask);
                tasks.Add(updatedTask);
                return true;
            }
            return false;
        }

        public int GetCompletedTasks()
        {
            int count = 0;
            foreach(var task in tasks)
            {
                if(task.Item3 == true)
                {
                    count += 1;
                }
            }
            return count;
        }

        public int GetIncompletedTasks()
        {
            int count = 0;
            foreach (var task in tasks)
            {
                if (task.Item3 == false)
                {
                    count += 1;   
                }
            }
            return count;
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
            return "Task not found";
        }

        public bool RemoveTask(int id)
        {
            Tuple<int, string, bool> toBeRemoved = tasks.FirstOrDefault(task => task.Item1 == id);
            if (toBeRemoved != null)
            {
                tasks.Remove(toBeRemoved);
                _totalTasks -= 1;
                return true;
            }
            return false;
        }

        public List<Tuple<int, string, bool>> OrderedAlphabeticallyInAscending()
        {
            List<Tuple<int, string, bool>> orderedTasks = tasks.OrderBy(x => x.Item2).ToList();
            return orderedTasks;
        }

        public List<Tuple<int, string, bool>> OrderedAlphabeticallyInDecending()
        {
            List<Tuple<int, string, bool>> orderedTasks = tasks.OrderByDescending(x => x.Item2).ToList();
            return orderedTasks;
        }

        public List<Tuple<int, string, bool>> GetATask(int id)
        {
            List<Tuple<int, string, bool>> listWithSpecificTask = new List<Tuple<int, string, bool>>();
            Tuple<int, string, bool> specificTask = tasks.FirstOrDefault(task => task.Item1 == id);
            if (specificTask != null)
            {
                listWithSpecificTask.Add(specificTask);
                return listWithSpecificTask;
            }
            return listWithSpecificTask;
           
        }

        public bool UpdateName(int id, string name)
        {
            Tuple<int, string, bool> existingTask = tasks.FirstOrDefault(task => task.Item1 == id);
            if (existingTask != null)
            {
                Tuple<int, string, bool> updatedTask = new Tuple<int, string, bool>(id, name, existingTask.Item3);
                tasks.Remove(existingTask);
                tasks.Add(updatedTask);
                return true;
            }
            return false;
        }

    }
}
