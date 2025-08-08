using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using TodoTask = tdd_todo_list.CSharp.Main.TodoTask;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        // 1. I want to add tasks to my todo list.
        [Test]
        public void AddTask()
        {
            // arrange 
            TodoList todoList = new TodoList();

            // act
            TodoTask newTask = new TodoTask { Name = "walk the dog"};
            todoList.Tasks.Add(newTask);

            // assert
            Assert.IsTrue(1 == todoList.Tasks.Count);
        }

        // 2. I want to see all the tasks in my todo list.
        [Test]
        public void SeeTasks()
        {
            // arrange 
            TodoList todoList = new TodoList();
            TodoTask task1 = new TodoTask { Name = "walk the dog"};
            TodoTask task2 = new TodoTask { Name = "buy groceries"};
            todoList.Tasks.Add(task1);
            todoList.Tasks.Add(task2);

            // act
            var allTasks = todoList.Tasks;

            // assert
            Assert.That(allTasks, Has.Count.EqualTo(2));
            Assert.That(allTasks[0].Name, Is.EqualTo("walk the dog"));
        }

        // 3. I want to change the status of a task between incomplete and complete.
        [Test]
        public void ChangeTaskStatus()
        {
            // arrange
            TodoList todoList = new TodoList();
            TodoTask newTask = new TodoTask { Name = "walk the dog" };
            todoList.Tasks.Add(newTask);
            // store the isComplete status before changing
            string initialStatus = newTask.IsComplete.ToString();

            // act
            newTask.IsComplete = true;

            // assert
            Assert.IsTrue(newTask.IsComplete);
            Assert.AreNotEqual(initialStatus, newTask.IsComplete.ToString());
        }

        // 4. I want to be able to get only the complete tasks.
        [Test]
        public void GetCompletedTasks()
        {
            // arrange
            TodoList todoList = new TodoList();
            TodoTask newTask1 = new TodoTask { IsComplete = true };
            TodoTask newTask2 = new TodoTask { IsComplete = false };
            TodoTask newTask3 = new TodoTask { IsComplete = true };
            todoList.Tasks.Add(newTask1);
            todoList.Tasks.Add(newTask2);
            todoList.Tasks.Add(newTask3);

            // act
            var completedTasks = todoList.CompletedTasks; // retrieves the filtered list

            // assert
            Assert.That(completedTasks, Has.Count.EqualTo(2));
        }

        // 5. I want to be able to get only the incomplete tasks.
        [Test]
        public void GetIncompleteTasks()
        {
            // arrange
            TodoList todoList = new TodoList();
            TodoTask newTask1 = new TodoTask { IsComplete = true };
            TodoTask newTask2 = new TodoTask { IsComplete = false };
            TodoTask newTask3 = new TodoTask { IsComplete = true };
            todoList.Tasks.Add(newTask1);
            todoList.Tasks.Add(newTask2);
            todoList.Tasks.Add(newTask3);

            // act
            var completedTasks = todoList.InCompletedTasks; // retrieves the filtered list

            // assert
            Assert.That(completedTasks, Has.Count.EqualTo(1));
        }

        // 6. I want to search for a task and receive a message that says it wasn't found if it doesn't exist.
        [Test]
        public void SearchForTask()
        {
            // arrange
            TodoList todoList = new TodoList();
            TodoTask newTask1 = new TodoTask { Name = "walk the dog" };
            todoList.Tasks.Add(newTask1);

            // act
            var foundResult = todoList.FindTaskByName("walk the dog");
            var noResultFound = todoList.FindTaskByName("feed the fish");

            // assert
            Assert.That(foundResult, Is.EqualTo("walk the dog"));
            Assert.That(noResultFound, Is.EqualTo("Task not found"));                   
        }

        // 7. I want to remove tasks from my list.
       [Test]
        public void RemoveTask()
        {
            // arrange 
            TodoList todoList = new TodoList();

            // act
            TodoTask newTask1 = new TodoTask { Name = "walk the dog" };
            TodoTask newTask2 = new TodoTask { Name = "do the laundry" };
            todoList.Tasks.Add(newTask1);
            todoList.Tasks.Add(newTask2);

            todoList.Tasks.Remove(newTask1);

            // assert
            Assert.IsTrue(todoList.Tasks.Count == 1);
        }

        // 8. I want to see all the tasks in my list ordered alphabetically in ascending order.
        [Test]
        public void SeeTasksOrderedAlphabetically()
        {
            // arrange           
            TodoList todoList = new TodoList();
            TodoTask task1 = new TodoTask { Name = "walk the dog" };
            TodoTask task2 = new TodoTask { Name = "buy groceries" };
            todoList.Tasks.Add(task1);
            todoList.Tasks.Add(task2);
            // act
            var orderedTasks = todoList.Tasks.OrderBy(t => t.Name).ToList();
            // assert
            Assert.That(orderedTasks[0].Name, Is.EqualTo("buy groceries"));
            Assert.That(orderedTasks[1].Name, Is.EqualTo("walk the dog"));
        }

        // 9. I want to see all the tasks in my list ordered alphabetically in descending order.
        [Test]
        public void SeeTasksOrderedAlphabeticallyDesc()
        {
            // arrange           
            TodoList todoList = new TodoList();
            TodoTask task1 = new TodoTask { Name = "walk the dog" };
            TodoTask task2 = new TodoTask { Name = "buy groceries" };
            todoList.Tasks.Add(task1);
            todoList.Tasks.Add(task2);
            
            // act
            var orderedTasksDesc = todoList.Tasks.OrderByDescending(t => t.Name).ToList();
            
            // assert
            Assert.That(orderedTasksDesc[0].Name, Is.EqualTo("walk the dog"));
            Assert.That(orderedTasksDesc[1].Name, Is.EqualTo("buy groceries"));
        }

        // 10. I want to prioritise tasks e.g. low, medium, high
        [Test]
        public void PrioritizeTasks()
        {
            // arrange
            TodoList todoList = new TodoList();
            TodoTask task1 = new TodoTask { Priority = Priority.high };
            todoList.Tasks.Add(task1);

            // act

            // assert
            Assert.That(task1.Priority == Priority.high);
        }

        // 11. I want to list all tasks by priority
        [Test]
        public void SeeTasksByPriority()
        {
            // arrange
            TodoList todoList = new TodoList();
            TodoTask task1 = new TodoTask { Priority = Priority.high };
            TodoTask task2 = new TodoTask { Priority = Priority.low };
            TodoTask task3 = new TodoTask { Priority = Priority.medium };
            todoList.Tasks.Add(task1);
            todoList.Tasks.Add(task2);
            todoList.Tasks.Add(task3);

            // act
            var prioritizedTasks = todoList.TasksByPriority;

            // assert
            Assert.That(prioritizedTasks[0].Priority, Is.EqualTo(task1.Priority));
            Assert.That(prioritizedTasks[1].Priority, Is.EqualTo(task3.Priority));
            Assert.That(prioritizedTasks[2].Priority, Is.EqualTo(task2.Priority));
        }
    }
}