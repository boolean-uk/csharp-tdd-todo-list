using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class Task
{
        private static int _counter = 0; 
        public int _id;
        public string _name { get; set; }
        public bool _status { get; set; }

        // Makes sure each Object gets a unique Id, starting with 1.
        public Task(string name)
        {
            _counter++;
            this._id = _counter;
            this._name = name;
            this._status = false;
        }

        public static void ResetCounter()
        {
            _counter = 0;
        }
    }
}
