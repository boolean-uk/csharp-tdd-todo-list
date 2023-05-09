using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {

        public Dictionary<int, string[]> _myList;
        private Dictionary<int, string[]> myList
        {
            get { return _myList; }
            set { _myList = value; }
        }

        public Dictionary<int, DateTime> _myListTime;
        private Dictionary<int, DateTime> myListTime
        {
            get { return _myListTime; }
            set { _myListTime = value; }
        }

        public TodoListExtension()
        {
            myList = new Dictionary<int, string[]>();
            myListTime = new Dictionary<int, DateTime>();
            myList.Add(0, new string[] { "task1", "true" });
            myListTime.Add(0, DateTime.Now);
            myList.Add(1, new string[] { "task2", "false" });
            myListTime.Add(1, DateTime.Now);
            myList.Add(2, new string[] { "task3", "true" });
            myListTime.Add(2, DateTime.Now);
        }

        public void addTask(int id, string name, string status)
        {
            myList.Add(id, new string[] { name, status });
            myListTime.Add(id, DateTime.Now);
        }

        public string[] getTask(int id)
        {
            if (myList.ContainsKey(id) == false)
            {
                Console.WriteLine("The task doesnt exit");
            }
            return myList[id];
        }

        public void updateTaskName(int id, string name)
        {
            if (myList.ContainsKey(id))
            {
                myList[id][0] = name;
            }
        }

        public void updateTaskStatus(int id , string status)
        {
            if (myList.ContainsKey(id))
            {
                myList[id][1] = status;
            }
        }

        public Dictionary<int, DateTime> getCreationTime()
        {
            return myListTime;
        }

    }
}
