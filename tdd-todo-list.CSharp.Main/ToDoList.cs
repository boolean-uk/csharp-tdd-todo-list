using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        public Dictionary<string, int> todo;

        public TodoList()
        {
            todo = new Dictionary<string, int>();
        }

        public void AddTasks(string taskName, int status)
        {
            todo.Add(taskName, status);
        }

        public string PrintList()
        {
            string tasks = "";

            for (int i = 0; i < todo.Count(); i++)
            {
                tasks += todo.ElementAt(i).Key;
                tasks += " ";
            }

            return tasks;
        }

        public bool CompleteTask(string taskName, int status)
        {
            if (status != 0 && status != 1)
                return false;

            if (!todo.ContainsKey(taskName))
                return false;

            todo[taskName] = status;
            return true;
        }

        public string CompleteTasks()
        {
            string tasks = "";

            for (int i = 0; i < todo.Count(); i++)
            {
                if (todo.ElementAt(i).Value == 1)
                {
                    tasks += todo.ElementAt(i).Key;
                    tasks += " ";
                }
            }

            return tasks;
        }

        public string IncompleteTasks()
        {
            string tasks = "";

            for (int i = 0; i < todo.Count(); i++)
            {
                if (todo.ElementAt(i).Value == 0)
                {
                    tasks += todo.ElementAt(i).Key;
                    tasks += " ";
                }
            }

            return tasks;
        }

        public string TaskExists(string taskName)
        {
            string message = "";

            if (todo.ContainsKey(taskName))
                message = "Exists";
            else
                message = "Do not exist";

            return message;
        }

        public bool RemovedTask(string taskName)
        {
            if (!todo.ContainsKey(taskName))
                return false;

            todo.Remove(taskName);
            return true;
        }

        public string Alfabetically()
        {
            string sequence = "";
            Dictionary<string, int> sorted = new Dictionary<string, int>();

            sorted = todo.OrderBy(obj => obj.Key).ToDictionary(obj => obj.Key, obj => obj.Value);

            for (int i = 0; i < sorted.Count(); i++)
            {
                sequence += sorted.ElementAt(i).Key;
                sequence += " ";
            }

            return sequence;
        }

        public string BackwardsAlfabet()
        {
            string sequence = "";
            Dictionary<string, int> sorted = new Dictionary<string, int>();

            sorted = todo.OrderBy(obj => obj.Key).ToDictionary(obj => obj.Key, obj => obj.Value);

            for (int i = sorted.Count() - 1; i >= 0; i--)
            {
                sequence += sorted.ElementAt(i).Key;
                sequence += " ";
            }

            return sequence;
        }
    }
}
