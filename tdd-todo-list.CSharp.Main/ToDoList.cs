





namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {

        private Dictionary<string, int> taskList = new Dictionary<string, int>();

        public bool Add(string task, int status)
        {
            //if not in dict -> add
            if (!taskList.ContainsKey(task))
            {
                taskList.Add(task, status);
                return true;
            }
            return false;
        }

        public bool ChangeStatus(string task, int newStatus)
        {
            if (taskList.ContainsKey(task))
            {
                if (taskList[task] != newStatus) { return true; }

                taskList[task] = newStatus;
                return false;
            }
            return false;
        }

        public List<string> GetCompleted()
        {
            List<string> completed = new List<string>();

            foreach (string task in taskList.Keys)
            {
                if (taskList[task] == 1)
                {
                    completed.Add(task);
                }
            }

            return completed;
        }

        public List<string> GetIncomplete()
        {
            List<string> incomplete = new List<string>();

            foreach (string task in taskList.Keys)
            {
                if (taskList[task] == 0)
                {
                    incomplete.Add(task);
                }
            }

            return incomplete;
        }

        public List<string> GetTaskList()
        {
            List<string> tasks = new List<string>();

            foreach (string task in taskList.Keys)
            {
                tasks.Add(task);
            }

            return tasks;
        }

        public void Remove(string task)
        {
            if (taskList.ContainsKey(task))
            {
                taskList.Remove(task);
            }
        }

        public bool Search(string task)
        {
            if(taskList.ContainsKey(task)) {  return true; }

            return false;
        }

        public List<string> SortAscending()
        {
            return taskList.Keys.OrderBy(task => task).ToList(); ;
        }

        public List<string> SortDescending()
        {
            return taskList.Keys.OrderByDescending(task => task).ToList(); ;
        }
    }
}
