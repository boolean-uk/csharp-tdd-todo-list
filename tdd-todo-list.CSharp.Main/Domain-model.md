I want to add tasks to my todo list.
I want to see all the tasks in my todo list.
I want to change the status of a task between incomplete and complete.

Class Task

PROPERTIES:
string name
bool status

METHODS:

Class TodoList

PROPERTIES:
List<string> taskList

METHODS:
void AddTask(List<string>(taskList), Task.name)
List<string> SeeTasks() return: taskList
bool ChangeStatus() return: status

I want to be able to get only the complete tasks

