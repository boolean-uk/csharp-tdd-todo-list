using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class Task
    {
        private int _id;
        private string _name;
        private string _createdAt;
        private bool _completed;

        public string Name { get { return _name; } set { _name = value; } }
        public string CreatedAt { get { return _createdAt; } set { _createdAt = value; } }
        public bool Completed { get { return _completed; } set { _completed = value; } }

        public Task (int id, string name)
        {
            _id = id;
            _name = name;
            _createdAt = DateTime.Now.ToString("dddd, dd MMMM yyyy HH:mm:ss");
            _completed = false;
        }
    }
}
