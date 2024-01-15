```C#
struct Task:
    public int _id
    punlic string task/desc
    public bool isCompleted

class ToDo:
    MEMBERS:
        public List<Task> tasks;
        private int _idHolder;

    METHODS:
        public AddTask(string name)                         | return true if new Task() is generated else return false  
        public RemoveTask(int _id)                         | return true if tsk is removed by _id, else false
        public DisplayTasks()                          | return list of tasks;
        public ChangeStatus(int _id, bool true/false)  | changes the state of given task;
        public GetCompletedTasks()                     | return only the tasks that has status true;
        public GetIncompletedTaska()                   | return only the tasks that has status false;         
        public SearchTask(int _id)                         | return Task or throe new error message;   
        public GetOrderedList(char 'a' or char 'd')              | returns ascending or descending depending on input
        
    HELPER:
        private GetAscendingOrder() | return a ordered list in ascending order
        private GetDescendingOrder() | return a ordered list in descending order

```