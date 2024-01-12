### Domain model

|  Classes  |  Members           | Methods                            | Returns              |
|-----------|--------------------|------------------------------------|--------------------- |
|ToDoList   | List<Task>         | Add(string description)            |(adds to the list)    |
|           |                    | ListAll                            | List of tasks        |
|           |                    | MarkAsComplete(string desc)        |(marks as complete)   |
|           |                    | MarkAsIncomplete(string desc)      |(marks as incomplete) |
|           |                    | GetCompleted()                     |                      |
|           |                    | GetNotCompleted()                  |                      |
|           |                    | search(string desc)                |""Task present!"" if  |
|           |                    |                                    |in List,              |
|           |                    |                                    |"Task missing!" if not|
|           |                    | Remove(string description)         |(removes task)        |
|           |                    | Ascending()                        |(sorts tasks          |
|           |                    |                                    | alphabetically)      |
|           |                    | Descending()                       |(sorts tasks desc.    |
|           |                    |                                    | alphabetically)      |
|-----------|--------------------|------------------------------------|----------------------|
|Task       | bool done          |                                    |                      |
|           | string description |                                    |                      |