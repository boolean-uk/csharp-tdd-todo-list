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

            if (todoList.Contains(job))
            {
                return !added;
            }

            todoList.Add(job);
            return added;
        }

        public List<Job> getAllJobs()
        {
            throw new NotImplementedException();
        }
    }
}
