using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoList
    {
        private List<string> todoList;
        private Dictionary<string, string> toDoDictionary;

        public TodoList()
        {
            todoList = new List<string>();
            toDoDictionary = new Dictionary<string, string>();
        }

        // User Story 1
        public string Add(string task)
        {
            todoList.Add(task);
            toDoDictionary[task] = "Incomplete";
            return "Task added to todo list.";
        }

        // User Story 2
        public string ShowTasks()
        {
            return string.Join(", ", todoList);
        }

        // User Story 3
        public string ChangeTaskStatus(string task, string newStatus)
        {
            if (toDoDictionary.ContainsKey(task))
            {
                string currentStatus = toDoDictionary[task];
                if (newStatus == "Complete")
                {
                    currentStatus = newStatus;
                    toDoDictionary[task] = newStatus;

                    return "Task status changed to complete.";
                }
                else if(newStatus == "Incomplete")
                {
                    currentStatus = newStatus;
                    toDoDictionary[task] = newStatus;

                    return "Task status changed to incomplete.";
                }
            }
            return "Task not found in todo list.";
        }

        // User Story 4
        public string GetCompletedTasks()
        {
            return string.Join(", ", toDoDictionary.Where(task => task.Value == "Complete").Select(task => task.Key));
        }

        // User Story 5
        public string GetIncompleteTasks()
        {
            return string.Join(", ", toDoDictionary.Where(task => task.Value == "Incomplete").Select(task => task.Key));
        }

        // User Story 6
        public string FindTask(string task)
        {
            if (todoList.Contains(task)) {
                return "Task exists in todo list.";
            }
            return "Task does not exist in list.";
        }

        // User Story 7
        public string Remove(string task)
        {
            if (todoList.Contains(task))
            {
                todoList.Remove(task);
                toDoDictionary.Remove(task);
                return "Task successfully removed from todo list.";
            }
            return "Task not in todo list.";
        }

        // User Story 8
        public string OutputListAscending()
        {
            var sortedList = todoList.OrderBy(task => task).ToList();
            return string.Join(", ", sortedList);
        }

        // User Story 9
        public string OutputListDescending()
        {
            var sortedList = todoList.OrderByDescending(task => task).ToList();
            return string.Join(", ", sortedList);
        }
    }
}
