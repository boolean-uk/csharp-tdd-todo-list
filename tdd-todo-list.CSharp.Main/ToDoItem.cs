using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class ToDoItem
    {
        string name { get; set; }
        bool status { get { return status; } set { status = false; } }

        DateTime _creationDate;
        string _creationTime;


        public ToDoItem(string taskName) 
        {
            name = taskName;
        }

        public string RetrieveDateTime() 
        {
            throw new NotImplementedException();
        }
    }
}
