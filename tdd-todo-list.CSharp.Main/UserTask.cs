using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class UserTask : IComparable<UserTask>
    {
        public string taskname;
        public bool isComplete = false;
        public int id;
        public DateTime created = DateTime.Now;

        public UserTask(int id)
        {
            this.id = id;
        }

        public int CompareTo(UserTask other)
        {
            return taskname.CompareTo(other.taskname);
        }
    }
}
