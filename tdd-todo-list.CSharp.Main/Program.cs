// See https://aka.ms/new-console-template for more information
using tdd_todo_list.CSharp.Main;


//Setup Core


TodoTask task1 = new TodoTask("Workout", "Mindset");
TodoTask task2 = new TodoTask("Study", "Grindset");
TodoTask task3 = new TodoTask("Trash", "Take out trash");

TodoList todoList = new TodoList();
todoList.AddTask(task1);
todoList.AddTask(task2);
todoList.AddTask(task3);

todoList.ShowTasks();

