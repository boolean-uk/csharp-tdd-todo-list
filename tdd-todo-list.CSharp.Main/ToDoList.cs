using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Core Requirements:

I want to add tasks to my todo list.
I want to see all the tasks in my todo list.
I want to change the status of a task between incomplete and complete.
I want to be able to get only the complete tasks.
I want to be able to get only the incomplete tasks.
I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
I want to remove tasks from my list.
I want to see all the tasks in my list ordered alphabetically in ascending order.
I want to see all the tasks in my list ordered alphabetically in descending order.
*/


/*
Domain Model:

Class Task
    id
    title
    isComplete

Class TodoList
    tasks
    lastUsedId

    addTask(title)
        if title is empty
            return null
        task = new Task()
        task.id = lastUsedId++
        task.title = title
        task.isComplete = false
        tasks.add(task)
        return task

    tasks() // return tasks

    setTaskCompleted(taskId, isCompleted)
        task = tasks.find(task => task.id == taskId)
        if task is null
            return false
        task.isComplete = isCompleted
        return true

    getCompletedTasks()
        return tasks.find(task => task.isComplete == true)

    getIncompleteTasks()
        return tasks.find(task => task.isComplete == false)

    getTask(taskId)
        if taskId < 0 or taskId >= tasks.count or taskId != tasks[taskId].id
            return null
        return tasks.find(task => task.id == taskId)

    removeTask(taskId)
        task = tasks.find(task => task.id == taskId)
        if task is null
            return false
        tasks.remove(task)
        return true

    getTasksInAscendingOrder() // returns a list of tasks in ascending order

    getTasksInDescendingOrder() // returns a list of tasks in descending order
*/


namespace tdd_todo_list.CSharp.Main
{
    public class Task
    {
        public int id;
        public string title;
        public bool isComplete;
    }
    public class TodoList
    {
        private int lastUsedId = 0;
        private List<Task> _tasks = new List<Task>();

        public Task AddTask(string title)
        {
            if (title == "")
            {
                return null;
            }
            Task task = new Task();
            task.id = lastUsedId++;
            task.title = title;
            task.isComplete = false;
            _tasks.Add(task);
            return task;
        }

        public List<Task> Tasks()
        {
            return _tasks;
        }

        public bool SetTaskCompleted(int taskId, bool isCompleted)
        {
            Task task = _tasks.Find(t => t.id == taskId);
            if (task == null)
            {
                return false;
            }
            task.isComplete = isCompleted;
            return true;
        }

        public List<Task> GetCompletedTasks()
        {
            return _tasks.FindAll(t => t.isComplete == true);
        }

        public List<Task> GetIncompleteTasks()
        {
            return _tasks.FindAll(t => t.isComplete == false);
        }

        public Task GetTask(int taskId)
        {
            if (taskId < 0 || taskId >= _tasks.Count || taskId != _tasks[taskId].id)
            {
                return null;
            }
            return _tasks.Find(t => t.id == taskId);
        }

        public bool RemoveTask(int taskId)
        {
            Task task = _tasks.Find(t => t.id == taskId);
            if (task == null)
            {
                return false;
            }
            _tasks.Remove(task);
            return true;
        }

        public List<Task> GetTasksInAscendingOrder()
        {
            return _tasks.OrderBy(t => t.title).ToList();
        }

        public List<Task> GetTasksInDescendingOrder()
        {
            return _tasks.OrderByDescending(t => t.title).ToList();
        }

    }
}










