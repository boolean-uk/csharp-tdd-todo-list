using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class ToDoTask

    {
        string name=" ";
        static int idCounter = 0;
        int id;
        string status;

        public ToDoTask()
        {
            status = "incomplete";
            id = idCounter;
            idCounter++;

        }
        public int Id
        {
            get { return id; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }
    } 
}
