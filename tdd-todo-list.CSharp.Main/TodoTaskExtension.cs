using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{
public class TodoTaskExtension
{
    public bool isFinished { get; set; }
    public string taskName { get; set; }
    public DateTime creationDate { get; private set; }
    public Guid taskId { get; private set; }

    public TodoTaskExtension(string taskName)
    {
        this.taskName = taskName;
        this.isFinished = false;
        this.creationDate = DateTime.Now;
        this.taskId = Guid.NewGuid();
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("Taskname: " + this.taskName + '\n');
        sb.Append("Finished: " + this.isFinished.ToString() + '\n');
        sb.Append("Creation Date: " + this.creationDate.ToShortDateString() + '\n');
        sb.Append("Task ID: " + this.taskId.ToString() + '\n');
        return sb.ToString();

    }
}
}
