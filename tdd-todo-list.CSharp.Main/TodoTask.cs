namespace tdd_todo_list.CSharp.Main;

public class TodoTask
{
    private string name {get; set;}
    private bool completed {get; set;}
    private DateTime created {get; set;}
    
    public TodoTask(string name)
    {
        this.name = name;
        this.completed = false;
        this.created = DateTime.Now;
    }
    
    public void SetName(string name)
    {
        this.name = name;
    }
    
    public string GetName()
    {
        return this.name;
    }
    
    public bool SetStatus(bool status)
    {
        this.completed = status;
        return this.completed;
    }
    
    public bool GetStatus()
    {
        return this.completed;
    }
    
    public DateTime GetDateTimeStamp()
    {
        return this.created;
    }
    
    public override string ToString()
    {
        return $"Task: {this.name}, Completed: {this.completed}, Created: {this.created}";
    }
}