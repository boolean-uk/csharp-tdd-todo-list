
|Classes| Methods/Properties|Scenario|Output|
|-------|-------------------|---------|------|
|ToDoList.cs|Add(string task)|want to add a task to the list|task will be added to list|
|ToDoList.cs|ViewAll()|want to display all tasks|all task displayed|
|ToDoTask.cs|Status|want to change completed/not completed|updated status|
|ToDoList.cs|ViewCompleted()|want to see all completed tasks|display all completed tasks|
|ToDoList.cs|ViewIncompleted()|want to see all uncompleted tasks|display all uncomleted tasks|
|ToDoList.cs|IsPresent(ToDoTask task)|want to see if a task exists|true if present, false otherwise|
|ToDoList.cs|Remove()|want to remove tasks|task removed|
|ToDoList.cs|ViewAlphabetical()|want to see all tasks in alphabetical order|dispaly all tasks in acesnding alphabetical order|
|ToDoList.cs|ViewDescendingAlphabetical()|want to see all tasks in descending alphabetical order|dispaly all tasks in descending alphabetical order|
|ToDoTask.cs|ChangePriority(int priority)|want to change between high,medium and low priority|priority set to new priority|
|ToDoList.cs|ViewByPriority()|want to sort tasks by proirity|task listed after priority|


|Classes| Methods/Properties|Scenario|Output|
|-------|-------------------|---------|------|
|ToDoList.cs|getById(int id)| want to get task form unique id| task for given id|
|ToDoList.cs|UpdateById(int id, string newName)| want to update name of task for given id| new name given to unique id|
|ToDoList.cs|UpdateStatusById(int id, bool status)| want sp change between finished and not finished| updates the given tasks status|
|ToDoTask.cs|TimeCreated| want to see when a task has been created| returnes the timestamp of task creation|
|ToDoTask.cs|TimeFinished|want to see when given task was finished| returnes the timestamp of task completion|
|ToDoList.cs|LongestBeforeFinished()|want to see the task which took the longest to complete|returns the task with longest time active|
|ToDoList.cs|ShortestBeforeFinished()|want to see the task which took the shortest to complete|returns the task with the shortest time active|
|ToDoTask.cs|TypeOfTask|want the ability to categorise my tasks|four categories added, and ability to choose for each task|
|ToDoList.cs|ListAllByCategory()|want to list tasks by category|tasks sorted by category|
|ToDoList.cs|ListAllActiveFor5PlussDays()|want to list task active for more then 5 days| lists all task active for 5+ days|