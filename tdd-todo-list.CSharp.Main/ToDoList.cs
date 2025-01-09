using System.Text;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        public Dictionary<string, string> toDoList;
        public TodoList()
        {
            this.toDoList = new Dictionary<string, string>();
        }

        public bool addTask(string task)
        {
            if (toDoList.ContainsKey(task))
            {
                return false;
            }
            toDoList.Add(task, "incomplete");
            return true;
        }
        public string changeStatus(string task)
        {
            if (toDoList.ContainsKey(task))
            {
                string currentStatus = toDoList[task];
                string newStatus = currentStatus.Equals("incomplete") ? "complete" : "incomplete";
                toDoList[task] = newStatus;
                return newStatus;
            }
            return "Task not found";
        }
        public bool seeAllTasks()
        {
            Console.WriteLine(toDoList.ToString());
            return true;
        }
        public string GetCompleteTask()
        {
            StringBuilder sb = new StringBuilder();
            foreach (string task in toDoList.Keys)
            {
                if ("complete".Equals(toDoList[task]))
                {
                    if (sb.Length > 0)
                    {
                        sb.Append(", ");
                    }
                    sb.Append(task);
                }
            }
            Console.WriteLine(sb.ToString());
            return sb.ToString();
        }
        public string GetIncompleteTask()
        {
            StringBuilder sb = new StringBuilder();
            foreach (string task in toDoList.Keys)
            {
                if ("incomplete".Equals(toDoList[task]))
                {
                    if (sb.Length > 0)
                    {
                        sb.Append(", ");
                    }
                    sb.Append(task);
                }
            }
            Console.WriteLine(sb.ToString());
            return sb.ToString();
        }

        public string searchTask(string task)
        {
            if (toDoList.ContainsKey(task))
            {
                return "Task found: " + task;
            }
            else
            {
                return "Task not found";
            }
        }
        public bool removeTask(string task)
        {
            if (toDoList.ContainsKey(task))
            {
                toDoList.Remove(task);
                return true;
            }
            return false;
        }
        public List<KeyValuePair<string,string>> SortAsc()
        {
            return toDoList.OrderBy(x => x.Key).ToList();
        }

        public List<KeyValuePair<string, string>> SortDesc()
        {
            return toDoList.OrderBy(x => x.Key).ToList();
        }
    }
}
