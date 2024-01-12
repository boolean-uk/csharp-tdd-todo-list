using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TaskExtension
    {
        int id;
        string name;
        bool status;
        DateTime createdOn;

        public int ID { get { return id; } }
        public string Name { get { return name; } set { name = value; } }
        public bool Status { get { return status; } set { status = value; } }
        public DateTime CreatedOn { get { return createdOn; } }
        
        public TaskExtension(string name)
        {
            this.name = name;
            createdOn = DateTime.Now;
            status = false;
            id = IDGenerator.GetID();
            Console.WriteLine(id);
        }

    }
}
