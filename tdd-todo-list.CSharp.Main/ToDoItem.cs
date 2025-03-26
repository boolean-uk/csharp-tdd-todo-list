using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoItem
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public bool IsCompleted { get; set; }

        public DateTime CreatedAt{ get; }

        public TodoItem(string title)
        {
            Title = title;
            IsCompleted = false;
            CreatedAt = DateTime.Now; 
        }

        public void UpdateTask(bool isComplete)
        {
            IsCompleted = isComplete;
        }
    }
}