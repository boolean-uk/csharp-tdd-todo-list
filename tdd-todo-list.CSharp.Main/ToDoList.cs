﻿using System;
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

        public string getJob(int id)
        {
            foreach (var job in jobs)
            {
                if (job.Id == id)
                {
                    Console.WriteLine("job found!");
                    return $"{job.Name} was found";
                }
            }
            Console.WriteLine("job not found");
            return "job not found";

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
