using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class Task
    {
        public Guid Id {  get; set; }
        public string Name { get; set; }
        public bool IsComplete { get; set; }
        public Priority Priority { get; set; }
        public Category Category { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime CompletedAt { get; set; }

        public Task(string name, Priority priority, Category category)
        {
            Id = Guid.NewGuid();
            Name = name;
            Priority = priority;
            Category = category;
            IsComplete = false;
            CreatedAt = DateTime.Now;
        }
    }
}
