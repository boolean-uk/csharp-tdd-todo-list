using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension : TodoList
    {
        public List<Task> toDoList = new List<Task>();
        public List<Tuple<DateTime, int>> timeAdded = new List<Tuple<DateTime, int>>();
        public bool addTask(string name, int id)
        {
            foreach (var task in toDoList)
            {
                if (id == task._id)
                {
                    Console.WriteLine("Task Id already exists!");
                    return false;
                }
            }
            Task tempTask = new Task(name, false, id);
            toDoList.Add(tempTask);
            DateTime now = DateTime.Now;
            Tuple<DateTime, int> timestamp = new Tuple<DateTime, int>(now, id);
            timeAdded.Add(timestamp);
            return true;
        }
        public bool searchTaskById(int id)
        {
            foreach (var task in toDoList)
            {
                if (id == task._id)
                {
                    return true;
                }
            }
            Console.WriteLine("This task does not exist!");
            return false;
        }
        public string updateName(int id, string newName)
        {
            foreach (var task in toDoList)
            {
                if(id == task._id)
                {
                    task._name = newName;
                }
            }
            return newName;
        }
        public bool completeTask(int id)
        {
            foreach (var task in toDoList)
            {
                if (id == task._id)
                {
                    task._status = true;
                    return true;
                }
            }
            return false;
        }
        public void getTimeOf(int id)
        {
            string output = string.Empty;
            foreach(var task in timeAdded)
            {
                output = task.ToString();
                if (output.Contains(id.ToString()))
                {
                    Console.WriteLine(output);
                }
            }
        }
    }
}
