using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;
using Microsoft.VisualStudio.TestPlatform.PlatformAbstractions;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TaskItem
    {
        private string _task;
        private bool _status;

        public TaskItem(string task, bool status)
        {
            _task = task;
            _status = status;
        }
        public string Task { get => _task;  set => _task = value; }
        public bool Status { get => _status;  set => _status = value; }
        
        
    }
    public class TodoList
    {
        public List<TaskItem> toDoList = new List<TaskItem>();
        public string listString = "";
        public string completeListString = "";
        public string incompleteListString = "";
        public string ascendingListString = "";
        public string descendingListString = "";
        public void add(string task, bool status)
        {
            TaskItem item = new TaskItem(upperWords(task), status);
            if (!toDoList.Any(x => x.Task == item.Task)) { toDoList.Add(item); }
        }
        public void remove(string task)
        {
            if (search(task))
            {
                toDoList.RemoveAt(toDoList.FindIndex(x => x.Task == upperWords(task)));
            }
        }

        public void show()
        {
            listString = "";
            listString += "Your tasks:\n";
            foreach(TaskItem item in toDoList)
            {
                string completion = "Incompleted";
                if (item.Status) { completion = "Completed"; }
                listString += $"{item.Task}: {completion}\n";
            }
        }

        public void changeStatus(string task)
        {
            toDoList[toDoList.FindIndex(x => x.Task == upperWords(task))].Status = !toDoList[toDoList.FindIndex(x => x.Task == upperWords(task))].Status;
        }
        public void showComplete()
        {
            completeListString = "";
            completeListString += "Your completed tasks:\n";
            foreach (TaskItem item in toDoList)
            {
                if (item.Status) { completeListString += $"{item.Task}\n"; }
            }
        }

        public void showIncomplete()
        {
            incompleteListString = "";
            incompleteListString += "Your incompleted tasks:\n";
            foreach (TaskItem item in toDoList)
            {
                if (!item.Status) { incompleteListString += $"{item.Task}\n"; }
            }
        }
        public void showAscending()
        {
            var ascendingList = toDoList.OrderBy(x => x.Task).ToList();
            ascendingListString = "";
            ascendingListString += "Your tasks in ascending order:\n";
            foreach (TaskItem item in ascendingList)
            {
                string completion = "Incompleted";
                if (item.Status) { completion = "Completed"; }
                ascendingListString += $"{item.Task}: {completion}\n";
            }
        }
        public void showDescending()
        {
            var descendingList = toDoList.OrderByDescending(x => x.Task).ToList();
            descendingListString = "";
            descendingListString += "Your tasks in descending order:\n";
            foreach (TaskItem item in descendingList)
            {
                string completion = "Incompleted";
                if (item.Status) { completion = "Completed"; }
                descendingListString += $"{item.Task}: {completion}\n";
            }
        }
        public bool search(string task)
        {
            if (toDoList.Any(x => x.Task == upperWords(task)))
            {
                return true;
            } else
            {
                return false;
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
                } else
                {
                    if (chars[i-1] == ' ')
                    {
                        chars[i] = Char.ToUpper(chars[i]);
                    } else
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
