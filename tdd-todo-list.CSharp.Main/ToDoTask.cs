using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class ToDoTask

    {
        string name = "";
  
        int id = 0;
        string status;
        DateTime now = DateTime.Now;

        public ToDoTask()
        {
            status = "incomplete";
            Console.WriteLine(now.ToString());


        }
        public int Id
        {
            get { return id; }
            set { id = value; }
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
