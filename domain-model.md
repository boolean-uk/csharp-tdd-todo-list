> Note that this does not reflect actuall solution as changes has been made to classes.

| Class | Feature | Method/Property | Input | Output |
|-------|---------|-----------------|-------|--------|
| List | Add task to list | addTask() | Task() |  |
| List | Edit status on task | setStatus() | Task(), Bool | Bool |
| List | Edit status on task by ID | setStatusOnTask() | int, Bool | Bool |
| List | Remove task from list | removeTask() | int | Bool |
| List | Get smallest/largest time delta | getTimeDelta() | Bool | TimeSpan |
| List | Get all tasks | getAllTasks() |  | [Task()] |
| List | Get all tasks in ascending/descending order | getAllTasks() | Bool | [Task()] |
| List | Get all completed/incomplete tasks | getAllTasks() | Bool | [Task()] |
| List | Get task by search | getTask() | String | Task() / Error |
| List | Get task by ID | getTask() | int | Task() / Error |
| Task | Set task priority | _priority | Enum |  |
| Task | Set task ID | _uid | int |  |
| Task | Set task name | _name | string |  |
| Task | Set task description | _text | string |  |
| Task | See creation date/time | _created | DateTime |  |
| Task | See completion date/time | _completed | DateTime |  |