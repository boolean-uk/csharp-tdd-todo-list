using tdd_todo_list.CSharp.Main;

TodoList core = new TodoList();
core.addTask("Cut firewood", 111);
core.addTask("Go fishing",112);
core.completeTask(112);
core.SeeCompleteTasks();
