using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        private Dictionary<string, bool> _tasks = new Dictionary<string, bool>();

        public void AddTask(string task)
        {

            _tasks[task] = false;
            {
               


            }

        }

        public List<string> GetAllTasks()
        {
           return _tasks.Keys.ToList();
        }


        public bool GetTaskStatus(string taskDescription)
        {
            if(_tasks.ContainsKey(taskDescription)) {

                return _tasks[taskDescription];

        }   return false;


    }
        public void ChangeTaskStatus(string taskDescription)
        {
            if (_tasks.ContainsKey(taskDescription))
            {
                _tasks[taskDescription] = !_tasks[taskDescription]; 
            }
        }

        public List<string> GetCompletedTasks()

        {
            var completedTasks = new List<string>();
            foreach (var task in _tasks)
            {
                if (task.Value)
                {
                    completedTasks.Add(task.Key);

                }

            }

            return completedTasks;
        }

        public List<string> GetInCompletedTasks()

        {
            var incompletedTasks = new List<string>();
            foreach (var task in _tasks)
            {
                if (!task.Value)
                {
                    incompletedTasks.Add(task.Key);

                }

            }

            return incompletedTasks;
        }

        
        public string SearchTask(string taskDescription)
        {
            foreach (var task in _tasks)
            {
                if (task.Key==taskDescription) 
                {
                    return $"Task found: {task.Key}";  
                }
            }
            return "Task not found.";  
        }

        public string RemoveTask(string taskDescription)

        {
            if (!_tasks.ContainsKey(taskDescription))

            {
                return "Task not found";
            }

            {
                _tasks.Remove(taskDescription);

                return "successfully removed";
            }



        }
        public List<string> GetAllTasksAscending()
        {
            var taskDescriptions = new List<string>();

            foreach (var task in _tasks)
            { taskDescriptions.Add(task.Key);}

            taskDescriptions.Sort();

            return taskDescriptions;

        }

        public List<string> GetAllTasksDescending()

        {
            var taskDescriptions = new List<string>();

            foreach (var task in _tasks)
            { taskDescriptions.Add(task.Key); }

            taskDescriptions.Sort();
            taskDescriptions.Reverse();

            return taskDescriptions;


        }


    }

}
