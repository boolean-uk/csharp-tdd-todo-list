using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {
        public class Task
        {
            int _id;
            string _name;
            bool _completed;
            DateTime _created;

            public Task(int id, string name)
            {
                _id = id;
                _name = name;
                _completed = false;
                _created = DateTime.Now;
            }

            public int ID { get { return _id; } }
            public string Name { get { return _name; } set { _name = value; } }
            public bool Completed { get { return _completed; } set { _completed = value; } }
            public DateTime Created { get { return _created; } }

        }

        List<Task> tasks;
        int nrTasks;
        public TodoListExtension() 
        {
            tasks = new List<Task>();
            nrTasks = 0;
        }

        public List<Task> Tasks { get { return tasks; } }

        public void Add(string name)
        {
            Tasks.Add(new Task(nrTasks, name));
        }

        public Task GetByID(int id)
        {
            foreach (Task task in Tasks)
            {
                if (task.ID == id)
                    return task;
            }
            throw new Exception("Task does not exist");
        }

        public void Update(int id, string name)
        {
            foreach (Task task in Tasks)
            {
                if (task.ID == id)
                {
                    task.Name = name;
                    return;
                }
            }
            throw new Exception("Task does not exist");
        }

        public void ChangeStatus(int id)
        {
            foreach (Task task in Tasks)
            {
                if (task.ID == id)
                {
                    task.Completed = !task.Completed;
                    return;
                }
            }
            throw new Exception("Task does not exist");
        }

    }
}
