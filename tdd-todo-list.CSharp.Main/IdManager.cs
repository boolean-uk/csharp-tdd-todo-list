using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{// THIS IS EXTENSION
    public class IdManager
    {
        struct TaskInfo(string name, bool status, string timeStamp)
        {
            string name = name;
            bool status = status;
            string timeStamp = timeStamp;   
        }
        Dictionary<int, TaskInfo> todo = new Dictionary<int, TaskInfo>();
        public enum TodoTaskStatus
        {
            Complete,
            InComplete,
            All
        }

    }
}
