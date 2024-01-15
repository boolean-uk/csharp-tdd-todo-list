using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension : TodoList
    {
        public TodoListExtension() : base() {  }

        public int getID(string name)
        {
            return IDToTask.FirstOrDefault(x => x.Value == name).Key;
        }

        public string getTaskByID(int ID)
        {
            return IDToTask[ID];
        }

        public void updateName(int ID, string v)
        {
            IDToTask[ID] = v;
        }

        public void updateStatus(int ID, string v)
        {
            IDToInfo[ID] = ((IDToInfo[ID].status == "incomplete" ? "complete" : "incomplete"), IDToInfo[ID].time);
        }

        public DateTime whenCreated(int ID)
        {
            return IDToInfo[ID].time;
        }
    }
}
