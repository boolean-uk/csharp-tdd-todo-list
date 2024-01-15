using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoListExtension
    {
        // I will continue to use the TaskItem class created in ToDoList.cs
        public Dictionary<int, TaskItem> toDoListExtension = new Dictionary<int, TaskItem>();
        public Dictionary<int, DateTime> extensionDateTime = new Dictionary<int, DateTime>();
        public DateTime timeVar = new DateTime();

        public void add(int id, string task, bool status)
        {
            TaskItem item = new TaskItem(upperWords(task), status);
            if (!toDoListExtension.ContainsKey(id) && !toDoListExtension.Any(x => x.Value.Task == item.Task))
            {
                toDoListExtension.Add(id, item);
                extensionDateTime.Add(id, DateTime.Now);
            }
        }
        public string searchId(int id)
        {
            TaskItem item = new TaskItem("", false);
            DateTime time = new DateTime();
            if (toDoListExtension.ContainsKey(id))
            {
                toDoListExtension.TryGetValue(id, out item);
                extensionDateTime.TryGetValue(id, out time);
            }
            timeVar = time;
            return item.Task;
        }

        public void updateTask(int id, string newTask)
        {
            if (toDoListExtension.ContainsKey(id))
            {
                toDoListExtension[id].Task = newTask;
            }
        }
        public void updateStatus(int id)
        {
            if (toDoListExtension.ContainsKey(id))
            {
                toDoListExtension[id].Status = !toDoListExtension[id].Status;
            }
        }

        public string upperWords(string text)
        {
            char[] chars = text.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (i == 0)
                {
                    chars[i] = Char.ToUpper(chars[i]);
                }
                else
                {
                    if (chars[i - 1] == ' ')
                    {
                        chars[i] = Char.ToUpper(chars[i]);
                    }
                    else
                    {
                        chars[i] = Char.ToLower(chars[i]);
                    }
                }
            }
            string result = new string(chars);
            return result;
        }
    }
}
