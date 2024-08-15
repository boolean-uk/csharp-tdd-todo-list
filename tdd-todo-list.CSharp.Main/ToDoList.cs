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
            foreach (var existingJob in jobs)
            {
                if (existingJob.Id == job.Id)
                {
                    Console.WriteLine("job already exists!");
                    return false;
                }
            }
            jobs.Add(job);
            return true;
        }

        public void changeStatus(int id)
        {
            Job job = getJob(id);
            if (job == null)
            {
                Console.WriteLine($"Job {id} was not found.");
                return;
            }
            Console.WriteLine(job.Status.ToString());
            
            if (job.Status == Status.COMPLETE)
            {
                job.Status = Status.INCOMPLETE;
            }
            else if (job.Status == Status.INCOMPLETE)
            {
                job.Status = Status.COMPLETE;
            }
            Console.WriteLine($"Job {id}'s status was changed to {job.Status.ToString()}");

        }

        public Job getJob(int id)
        {
            foreach (var job in jobs)
            {
                if (job.Id == id)
                {
                    Console.WriteLine("job found!");
                    return job;
                }
            }
            Console.WriteLine("job not found");
            return null;

        }

        public List<Job> getSpecifiedJobs(Status status)
        {
            List<Job> newJobs = new List<Job>();
            foreach(var job in jobs)
            {
                if (status.Equals(job.Status))
                {
                    newJobs.Add(job);
                }
            }

            return newJobs;
        }

        public bool removeJob(int id)
        {
            foreach (var existingJob in jobs)
            {
                if (existingJob.Id == id)
                {
                    Console.WriteLine("job removed!");
                    jobs.Remove(existingJob);
                    return true;
                }
            }
            Console.WriteLine("Job didnt exist");
            return false;
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
