using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class Task
    {
        public string _name;
        public bool _status;
        public int _id;
        public Task(string Name, bool Status, int Id)
        {
            _name = Name;
            _status = Status;
            _id = Id;
        }
    }
    public class TodoList
    {
        public List<Task> toDo = new List<Task>();
        public bool addTask(string name, int id)
        {
            foreach (var task in toDo)
            {
                if (id == task._id)
                {
                    Console.WriteLine("Task Id already exists!");
                    return false;
                }
            }
            Task tempTask = new Task(name, false, id);
            toDo.Add(tempTask);
            return true;
        }
        public bool removeTaskById(int id)
        {
            foreach(var task in toDo)
            {
                if (id == task._id)
                {
                    toDo.Remove(task);
                    return true;
                }
            }
            return false;
        }
        public List<int> SeeTasks()
        {
            List<int> result = new List<int>();
            Console.WriteLine("All tasks:");
            foreach(var task in toDo)
            {
                Console.WriteLine($"{task._name}\t");
                result.Add(task._id);
            }
            return result;
        }
        public List<int> SeeCompleteTasks()
        {
            List<int> result = new List<int>();
            Console.WriteLine("Complete tasks:");
            foreach (var task in toDo)
            {
                if (task._status == true)
                {
                    Console.WriteLine($"{task._name}\t");
                    result.Add(task._id);
                }
            }
            return result;
        }
        public List<int> SeeIncompleteTasks()
        {
            List<int> result = new List<int>();
            Console.WriteLine("Incomplete tasks:");
            foreach (var task in toDo)
            {
                if (task._status == false)
                {
                    Console.WriteLine($"{task._name}\t");
                    result.Add(task._id);
                }
            }
            return result;
        }
        public bool searchTask(string name)
        {
            string tempName;
            name = name.ToLower().Trim();
            foreach(var task in toDo)
            {
                tempName = task._name.ToLower().Trim();
                if(tempName == name)
                {
                    return true;
                }
            }
            Console.WriteLine("This task does not exist!");
            return false;
        }
        public bool completeTask(int id)
        {
            foreach (var task in toDo)
            {
                if (id == task._id)
                {
                    task._status = true;
                    return true;
                }
            }
            return false;
        }
        public List<string> printAlphabetical()
        {
            List<string> tempList = new List<string>();
            foreach (var task in toDo)
            {
                tempList.Add(task._name);
            }
            tempList.Sort();
            foreach (var task in tempList)
            {
                Console.WriteLine(task);
            }
            return tempList;
        }
        public List<string> printAlphabeticalRev()
        {
            List<string> tempList = new List<string>();
            foreach (var task in toDo)
            {
                tempList.Add(task._name);
            }
            tempList.Sort();
            for (int i = tempList.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(tempList.ElementAt(i));
            }
            return tempList;
        }
    }
}
