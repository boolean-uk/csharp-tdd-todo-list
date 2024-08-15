using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using tdd_todo_Slist.CSharp.Main;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {

        List<Job> todoList = new List<Job>();
        
        public int Count { get { return todoList.Count; } }

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

        public Job getJobById(int jobId)
        {
            Job job = todoList.Where(x => x.Id == jobId).First();
            if (job == null)
            {
                return null;
            }

            return job;
        }

        public List<Job> getJobByStatus(Status status)
        {
            return todoList.Where(j => j.Status == status).ToList();
             
        }

        public bool removeJob(int jobId)
        {

            bool removed = true;
            Job job = todoList.Where(x => x.Id == jobId).First();
            if (job == null)
            {
                return !removed;
            }

            todoList.Remove(job);
            return removed;
        }

        public string searchJobByName(string name)
        {
            Job job = todoList.Find(x => x.Name.Equals(name));

            if (job == null)
            {
                return $"Job with name {name} not found!";
            }

            return $"Job with name {name} found!";
        }

        public Job updateJobName(int id, string v)
        {
            throw new NotImplementedException();
        }
    }
}
