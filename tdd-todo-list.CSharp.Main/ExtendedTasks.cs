using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class ExtendedTasks : Tasks
    {
        private DateTime _datetime = DateTime.Now;
        private int _id;
        public DateTime datetime { get { return _datetime; } }// set { _datetime = value} }
        public int id { get { return _id; } }
        public ExtendedTasks(int id, string name) : base(name)
        {
            _id = id;
        }
    
    }
}
