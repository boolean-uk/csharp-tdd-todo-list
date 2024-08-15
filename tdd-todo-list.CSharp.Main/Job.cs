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
        public int Id { get; set; }
        public string Name { get; set; }
        public Status Status { get; set; }
        public DateTime Date { get; set; }


        public Job(int id, string name, Status status, DateTime date)
        {
            this.Id = id;
            this.Name = name;
            this.Status = status;
            this.Date = date;
        }

        
    }
}
