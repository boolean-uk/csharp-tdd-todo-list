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
                if (job == exJob)
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
            throw new NotImplementedException();
        }

        public List<Job> getAllJobs()
        {
            return todoList;
        }
    }
}
