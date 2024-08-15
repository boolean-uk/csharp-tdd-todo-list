using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {

        public List<Job> jobs = new List<Job>();
        public bool addJob(Job job)
        {
            if(jobs.Contains(job)) return false;
            jobs.Add(job);
            return true;
        }

        public List<Job> seeJobs()
        {
            foreach (var job in jobs) 
            { 
                Console.WriteLine($"job nr: {job.Id}, {job.Name}, {job.Status.ToString()}, {job.Date.ToString()}");
            }
            return jobs;
        }
    }
}
