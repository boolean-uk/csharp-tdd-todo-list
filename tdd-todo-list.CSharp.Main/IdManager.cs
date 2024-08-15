using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{// THIS IS EXTENSION
    public class IdManager
    {
        public struct TaskInfo(string name, bool status, string timeStamp)
        {
            public string name = name;
            public bool status = status;
            public string timeStamp = timeStamp;   
        }
        Dictionary<int, TaskInfo> todo = new Dictionary<int, TaskInfo>();
        public enum TodoTaskStatus
        {
            Complete,
            InComplete,
            All
        }

        public void AddTask(string name, bool status, string timeStamp)
        {
            TaskInfo info = new TaskInfo(name, status, timeStamp);
            int id = todo.Count;
            todo.Add(id, info);
        }

        public string FindTaskByID(int id)
        {
            string resultInfo = "404 task not found!";
            foreach (var entry in todo)
            {
                if (entry.Key == id)
                {
                    var temp = entry.Value;
                    string completion = ", task incomplete";
                    if(temp.status)
                    {
                        completion = ", task complete";
                    }
                    resultInfo = temp.name + completion + ", task created " + temp.timeStamp;
                    break;
                }
            }
           

            return resultInfo;
        }

    

        public string UpdateTaskName(int id, string name)
        {
            string result = "A file with that name does not exist!";
            foreach (var entry in todo)
            {
                if (entry.Key == id)
                {
                    TaskInfo newInfo = new TaskInfo(name, entry.Value.status, entry.Value.timeStamp);
                    todo[id] = newInfo;
                    result = "new";
                    break;
                }
            }
            return result;
        }
    }
}
