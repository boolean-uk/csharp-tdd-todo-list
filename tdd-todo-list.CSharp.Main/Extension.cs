// Inside ./tdd-todo-list.CSharp.Main/Extension.cs
using System;

namespace tdd_todo_list.CSharp.Main
{
    public static class TaskExtension
    {
        public static int GetId(this Task task)
        {
            return task.GetHashCode(); // A simple implementation for demonstration purposes
        }

        public static void UpdateName(this Task task, string newName)
        {
            task.Title = newName;
        }

        public static void ChangeStatus(this Task task, bool newStatus)
        {
            task.IsComplete = newStatus;
        }

        public static DateTime GetCreationDateTime(this Task task)
        {
            return DateTime.Now; // Returns the current date and time as an example
        }
    }
}

