using System;

namespace tdd_todo_list.CSharp.Main
{
    public class Task
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsComplete { get; set; }

        public int Id { get; set; }

        public Task(string title, string description)
        {
            Title = title;
            Description = description;
            IsComplete = false; // By default, tasks are incomplete
            Id = Id;
        }

        public void ToggleStatus()
        {
            IsComplete = !IsComplete;
        }

        public override string ToString()
        {
            return $"Title: {Title}, Description: {Description}, Status: {(IsComplete ? "Complete" : "Incomplete")}";
        }
    }
}
