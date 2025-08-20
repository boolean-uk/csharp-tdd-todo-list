using tdd_todo_list.CSharp.Main;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TaskStatus = tdd_todo_list.CSharp.Main.TaskStatus;

namespace tdd_todo_list.CSharp.Test
{
    public class ExtensionTests
    {
        [Test]
        public void GetTaskTest()
        {
            // Arrange
            TodoListExtension todo = new TodoListExtension();
            ExtendedTask task = new ExtendedTask("TaskName");
            todo.AddTask(task);

            // Act
            var obtained = todo.GetTask(task.Id);

            // Assert
            Debug.Assert(task.Equals(obtained));
        }

        [Test]
        public void UpdateTaskNameTest()
        {
            // Arrange
            TodoListExtension todo = new TodoListExtension();
            ExtendedTask task = new ExtendedTask("TaskName");
            const string NEW_NAME = "New Name";
            todo.AddTask(task);

            // Act
            todo.UpdateTaskName(task.Id, NEW_NAME);

            // Assert
            Debug.Assert(todo.GetTask(task.Id)?.Name == NEW_NAME);
        }

        [Test]
        public void SetTaskStatusTest()
        {
            // Arrange
            TodoListExtension todo = new TodoListExtension();
            ExtendedTask task = new ExtendedTask("TaskName");
            todo.AddTask(task);

            // Act
            todo.SetTaskStatus(task.Id, TaskStatus.Complete);

            // Assert
            Debug.Assert(todo.GetTask(task.Id)?.Status == TaskStatus.Complete);
        }

        [Test]
        public void GetTaskTimeOfCreationTest()
        {
            // Arrange
            TodoListExtension todo = new TodoListExtension();
            ExtendedTask task = new ExtendedTask("TaskName");
            todo.AddTask(task);

            var expected = task.CreateTime;

            // Act
            var obtained = todo.GetTaskTimeOfCreation(task.Id);

            // Assert
            Debug.Assert(expected == obtained);
        }

        [Test]
        public void GetTaskTimeOfCompletionTest()
        {
            // Arrange
            TodoListExtension todo = new TodoListExtension();
            ExtendedTask task = new ExtendedTask("TaskName");
            todo.AddTask(task);
            todo.SetTaskStatus(task.Id, TaskStatus.Complete);

            // Act
            var obtained = todo.GetTaskTimeOfCreation(task.Id);

            // Assert
            Debug.Assert(obtained != null);
        }

        [Test]
        public void FindLongestCompletedTaskTest()
        {
            // Arrange
            TodoListExtension todo = new TodoListExtension();
            ExtendedTask expected = new("big", 7);
            ExtendedTask[] tasks =
            [
                new("a", 5),
                new("Bla", 3),
                expected,
                new("small", 1)
            ];

            foreach (var t in tasks)
            {
                todo.AddTask(t);
            }

            // Act
            var obtained = todo.FindLongestCompletedTask();

            // Assert
            Debug.Assert(obtained.Equals(expected));
        }
        
        [Test]
        public void FindShortestCompletedTaskTest()
        {
            // Arrange
            TodoListExtension todo = new TodoListExtension();
            ExtendedTask expected = new("small", 1);
            
            ExtendedTask[] tasks =
            [
                new("a", 5),
                new("Bla", 3),
                new("big", 7),
                expected,
            ];

            foreach (var t in tasks)
            {
                todo.AddTask(t);
            }

            // Act
            var obtained = todo.FindShortestCompletedTask();

            // Assert
            Debug.Assert(obtained.Equals(expected));
        }
        
        [Test]
        public void FindTasksCompletedInMoreThan5DaysTest()
        {
            // Arrange
            TodoListExtension todo = new TodoListExtension();
            ExtendedTask[] expected =
            [
                new("a", 5),
                new("Bla", 3),
            ];
            
            ExtendedTask[] badTasks =
            [
                new("Bla", 3),
                new("ba", 1),
            ];

            List<ExtendedTask> tasks = new List<ExtendedTask>();
            tasks.AddRange(expected);
            tasks.AddRange(badTasks);

            foreach (var t in tasks)
            {
                todo.AddTask(t);
            }

            // Act
            var obtained = todo.FindTasksCompletedInMoreThan5Days();
            Debug.Assert(obtained.Count > 0);

            // Assert
            for (int i = 0; i < obtained.Count; i++)
            {
                Debug.Assert(obtained[i].Equals(expected[i]));
            }
        }
        
        [Test]
        public void CategoriseTaskTest()
        {
            // Arrange
            TodoListExtension todo = new TodoListExtension();
            ExtendedTask task = new ExtendedTask("TaskName");
            todo.AddTask(task);
            const TaskCategory EXPECTED = TaskCategory.Admin;

            // Act
            todo.CategoriseTask(task.Id, EXPECTED);

            // Assert
            Debug.Assert(todo.GetTask(task.Id)?.Category == EXPECTED);
        }
        
        [Test]
        public void ListByCategoryTest()
        {
            // Arrange
            TodoListExtension todo = new TodoListExtension();
            ExtendedTask[] input =
            [
                new("a"){Category = TaskCategory.Work},
                new("b"){Category = TaskCategory.Admin},
                new("c"){Category = TaskCategory.Study}
            ];
            
            ExtendedTask[] expected =
            [
                new("c"){Category = TaskCategory.Study},
                new("a"){Category = TaskCategory.Work},
                new("b"){Category = TaskCategory.Admin},
            ];

            foreach (var t in input)
            {
                todo.AddTask(t);
            }

            // Act
            var obtained = todo.ListTasksByCategory();
            Debug.Assert(obtained.Count > 0);

            // Assert
            for (int i = 0; i < obtained.Count; i++)
            {
                Debug.Assert(obtained[i].Equals(expected[i]));
            }
        }
        
    }
}