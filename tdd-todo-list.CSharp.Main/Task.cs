using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class Task
    {
        private string _name;
        private int _id;
        private bool isCompleted = false;
        private string priority = "low";
        private string category = String.Empty;
        private DateTime timeCreated;
        private DateTime timeCompleted;

        public Task(int count, string name)
        {
            _id = count;
            _name = name;
        }

        public string Name { get { return _name; } }
        public int ID { get { return _id; } }
    }
}
