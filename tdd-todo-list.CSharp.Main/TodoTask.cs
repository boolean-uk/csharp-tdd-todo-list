using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoTask
    {
        private int _id;
        private string _name;
        private bool _complete = false;
        private DateTime _created = DateTime.Now;
        public TodoTask(int id, string name)
        {
            _id = id;
            _name = name;
        }

        public int Id { get { return _id; } }
        public string Name { get { return _name; } set { _name = value; } }
        public DateTime Created { get { return _created; } }
        public bool Completed { get { return _complete; } set { _complete = value; } }
    }
}
