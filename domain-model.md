1.
| Methods               | Member variables  | Scenario       | Outputs/Results/Return values |
|-----------------------|-------------------|----------------|-------------------------------|
| addTasks(String task) | List<string> toDoList | if task is new | True                          |
|                       |                   | if task exist  | false                         |
|                       |                   |                |

2.
| Methods        | Member variables  | Scenario          | Outputs/Results/Return values |
|----------------|-------------------|-------------------|-------------------------------|
| showToDoList() | List<string> ToDoList | if list empty     | false                         |
|                |                   | if list not empty | true                          |

3.
| Methods                   | Member variables       | Scenario                         | Outputs/Results/Return values |
|---------------------------|------------------------|----------------------------------|-------------------------------|
| changeStatus(String task) | Dictionary(String,String) | if task is changed to incomplete | True                          |
|                           |                        | if task is changed to complete   | True                          |

4.
| Methods           | Member variables        | Scenario                  | Outputs/Results/Return values |
|-------------------|-------------------------|---------------------------|-------------------------------|
| getCompleteTask() | Dictionary(String, String) | if task get is complete   | True                          |
|                   | string complete         | if task get is incomplete | false                         |
|                   |                         |                           |

5.
| Methods             | Member variables        | Scenario                  | Outputs/Results/Return values |
|---------------------|-------------------------|---------------------------|-------------------------------|
| getInCompleteTask() | Ditctionary(String, String) | if task get is incomplete | True                          |
|                     | string incomplete       | if task get is complete   | false                         |
|                     |                         |                           |

6.
| Methods      | Member variables        | Scenario                  | Outputs/Results/Return values                 |
|--------------|-------------------------|---------------------------|-----------------------------------------------|
| searchTask() | Ditctionary(String, String) | if task is found          | Message(): "Task: " + task + "is found";      |
| Message()    |                         | if task get is incomplete | Message(): "Task: " + task + "does not exist" |
|              |                         |                           |

7.
| Methods                 | Member variables  | Scenario               | Outputs/Results/Return values |
|-------------------------|-------------------|------------------------|-------------------------------|
| removeTask(String task) | List<string> toDoList | if task is removed     | True                          |
|                         |                   | if task is not removed | false                         |
|                         |                   |                        |

8.
| Methods              | Member variables  | Scenario           | Outputs/Results/Return values |
|----------------------|-------------------|--------------------|-------------------------------|
| listAsc(String task) | List<string> toDoList | if task is asc     | True                          |
|                      |                   | if task is not asc | false                         |
|                      |                   |                    |

8.
| Methods              | Member variables  | Scenario           | Outputs/Results/Return values |
|----------------------|-------------------|--------------------|-------------------------------|
| listDec(String task) | List<string> toDoList | if task is dec     | True                          |
|                      |                   | if task is not dec | false                         |
|                      |                   |                    |

