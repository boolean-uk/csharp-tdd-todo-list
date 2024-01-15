using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {
        List<Task> _toDoList;
        public TodoListExtension() 
        {
            _toDoList = new List<Task>();
            _toDoList.Add(new Task(1, "Laundry", true));
            _toDoList.Add(new Task(10101, "Hoovering", false));
            _toDoList.Add(new Task(10, "Dishes", false));

        }
        public bool idTask(int i)
        {
            Console.WriteLine("\nFind: Part where name contains \"seat\": {0}",
                _toDoList.Find(x => x.Id == i));
            return _toDoList.Exists(x => x.Id == i);
        }

        public bool updateNameByID(int i, string s)
        {
            if (_toDoList.Exists(x => x.Id == i))
            {
                _toDoList.Find(x => x.Id == i).TaskName = s;
                return true;
            }
            return false;
        }

        public bool updateStatusByID(int i)
        {
            if (_toDoList.Exists(x => x.Id == i))
            {
                _toDoList.Find(x => x.Id == i).Status = !_toDoList.Find(x => x.Id == i).Status;
                return _toDoList.Find(x => x.Id == i).Status;
            }
            return false;
        }

        public bool dates()
        {
            foreach (var item in _toDoList)
            {
                Console.WriteLine($"ID: {item.Id} Task: \"{item.TaskName}\", Complete?: {item.Status} Date added: {item.Created}");
            }
            bool test = _toDoList[0].Created.Minute == DateTime.Now.Minute;
            return test;
        }

    }

    public class Task
    {
        private int _id;
        private string _task;
        private bool _status;
        private static DateTime _created = DateTime.Now;

        public int Id { get { return _id; }}
        public string TaskName { get { return _task;} set { _task = value; } }
        public bool Status { get { return _status; } set { _status = value; } }
        public DateTime Created { get { return _created; }}

        public Task(int id, string task, bool status) 
        {
            _id = id;
            _task = task;
            _status = status;
        }

    }
}
