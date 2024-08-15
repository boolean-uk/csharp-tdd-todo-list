using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{

    public enum Status
    {
        COMPLETE,
        INCOMPLETE
    }
    public class Job
    {
        private int id;
        private string name;
        private Status status;
        private DateTime date;

        public Job(int id, string name, Status status, DateTime date)
        {
            this.id = id;
            this.name = name;
            this.status = status;
            this.date = date;
        }

        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value;  } }
        public Status Status { get { return status; } set { status = value; } }
        public DateTime Date { get { return date; } set { date = value; } }
    }
}
