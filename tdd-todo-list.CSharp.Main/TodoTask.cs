using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
    public class TodoTask
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime IdCreatedOnThisTime { get; }
        public TodoTask(string title)
        {
            Title = title;
            IsCompleted = false;
            IdCreatedOnThisTime = DateTime.Now; //used https://learn.microsoft.com/en-us/dotnet/api/system.datetime.now?view=net-7.0
        }
        public void ChangeTask(bool isComplete)
        {
            IsCompleted = isComplete;
        }
    }
}
