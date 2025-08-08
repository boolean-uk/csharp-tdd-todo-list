

using NUnit.Framework;
using tdd_todo_list.CSharp.Main;
using Task = tdd_todo_list.CSharp.Main.Task;

DateTime now = DateTime.Now;
DateTime day = DateTime.Now.AddDays(1);
DateTime day2 = DateTime.Now.AddDays(2);
TodoList list = new TodoList();

Task task1 = new Task("1", "Water plants", 1, false, "Gardening");
Task task2 = new Task("2", "Fix car", 2, false, "Work");
Task task3 = new Task("1", "Take out trash", 1, true, "Work");
Task task4 = new Task("2", "Paint house", 3, false, "Work");



list.AddTask("1", task1);
list.AddTask("2", task2);
list.AddTask("3", task3);
list.AddTask("4", task4);


list.printAllTasks();

