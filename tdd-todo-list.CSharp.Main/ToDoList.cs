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
        public List<int> SeeTasks()
        {
            List<int> result = new List<int>();
            foreach(var task in toDo)
            {
                Console.WriteLine($"{task._name}\t");
                result.Add(task._id);
            }
            return result;
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
    }
}
