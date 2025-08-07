// See https://aka.ms/new-console-template for more information
using tdd_todo_list.CSharp.Main;

TodoList todo = new TodoList();

todo.Add("beta");
todo.Add("alpha");
todo.Add("charlie");

List<string> toDoTasks = todo.ViewDescendingAlphabetical();
