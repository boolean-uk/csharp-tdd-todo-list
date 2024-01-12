using tdd_todo_list.CSharp.Main;

TodoList core = new TodoList();
core.addTask("Help Grandma", 111);
core.addTask("Cut firewood", 112);
core.addTask("Get water", 113);
core.addTask("Make soup",114);
core.addTask("Build shed",115);
core.addTask("Go to market",116);
core.completeTask(111);
core.SeeTasks();