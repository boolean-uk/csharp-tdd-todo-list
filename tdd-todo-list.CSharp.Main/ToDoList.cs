using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_todo_Slist.CSharp.Main;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        List<Job> todoList = new List<Job>();

        public bool addJob(Job job)
        {
            bool added = true;

            foreach (var exJob in todoList)
            {
                if (job.Id == exJob.Id)
                {
                    Console.WriteLine("This job already exists");
                    return !added;
                }
            }
                todoList.Add(job);
                return added;
        }

        public bool changeJobStatus(int jobId)
        {
            bool changed = true;

            // Job job = todoList.Find(x => x.Id == jobId);
            Job job = todoList.Where(x => x.Id == jobId).First();

            if (job == null)
            {
                changed = false;
            }

            if (job.Status == Status.INCOMPLETE)
            {
                job.Status = Status.COMPLETE;
                Console.WriteLine(job.Status);
                return changed;
            } 
            else 
            { 
                job.Status = Status.INCOMPLETE;
                Console.WriteLine(job.Status);
                return changed;
            }
        }

        public List<Job> getAllJobs()
        {
            foreach (var job in todoList)
            {
                Console.WriteLine($"job: {job.Id}, name: {job.Name}, Status: {job.Status}, Date: {job.Date}");
            }

            return todoList;
        }
    }
}
