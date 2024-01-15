using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension : TodoList
    {
        public TodoListExtension() : base() {  }

        public int getID(string name)
        {
            throw new NotImplementedException();
        }

        public string getTaskByID(int iD)
        {
            throw new NotImplementedException();
        }

        public void updateName(int iD, string v)
        {
            throw new NotImplementedException();
        }

        public void updateStatus(int iD, string v)
        {
            throw new NotImplementedException();
        }

        public DateTime whenCreated(int iD)
        {
            throw new NotImplementedException();
        }
    }
}
