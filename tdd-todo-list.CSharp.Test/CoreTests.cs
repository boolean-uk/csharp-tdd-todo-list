using System.Diagnostics;
using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using Task = tdd_todo_list.CSharp.Main.Task;
using TaskStatus = tdd_todo_list.CSharp.Main.TaskStatus;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        [Test]
        public void AddTask()
        {
            // Arrange
            TodoList todo = new TodoList();
            Task task = new Task("TaskName", "TaskDescription");

            // Act
            todo.AddTask(task);

            // Assert
            Debug.Assert(todo.ListTasks()[0].Equals(task));
        }

        [Test]
        public void ListTasksTests()
        {
            // Arrange
            TodoList todo = new TodoList();

            Task[] tasks =
            [
                new("Task1", "Task1 description"),
                new("Task2", "Task2 description"),
                new("Task3", "Task3 description"),
            ];

            foreach (Task task in tasks)
            {
                todo.AddTask(task);
            }

            // Act
            var taskList = todo.ListTasks();

            // Assert
            Debug.Assert(taskList.Count == tasks.Length);
            for (int i = 0; i < taskList.Count; i++)
            {
                Debug.Assert(tasks[i].Equals(taskList[i]));
            }
        }

        [TestCase(TaskStatus.Incomplete, TaskStatus.Complete)]
        [TestCase(TaskStatus.Complete, TaskStatus.Incomplete)]
        public void SetTaskStatusTest(TaskStatus startStatus, TaskStatus endStatus)
        {
            // Arrange
            TodoList todo = new TodoList();
            Task task = new Task("TaskName", "TaskDescription", startStatus);
            todo.AddTask(task);

            // Act
            todo.SetTaskStatus(task.Name, endStatus);

            // Assert
            Debug.Assert(todo.ListTasks()[0].Status == endStatus);
        }

        [Test]
        public void ListCompletedTasksTest()
        {
            // Arrange
            TodoList todo = new TodoList();
            Task[] tasks =
            [
                new("Task1", "Task1 description", TaskStatus.Complete),
                new("Task2", "Task2 description", TaskStatus.Complete),
                new("Task3", "Task3 description", TaskStatus.Incomplete)
            ];

            foreach (Task task in tasks)
            {
                todo.AddTask(task);
            }

            // Act
            List<Task> completedTasks = todo.ListCompletedTasks();

            // Assert
            for (int i = 0; i < completedTasks.Count; i++)
            {
                Debug.Assert(tasks[i].Equals(completedTasks[i]));
            }
        }

        [Test]
        public void ListIncompleteTasksTest()
        {
            // Arrange
            TodoList todo = new TodoList();
            Task[] tasks =
            [
                new("Task1", "Task1 description"),
                new("Task2", "Task2 description"),
                new("Task3", "Task3 description", TaskStatus.Complete)
            ];

            foreach (Task task in tasks)
            {
                todo.AddTask(task);
            }

            // Act
            List<Task> incompleteTasks = todo.ListIncompleteTasks();

            // Assert
            for (int i = 0; i < incompleteTasks.Count; i++)
            {
                Debug.Assert(tasks[i].Equals(incompleteTasks[i]));
            }
        }

        [Test]
        public void FindTaskTestSuccess()
        {
            // Arrange
            TodoList todo = new TodoList();
            Task[] tasks =
            [
                new("Task1", "Task1 description", TaskStatus.Complete),
                new("Task2", "Task2 description", TaskStatus.Complete),
                new("Task3", "Task3 description", TaskStatus.Incomplete)
            ];

            foreach (Task task in tasks)
            {
                todo.AddTask(task);
            }

            // Act
            Task? foundTask = todo.FindTask(tasks[1].Name);

            // Assert
            Debug.Assert(foundTask?.Name == tasks[1].Name);
        }
        
        [Test]
        public void RemoveTaskTest()
        {
            // Arrange
            TodoList todo = new TodoList();
            Task task = new Task("TaskName", "TaskDescription");

            todo.AddTask(task);

            // Act
            todo.RemoveTask(task.Name);

            // Assert
            Debug.Assert(todo.ListTasks().Count == 0);
        }

        [Test]
        public void ListTasksAlphabeticallyOrderedByAscendingTest()
        {
            // Arrange
            TodoList todo = new TodoList();

            Task[] unordered =
            [
                new("ATask1", "Task1 description", TaskStatus.Complete),
                new("CTask2", "Task2 description", TaskStatus.Complete),
                new("BTask3", "Task3 description", TaskStatus.Incomplete)
            ];
            
            Task[] ordered =
            [
                new("ATask1", "Task1 description", TaskStatus.Complete),
                new("BTask3", "Task3 description", TaskStatus.Incomplete),
                new("CTask2", "Task2 description", TaskStatus.Complete)
            ];


            foreach (Task task in unordered)
            {
                todo.AddTask(task);
            }

            // Act
            List<Task> tasks = todo.ListTasksAlphabeticallyOrderedByAscending();

            // Assert
            for (int i = 0; i < tasks.Count; i++)
            {
                Debug.Assert(tasks[i].Equals(ordered[i]));
            }
        }

        [Test]
        public void ListTasksAlphabeticallyOrderedByDescendingTest()
        {
            // Arrange
            TodoList todo = new TodoList();

            Task[] unordered =
            [
                new("ATask1", "Task1 description", TaskStatus.Complete),
                new("CTask2", "Task2 description", TaskStatus.Complete),
                new("BTask3", "Task3 description", TaskStatus.Incomplete),
            ];
            
            Task[] ordered =
            [
                new("CTask2", "Task2 description", TaskStatus.Complete),
                new("BTask3", "Task3 description", TaskStatus.Incomplete),
                new("ATask1", "Task1 description", TaskStatus.Complete),
            ];


            foreach (Task task in unordered)
            {
                todo.AddTask(task);
            }

            // Act
            List<Task> tasks = todo.ListTasksAlphabeticallyOrderedByDescending();

            // Assert
            for (int i = 0; i < tasks.Count; i++)
            {
                Debug.Assert(tasks[i].Equals(ordered[i]));
            }
        }

        [Test]
        public void SetTaskPriorityTest()
        {
            // Arrange
            const TaskPriority TARGET_PRIORITY = TaskPriority.High;
            TodoList todo = new TodoList();
            Task task = new Task("TaskName", "TaskDescription");
            todo.AddTask(task);

            // Act
            todo.SetTaskPriority(task.Name, TARGET_PRIORITY);
            
            // Assert
            Debug.Assert(todo.FindTask(task.Name)?.Priority == TARGET_PRIORITY);
        }

        [Test]
        public void ListTasksByPriorityTest()
        {
            // Arrange
            TodoList todo = new TodoList();

            Task[] unordered =
            [
                new("ATask1", "Task1 description", TaskStatus.Complete, TaskPriority.High),
                new("CTask2", "Task2 description", TaskStatus.Complete, TaskPriority.Low),
                new("BTask3", "Task3 description", TaskStatus.Incomplete, TaskPriority.Medium),
            ];
            
            Task[] ordered =
            [
                new("ATask1", "Task1 description", TaskStatus.Complete, TaskPriority.High),
                new("BTask3", "Task3 description", TaskStatus.Incomplete, TaskPriority.Medium),
                new("CTask2", "Task2 description", TaskStatus.Complete, TaskPriority.Low),
            ];


            foreach (Task task in unordered)
            {
                todo.AddTask(task);
            }

            // Act
            List<Task> tasks = todo.ListTasksByPriority();

            // Assert
            for (int i = 0; i < tasks.Count; i++)
            {
                Debug.Assert(tasks[i].Equals(ordered[i]));
            }
        }
    }
}