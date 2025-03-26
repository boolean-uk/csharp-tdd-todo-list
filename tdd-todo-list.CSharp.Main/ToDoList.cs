using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        public Dictionary<string, bool> Items { get; set; } = new Dictionary<string, bool>();
        public Dictionary<string, bool> CompletedItems { get { return Items.Where(x => x.Value == true).ToDictionary(x => x.Key, x => x.Value); } }
        public Dictionary<string, bool> InCompletedItems { get { return Items.Where(x => x.Value == false).ToDictionary(x => x.Key, x => x.Value); } }

        public Dictionary<string, bool> AscendingTasks()
        {
            return Items.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
        }
        public Dictionary<string, bool> DescendingTasks()
        {
            return Items.OrderByDescending(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
        }

        public bool RemoveItem(string remove)
        {
            foreach (var item in Items)
            {
                if (item.Key == remove)
                {
                    Items[remove] = true;
                    return true;
                }
            }
            return false;
        }

        public string SearchTaskByName(string search)
        {
            foreach (var item in Items)
            {
               if (item.Key == search)
                {
                    return "found";
                }                           
            }
            return "not found";
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

        public bool UpdateTask(string task)
        {
            foreach (var item in Items)
            {
                if (item.Key == task)
                {
                    Items[task] = true;
                    return true;
                }
            }
            // check task is in collection
            // update task
            // return true
            // else return false

            return false;
        }


    }
}
