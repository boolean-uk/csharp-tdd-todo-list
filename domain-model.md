# Todo List

### Domain model (Core)

For storing our to do list, it makes sense to use a dictionary in this case, as the requirements only need us
to store the task (just the name), and a boolean for seeing if it is complete or not.

There is also no requirement of wanting to store several tasks of the same name, so it is fine to assume that
you cannot add several tasks of the same name.

For wanting to add more properties about a task, you could add a dictionary as a value, with string task being
the key, or create a TodoTask class and create objects out of it, though the former might be more performance efficient.

However, the task requires you to see tasks ordered in an ascending or descending order, dictionaries can't do
this by default, but we can use a SortedDictionary class just for this purpose. It could also make sense
to just store the todo list as a SortedDictionary to begin with, though it will not be as fast as a regular dict
(O(log n) vs O(1) retrieval speed). Especially true if this list is mainly being up on a view with sorting options.

Some of the user stories say "I want to see ...", here I am focusing on just creating what they want to see with
a method or property retrieval. In order to show them, I could also send the result of this retrieval to a
terminal print in a very simple case, or to whatever UI the todo list might be using in this theoretical scenario.

| Members                              | Methods                           | Scenario                  | Output    |
|--------------------------------------|-----------------------------------|---------------------------|-----------|
| `SortedDictionary<string, bool> todoList`  | `add(string task, bool status)`   | adding task to the list   | nothing   |
|  ***string task***                   | `toDoList.get()` ***property***   | get the todo list         | SortedDictionary |
|  ***bool status***                   | `change(string task, bool status)`| change status of task     | nothing   |
|                                      | `getComplete()`                   | get complete tasks        | list      |
|                                      | `getIncomplete()`                 | get incomplete tasks      | list      |
|                                      | `getTask(string task)`            | task was found            | name of task |
|                                      |                                   | task was not found        | "not found"|
|                                      | `remove(string task)`             | task was found            | true      |
|                                      |                                   | task was not found        | false     |
|                                      | `getTasksAscending()`             | ascending order of tasks  | SortedDictionary |
|                                      | `getTasksDescending()`            | descending order of tasks | SortedDictionary |


### Domain Model (Extension)

These requirements changes the structure needed quite a bit from our core program. While not completely clear
in the requirements, it seems like the requirements do not want you to use the name of the task as a unique ID.
It also requires more information about the given task, such as seeing the date and time that it was created.

To solve this, we should ideally just start using a Class for storing tasks as it is more simple. If we had solved the
previous task using a class for tasks, the program would have been quite a lot more simple to modify. As this is an exercise,
and explicitly mentions that we should not continue working on the same classes as from the core requirement,
I guess it's fine to just use a new data structure.

Since every task is supposed to be callable by ID it could make sense to use a dictionary, as this has quite
fast lookup on ID. The ID key could then point to a tuple with information about the task.

We'll create a new domain model just for the extension requirements. In a real world scenario, you would be looking
into modifying your data structure (by using a Class hopefully), and you would want to make sure that all
the old methods work with the extension as well.

The 4th requirement for wanting to see the date and time for each task means, as I see it, that the user wants
this data to be stored, and callable afterwards, not that they want a function for listing up the date and time
for all tasks.

| Members                                               | Methods                           | Scenario              | Output    |
|-------------------------------------------------------|-----------------------------------|-----------------------|-----------|
| `Dictionary<int, (string, bool, DateTime)> todoList`  | `getTask(int id)`                 | get task from id      | tuple     |
|                                                       | `updateTask(int id, string name`  | update task name      | nothing   |
|                                                       | `changeStatus(int id)`            | reverses the status   | bool      |
|                                                       | `getDateAndTime(id)`              | gets date and time for a task | DateTime |