using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {
        private string _complete = " | Complete\n";
        private string _incomplete = " | Incomplete\n";

        public struct StatusAndID
        {
            public int ID = 0;
            public string date = string.Empty;
            public string time = string.Empty;
            public bool state = false;

            public StatusAndID(int ID)
            {
                this.ID = ID;
                date = DateTime.Now.ToString("d");
                time = DateTime.Now.ToString("h:mm:ss tt");
                state = false;
            }

            public StatusAndID(StatusAndID existingValue)
            {
                this.ID = existingValue.ID;
                this.date = existingValue.date;
                this.time = existingValue.time;
                this.state = existingValue.state;
            }

            public void SetState(bool newState)
            {
                this.state = newState;
            }
        };


        Dictionary<string, StatusAndID> tasks = new Dictionary<string, StatusAndID>();

        private int _GenerateNewID()
        {
            int uniqueID = 0;
            while (true)
            {
                bool unique = true;
                foreach (var task in tasks.Values) {
                    if (task.ID == uniqueID)
                    {
                        unique = false;
                        uniqueID++;
                        break;
                    }
                }

                if (unique)
                {
                    break;
                }
            }

            return uniqueID;
        }

        private string _List(Dictionary<string, StatusAndID> taskList)
        {
            string output = string.Empty;
            foreach (var task in taskList)
            {
                if (task.Value.state)
                {
                    output += task.Key + _complete;
                }
                else
                {
                    output += task.Key + _incomplete;
                }
            }
            return output;
        }
        public bool Add(string task)
        {
            if (tasks.ContainsKey(task))
            {
                return false;
            }
            tasks.Add(task, new StatusAndID(_GenerateNewID()));
            return true;
        }

        public bool ChangeStatus(string task, bool status)
        {
            if (tasks.ContainsKey(task))
            {
                tasks[task].SetState(status);
                return true;
            }
            return false;
        }

        public string List()
        {
            return _List(tasks);
        }

        public string ListAscending()
        {
            return _List(tasks.OrderBy(x => x.Key).ToDictionary());
        }

        public string ListCompleteTasks()
        {
            string output = string.Empty;
            foreach (var task in tasks)
            {
                if (task.Value.state)
                {
                    output += task.Key + _complete;
                }
            }
            return output;
        }

        public string ListIncompleteTasks()
        {
            string output = string.Empty;
            foreach (var task in tasks)
            {
                if (!task.Value.state)
                {
                    output += task.Key + _incomplete;
                }
            }
            return output;
        }

        public bool Remove(string task)
        {
            if (tasks.ContainsKey(task))
            {
                tasks.Remove(task);
                return true;
            }
            return false;
        }

        public string Search(string task)
        {
            if (tasks.ContainsKey(task))
            {
                return "Task found!";
            }
            return "Task does not exist!";
        }

        public string ListDescending()
        {
            return _List(tasks.OrderByDescending(x => x.Key).ToDictionary());
        }

        public KeyValuePair<string, StatusAndID> Get(int id)
        {
            foreach (var task in tasks)
            {
                if (task.Value.ID == id)
                {
                    return task;
                }
            }
            return new KeyValuePair<string, StatusAndID>();
        }

        public bool ChangeName(int id, string newName)
        {
            int index = 0;
            bool found = false;
            string key = string.Empty;
            foreach(var task in tasks)
            {
                if (task.Value.ID == id) //Found ID
                {
                    key = task.Key;
                    found = true;
                    break;
                }
                index++;
            }
            if (found) //If ID was found
            {
                if (tasks.ContainsKey(newName)) //Check if key is not already taken
                {
                    return false;
                }
                tasks.Add(newName, tasks[key]); //Add new key
                tasks.Remove(key); //Remove old key
                return true;
            }
            return false;
        }

        public bool ChangeStatus(int id, bool status)
        {
            foreach(var task in tasks)
            {
                if (task.Value.ID == id)
                {
                    tasks[task.Key].SetState(status);
                    return true;
                }
            }
            return false;
        }
    }
}
