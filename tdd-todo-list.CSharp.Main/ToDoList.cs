namespace tdd_todo_list.CSharp.Main;

public class TodoList
{
    private Dictionary<string, bool> todo;
    private bool showCompleted;
    private bool showIncompleted;

    public TodoList()
    {
        todo = new Dictionary<string, bool>();
        showCompleted = true;
        showIncompleted = true;
    }

    public bool add(string task)
    {
        if (todo.ContainsKey(task.Trim()) || task.Trim() == "") return false;
        todo.Add(task, false);
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

    private string toPrintString(Dictionary<string, bool>.Enumerator enumerator)
    {
        string printString = string.Empty;

        while (enumerator.MoveNext())
        {
            if (enumerator.Current.Value == false && showIncompleted == false) continue;
            if (enumerator.Current.Value == true && showCompleted == false) continue;
            printString += enumerator.Current.Key;
            if (enumerator.Current.Value) printString += " Complete\n";
            else printString += " Incomplete\n";
        }
        return printString;
    }

    public bool setStatus(string task, bool status)
    {
        if (todo.ContainsKey(task))
        {
            todo[task] = status;
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
        if (todo.ContainsKey(task.Trim()))
        {
            printString = task.Trim();
            if (todo[task.Trim()]) printString += " Complete\n";
            else printString += " Incomplete\n";
            Console.WriteLine(printString);
            return true;
        }
        Console.WriteLine(printString);
        return false;
    }

    public bool remove(string task)
    {
        return todo.Remove(task.Trim());
    }

    public void printAscending()
    {
        string printString = string.Empty;

        if (todo.Count > 0)
        {
            var todoAscending = todo.OrderBy(x => x.Key).ToDictionary();

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
            var todoDescending = todo.OrderByDescending(x => x.Key).ToDictionary();

            printString = toPrintString(todoDescending.GetEnumerator());
        }
        else printString = "No tasks to print.";
        Console.WriteLine(printString);
    }


}
