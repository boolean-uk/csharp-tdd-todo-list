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
            else if (_jobs.Where(item => item.Name == job.Name).ToList().Count != 0)
            {
                return false;
            }
            _jobs.Add(job);
            return true;
        }

        public List<Job> GetJobs(bool completed)
        {
            return Jobs.Where(job => job.Complete.Equals(completed)).ToList();
        }

        public bool PrintJobs(List<Job> jobs) 
        {
            string message = string.Empty;
            bool messageComplete = false;

            foreach (var item in jobs)
            {
                message += string.Format($"Name: {item.Name}\n");
                message += string.Format("Status: {0}", item.Complete ? "Complete" : "Incomplete\n");
                message += string.Format($"Description: {item.Description}\n");
                message += string.Format($"Created: {item.Created}\n\n");

                messageComplete = message.Contains(item.Name);
                if (messageComplete.Equals(false))
                {
                    return false;
                }
            }
            Console.WriteLine(message);

            return messageComplete;
        }
    }
}
