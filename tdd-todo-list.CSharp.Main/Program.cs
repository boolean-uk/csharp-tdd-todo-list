using tdd_todo_list.CSharp.Main;

TodoList list = new TodoList();
TodoListExtension extension = new TodoListExtension();

TodoList todoList = new TodoList();

todoList.add("Hello");
todoList.add("New test");
todoList.add("Last test");
todoList.printAscending();