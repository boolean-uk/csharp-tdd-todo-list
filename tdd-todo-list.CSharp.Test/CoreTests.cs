using NUnit.Framework;
using System.Collections.Generic;
using tdd_todo_list.CSharp.Main;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {
        [Test]
        public void AddedTaskToList()
        {
            //arrange
            ToDoList list = new ToDoList();
            list.AddTask("Test", Priority.High, Category.Work);

            //act
            var tasks = list.GetAllTasks();

            //assert
            Assert.That(tasks[0].Name, Is.EqualTo("Test"));
        }

        [Test]
        public void ShowsAllTasksOnList()
        {
            //arrange
            ToDoList list = new ToDoList();
            list.AddTask("Test1", Priority.High, Category.Work);
            list.AddTask("Test2", Priority.Medium, Category.School);
            list.AddTask("Test3", Priority.Low, Category.Life);

            //act
            var allTasks = list.GetAllTasks();

            //assert
            Assert.That(allTasks.Count, Is.EqualTo(3));

        }

        [Test]
        public void ChangeTaskStatus()
        {
            //arrange
            ToDoList list = new ToDoList();
            list.AddTask("Test", Priority.High, Category.Work);

            //act
            var changed = list.GetAllTasks()[0];
            list.ChangeTaskStatus(changed.Id, true);

            //assert
            Assert.That(changed.IsComplete, Is.True);
        }

        [Test]
        public void GetOnlyCompletedTasks()
        {
            //arrange
            ToDoList list = new ToDoList();
            list.AddTask("Test1", Priority.High, Category.Work);
            list.AddTask("Test2", Priority.Medium, Category.School);

            //act
            var tasks = list.GetAllTasks()[1];
            list.ChangeTaskStatus(tasks.Id, true);

            //assert
            var completedTasks = list.GetCompletedTasks();
            Assert.That(completedTasks[0].Name, Is.EqualTo("Test2"));
        }

        [Test]
        public void GetOnlyInCompletedTasks()
        {
            //arrange
            ToDoList list = new ToDoList();
            list.AddTask("Test1", Priority.High, Category.Work);
            list.AddTask("Test2", Priority.Medium, Category.School);

            //act
            var completedTasks = list.GetInCompletedTasks();

            //assert
            Assert.That(completedTasks.Count, Is.EqualTo(2));
        }

        [Test]
        public void ErrorMessageIfTaskNotFound()
        {
            //arrange
            ToDoList list = new ToDoList();
            list.AddTask("Test1", Priority.High, Category.Work);

            //act
            var search = list.SearchTask("Test32");

            //assert
            Assert.Null(search);
        }

        [Test]
        public void RemoveTaskById()
        {
            //arrange
            ToDoList list = new ToDoList();
            list.AddTask("Test1", Priority.High, Category.Work);
            var task = list.GetAllTasks().First();

            //act
            list.RemoveTask(task.Id);

            //assert
            Assert.That(list.GetAllTasks().Count, Is.EqualTo(0));
        }

        [Test]
        public void GetTasksAscendingAZ()
        {
            //arrange
            ToDoList list = new ToDoList();
            list.AddTask("Bread", Priority.High, Category.Work);
            list.AddTask("Ants", Priority.High, Category.Work);
            list.AddTask("Crab", Priority.High, Category.Work);

            //act
            var ascendingList = list.GetTasksAscendingAZ();

            //assert
            Assert.That(ascendingList[0].Name, Is.EqualTo("Ants"));
            Assert.That(ascendingList[1].Name, Is.EqualTo("Bread"));
            Assert.That(ascendingList[2].Name, Is.EqualTo("Crab"));
        }

        [Test]
        public void GetTasksDescendingAZ()
        {
            //arrange
            ToDoList list = new ToDoList();

            list.AddTask("Bread", Priority.High, Category.Work);
            list.AddTask("Ants", Priority.High, Category.Work);
            list.AddTask("Crab", Priority.High, Category.Work);

            //act
            var ascendingList = list.GetTasksDescendingAZ();

            //assert
            Assert.That(ascendingList[0].Name, Is.EqualTo("Crab"));
            Assert.That(ascendingList[1].Name, Is.EqualTo("Bread"));
            Assert.That(ascendingList[2].Name, Is.EqualTo("Ants"));
        }

        [Test]
        public void ListTasksByPriority()
        {
            //arrange
            ToDoList list = new ToDoList();

            list.AddTask("Test1", Priority.Medium, Category.Work);
            list.AddTask("Test2", Priority.Low, Category.School);
            list.AddTask("Test3", Priority.High, Category.Life);

            //act
            var byPriority = list.GetTasksByPriority();

            //assert
            Assert.That(byPriority[0].Name, Is.EqualTo("Test3"));
            Assert.That(byPriority[1].Name, Is.EqualTo("Test1"));
            Assert.That(byPriority[2].Name, Is.EqualTo("Test2"));
        }
    }
}