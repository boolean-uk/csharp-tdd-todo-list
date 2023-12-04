using Microsoft.VisualStudio.TestPlatform.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {
        public class Item
        {
            public Item(int taskID, string task, bool complete, DateTime creation)
            {
                ID = taskID;
                Task = task;
                Complete = complete;
                Creation = creation;
            }
            public int ID { get; set; }
            public string Task { get; set; }
            public bool Complete { get; set; }

            public DateTime Creation { get; set; }
        }

        public List<Item> ToDoListExt = new List<Item>();

        public void AddTask(string task)
        {
            //Generate ID
            int taskID = 1;

            //Make sure it is unique: check all ID's and +1 to the highest ID (should work when list is re-ordered)
            List <int> allIDs = new List<int>();
            foreach (Item item in ToDoListExt)
            {
                allIDs.Add(item.ID);
            }

            if (allIDs.Count > 0)
            {
                taskID = allIDs.Max() + 1;
            }

            Item newTask = new Item(taskID, task, false, DateTime.UtcNow);
            ToDoListExt.Add(newTask);
        }

        public string FindTaskByID(int searchID)
        {
            StringBuilder output = new StringBuilder();
            
            foreach (Item item in ToDoListExt)
            {
                if (item.ID == searchID)
                {
                    output.Append($"Task: {item.Task}, Completed: {item.Complete}, Created: {item.Creation}");
                }
            }
            return output.ToString();
        }

        public void UpdateNameByID(int searchID, string newName)
        {
            foreach (Item item in ToDoListExt)
            {
                if (item.ID == searchID)
                {
                    item.Task = newName;
                }
            }
        }

        public void UpdateStatusByID(int searchID, bool newStatus)
        {
            foreach (Item item in ToDoListExt)
            {
                if (item.ID == searchID)
                {
                    item.Complete = newStatus;
                }
            }
        }

        public string ShowCreation(int searchID)
        {
            string output = "";
            foreach (Item item in ToDoListExt)
                if (item.ID == searchID)
                {
                    output = item.Creation.ToString();
                }
            return output;
        }

        public string ShowCreation(string searchTask)
        {
            string output = "";
            foreach (Item item in ToDoListExt)
                if (item.Task == searchTask)
                {
                    output = item.Creation.ToString();
                }
            return output;
        }
    }
}
