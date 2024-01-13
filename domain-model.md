```C#
struct Task:
    int _id
    string task/desc
    bool isCompleted

class ToDo:
    MEMBERS:
        private List<Task> tasks;
        private int _idHolder;

    METHODS:
        AddTask(string name)                         | generate a new Task();
        RemoveTask(int _id)                         | 
        DisplayTasks()                          | return list of tasks;
        ChangeStatus(int _id, bool true/false)  | changes the state of given task;
        GetCompletedTasks()                     | returns only the tasks that has status true;
        GetIncompletedTaska()                   | returns only the tasks that has status false;         
        SearchTask(int _id)                         | retuen Task or throe new error message;   
        GetOrderedList(char 'a' or char 'd')              | returns ascending or descending depending on input

```