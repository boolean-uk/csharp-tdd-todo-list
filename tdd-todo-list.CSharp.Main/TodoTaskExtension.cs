using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoTaskExtension
    {
        private int _id;
        private string _name;
        private bool _status;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public bool Status
        {
            get { return _status; }
            set { _status = value; }

        }
        public TodoTaskExtension(string name)
        { 
            _name = name;
        }

        public TodoTaskExtension(string name, int id)
        {
            this._id = id;
            this._name = name;
        }
        public TodoTaskExtension(string name, int id, bool status)
        {
            this._name = name;
            this._status = status;
            this._id = id;
        }


    }
}
