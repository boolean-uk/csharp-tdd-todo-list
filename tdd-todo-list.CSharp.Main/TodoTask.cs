using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoTask
{
        private string _name { get; set; }
        private bool _completed;

        public string Name
        {
            get { return _name; }
            set { _name = value; }

        }
        private int _id { get; set; }

        public TodoTask(string name)
        {
        _name = name; 
        }

        public TodoTask(string name, bool completed) { 
        _name = name;
        _completed = completed;
  
        }



}
}
