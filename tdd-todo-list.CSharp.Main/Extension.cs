using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace tdd_todo_list.CSharp.Main;

public class Task
{
    private int _Id;
    private string _name;
    private bool _completed;
    private DateTime _created;

    public Task(int id, string name)
    {
        _Id = id;
        _name = name;
        _completed = false;
        _created = DateTime.Now;
    }

    public int Id { get { return _Id; } }
    public string Name { get { return _name; } set { _name = value; } }
    public bool Completed { get { return _completed; } set { _completed = value; } }
    public DateTime Created { get { return _created; } }
}

public class TodoListExtension
{
    private List<Task> todo;
    private bool showCompleted;
    private bool showIncompleted;

    public TodoListExtension()
    {
        todo = new List<Task>();
        showCompleted = true;
        showIncompleted = true;
    }

    public bool add(int id, string task)
    {
        var found = todo.Find(x => x.Id == id);
        if (found != null || task.Trim() == "") return false;
        todo.Add(new Task(id, task.Trim()));
        return true;
    }

    public void print()
    {
        string printString = string.Empty;

        if (todo.Count > 0)
        {
            var todoEnumerator = todo.GetEnumerator();

            printString = toPrintString(todoEnumerator);
        }
        else printString = "No tasks to print.";
        Console.WriteLine(printString);
    }

    private string toPrintString(List<Task>.Enumerator enumerator)
    {
        string printString = string.Empty;

        while (enumerator.MoveNext())
        {
            if (enumerator.Current.Completed == false && showIncompleted == false) continue;
            if (enumerator.Current.Completed == true && showCompleted == false) continue;
            printString += enumerator.Current.Name;
            if (enumerator.Current.Completed) printString += " Complete\n";
            else printString += " Incomplete\n";
        }
        return printString;
    }

    public bool setStatus(string task, bool status)
    {
        var found = todo.Find(x => x.Name == task.Trim());
        if (found != null)
        {
            found.Completed = status;
            return true;
        }
        return false;
    }

    public bool toggleShowCompleted()
    {
        if (showCompleted)
        {
            showCompleted = false;
            Console.WriteLine("Completed tasks now hidden.");
        }
        else
        {
            showCompleted = true;
            Console.WriteLine("Completed tasks now visible.");
        }
        return showCompleted;
    }

    public bool toggleShowIncompleted()
    {
        if (showIncompleted)
        {
            showIncompleted = false;
            Console.WriteLine("Incompleted tasks now hidden.");
        }
        else
        {
            showIncompleted = true;
            Console.WriteLine("Incompleted tasks now visible.");
        }
        return showIncompleted;
    }

    public bool find(string task)
    {
        string printString = "Task not found!\n";
        var found = todo.Find(x => x.Name == task.Trim());
        if (found != null)
        {
            printString = task.Trim();
            if (found.Completed) printString += " Complete\n";
            else printString += " Incomplete\n";
            Console.WriteLine(printString);
            return true;
        }
        Console.WriteLine(printString);
        return false;
    }

    public bool remove(string task)
    {
        var found = todo.Find(x => x.Name == task.Trim());
        if (found == null) return false;
        return todo.Remove(found);
    }

    public void printAscending()
    {
        string printString = string.Empty;

        if (todo.Count > 0)
        {
            var todoAscending = todo.OrderBy(x => x.Name).ToList();

            printString = toPrintString(todoAscending.GetEnumerator());
        }
        else printString = "No tasks to print.";
        Console.WriteLine(printString);
    }

    public void printDescending()
    {
        string printString = string.Empty;

        if (todo.Count > 0)
        {
            var todoDescending = todo.OrderByDescending(x => x.Name).ToList();

            printString = toPrintString(todoDescending.GetEnumerator());
        }
        else printString = "No tasks to print.";
        Console.WriteLine(printString);
    }

    public Task getById(int id)
    {
        var found = todo.Find(x => x.Id == id);
        if (found != null) return found;
        return new Task(-1, string.Empty);
    }

    public bool updateNameOfId(int id, string name)
    {
        var found = todo.Find(x => x.Id == id);
        if (found != null)
        {
            found.Name = name;
            return true;
        }
        return false;
    }

    public bool setStatusOfId(int id, bool status)
    {
        var found = todo.Find(x => x.Id == id);
        if (found != null)
        {
            found.Completed = status;
            return true;
        }
        return false;
    }

    public void printDetailed()
    {
        string printString = string.Empty;
        foreach (var item in todo)
        {
            printString += $"Id: {item.Id} Task: {item.Name} Completed: {item.Completed} DateTime: {item.Created}";
        }
        Console.WriteLine(printString);
    }
}
