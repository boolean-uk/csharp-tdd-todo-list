using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {
        int IDCounter = 0;
        private List<JobExtension> _jobs = new List<JobExtension>();
        public List<JobExtension> Jobs { get { return _jobs; } }

        public bool AddToList(JobExtension job)
        {
            if (job == null)
            {
                return false;
            }
            else if (_jobs.Where(item => item.Name == job.Name).ToList().Count != 0)
            {
                return false;
            }
            IDCounter++;
            job.ID = IDCounter;
            _jobs.Add(job);
            return true;
        }

        public JobExtension GetJob(string name)
        {
            List<JobExtension> jobs = Jobs.Where(job => job.Name.Equals(name)).ToList();
            if (jobs.Count <= 0)
            {
                return new JobExtension("", "");
            }
            return jobs[0];
        }

        public List<JobExtension> GetJobs(bool completed)
        {
            return Jobs.Where(job => job.Complete.Equals(completed)).ToList();
        }

        public bool PrintJobs(List<JobExtension> jobs)
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

        public bool RemoveJob(string name)
        {
            return Jobs.Remove(GetJob(name));
        }

        public List<JobExtension> GetJobsOrdered(bool ascending)
        {
            if (ascending)
            {
                return Jobs.OrderBy(job => job.Name).ToList();
            }
            return Jobs.OrderByDescending(job => job.Name).ToList();
        }
    }

    public class JobExtension
    {
        private bool _complete;
        private string _name;
        private string _description;
        private DateTime _created;
        private int _ID;

        public int ID { get; set; }
        public bool Complete { get { return _complete; } }
        public string Name { get { return _name; } }
        public string Description { get { return _description; } }
        public string Created { get { return DateTime.Now.ToString(); } }

        public JobExtension(string name, string description)
        {
            _complete = false;
            _name = name;
            _description = description;
            _created = DateTime.Now;
        }

        public bool ChangeStatus(bool newStatus)
        {
            this._complete = newStatus;
            return true;
        }
    }
}


