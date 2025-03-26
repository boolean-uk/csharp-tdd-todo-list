using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {
        public Dictionary<int, TaskItem> tasks = new Dictionary<int, TaskItem>();
        public int AddTask(string description)
        {
            int id = tasks.Count;
            tasks[id] = new TaskItem(description);

            return id;
        }

        public void ChangeStatus(int taskID)
        {
            tasks[taskID].IsCompleted = true;
        }

        public TaskItem FindTask(int taskID)
        {
            return tasks[taskID];
        }

        public string TaskTimeAndDate(int taskID)
        {
            return tasks[taskID].DateAndTimeCreated;
        }

        public void UpdateTask(int taskID, string description)
        {
            tasks[taskID].Description = description;
        }

        public List<TaskItem> GetList(char completed = 'a', char sorted = 'n')
        {
            List<TaskItem> returnList = new List<TaskItem>();

            if (completed == 'c')
            {
                foreach (TaskItem taskItem in tasks.Values)
                {
                    if (taskItem.IsCompleted)
                    {
                        returnList.Add(taskItem);
                    }
                }
            }
            else if (completed == 'i')
            {
                foreach (TaskItem taskItem in tasks.Values)
                {
                    if (!taskItem.IsCompleted)
                    {
                        returnList.Add(taskItem);
                    }
                }
            }
            else
            {
                returnList = new List<TaskItem>(tasks.Values);
            }



            if (sorted == 'a')
            {
                return returnList.OrderBy(x => x.Description).ToList();
            }
            if (sorted == 'd')
            {
                return returnList.OrderByDescending(x => x.Description).ToList();
            }
            return returnList;

        }
    }
}
