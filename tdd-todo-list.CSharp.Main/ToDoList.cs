using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        public Dictionary<string, bool> Items { get; set; } = new Dictionary<string, bool>();

        public Dictionary<string, bool> AscendingItems()
        {
            return Items.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
        }

        public Dictionary<string, bool> DescendingItems()
        {
            return Items.OrderByDescending(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
        }


        public Dictionary<string, bool> CompletedItems { get { return Items.Where(x => x.Value == true).ToDictionary(x => x.Key, x => x.Value); } }
        public Dictionary<string, bool> InCompletedItems { get { return Items.Where(x => x.Value == false).ToDictionary(x => x.Key, x => x.Value); } }
        public bool UpdateTask(string task)
        {
            foreach (var item in Items)
            {
                if (item.Key == task)
                {
                    Items[task] = true;
                    return Items[task];
                }
            }

            return false;
        }

        public string SeeTasks()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in Items)
            {
                sb.Append(item.Key);
            }
            return sb.ToString();
        }

        public string SearchTask(string task)
        {
            bool result = false;
            string message = "Task wasn't found";
            result = Items.ContainsKey(task);
            if (result) { return message; } else { return (result.ToString()); }
        }
    }
}
