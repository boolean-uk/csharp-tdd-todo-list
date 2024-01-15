using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        private Dictionary<string, bool> _theList = new Dictionary<string, bool>();
        public Dictionary<string, bool> TheList { get { return _theList; } set { _theList = value; } }

        public TodoList(Dictionary<string, bool>? fillInList = null)
        {
            TheList = fillInList;
        }

        public bool Add(string task)
        {
            bool added = false;
            if(TheList.ContainsKey(task))
            {
                added = false;
            }
            else
            {
                TheList.Add(task, false);
                added = true;
            }

            return added;
        }

        public bool removeTask(string task)
        {
              return TheList.Remove(task);
        }

        public bool searchTask(string task)
        {
            return TheList.ContainsKey(task);
        }

        public bool setStatus(string task, bool completed)
        {
            bool statusChanged = false;
            if (!TheList.ContainsKey(task))
            {
                return statusChanged;
            }
            else
            {
                TheList[task] = completed;
                statusChanged = true;
            }
            return statusChanged;
        }

        public Dictionary<string, bool> viewAll()
        {
            return TheList;
        }

        public SortedDictionary<string, bool> viewAlphabetically()
        {
            SortedDictionary<string, bool> alphateticalList = new SortedDictionary<string, bool>(TheList);
            return alphateticalList;
        }

        public Dictionary<string, bool> viewAlphabeticallyDescending()
        {
            SortedDictionary<string, bool> alphateticalList = new SortedDictionary<string, bool>(TheList);
            Dictionary<string, bool> alphateticalReversedList = new Dictionary<string, bool>();
            for (int i = alphateticalList.Count-1; i >= 0; i--)
            {
                alphateticalReversedList.Add(alphateticalList.Keys.ElementAt(i), alphateticalList.Values.ElementAt(i));
            }
            return alphateticalReversedList;
        }

        public List<string> viewCompleted()
        {
            List<string> completedTasks = new List<string>();
            foreach (var task in TheList)
            {
                if(task.Value)
                {
                    completedTasks.Add(task.Key);
                }
            }
            return completedTasks;
        }

        public List<string> viewRemaining()
        {
            List<string> remainingTasks = new List<string>();
            foreach (var task in TheList)
            {
                if (!task.Value)
                {
                    remainingTasks.Add(task.Key);
                }
            }
            return remainingTasks;
        }
    }
}
