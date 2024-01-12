
    I want to add tasks to my todo list.


    I want to see all the tasks in my todo list.
    
  
    I want to change the status of a task between incomplete and complete.

    
    I want to be able to get only the complete tasks.


    I want to be able to get only the incomplete tasks.

    --
    I want to search for a task and receive a message that says it wasn't found if it doesn't exist.


    I want to remove tasks from my list.


    I want to see all the tasks in my list ordered alphabetically in ascending order.


    I want to see all the tasks in my list ordered alphabetically in descending order.


    //Model 

    //Class
    TODOItem
    //Parameters
    String TaskName
    Bool Complete
    Int id

    //method
    void UpdateStatus() - cycle status of Complete
    

    //Class
    TODOList
    //Parameters
    List<TodoItem> TODOitems

    //Methods

    bool AddTask(TODOitem) 
    string ShowTasks(List<TodoItem> )
    bool UpdateStatus(TODOitem)

    List<TodoItem> FilterTasksOnProgress(bool ) 
    
    String Search(String name)
            return message of Todo if found
            return Error message if not found
    List<TodoItem> DeleteTask(TodoItem)

    List<TodoItem> SortAscending(List<TodoItem>)
    List<TodoItem> Sortdescending(List<TodoItem>)

    
        