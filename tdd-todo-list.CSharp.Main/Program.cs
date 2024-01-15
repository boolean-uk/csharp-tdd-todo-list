using tdd_todo_list.CSharp.Main;

TodoList core = new TodoList();
core.addTask("Cut firewood", 111);
core.addTask("Get water", 112);
core.addTask("Help grandma", 113);
core.addTask("Plant potatoes",114);
core.addTask("Make soup", 115);
core.addTask("Fix hole in roof", 116);
core.addTask("Go to market", 117);
core.searchTask("Get water");
TodoListExtension extension = new TodoListExtension();
extension.addTask("Cut firewood", 111);
extension.addTask("Get water", 112);
extension.addTask("Help grandma", 113);
extension.addTask("Plant potatoes", 114);
extension.completeTask(111);
extension.getTimeOf(112);