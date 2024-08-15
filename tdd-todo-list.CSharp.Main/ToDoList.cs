using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        private List<Job> _jobs = new List<Job>();
        public List<Job> Jobs { get { return _jobs; } }

        public bool AddToList(Job job)
        {
            if (job == null)
            {
                return false;
            }
            _jobs.Add(job);
            return true;
        }

        public bool PrintJobs(List<Job> jobs) 
        {
            return false;
        }
    }
}
