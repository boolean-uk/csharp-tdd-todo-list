using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void AddTest()
        {
            //Arrange
            TodoList core = new TodoList();

            //Act
            core.addTask("task1");

            //Assert
            Assert.IsTrue(core.tasks.ContainsKey("task1"));
            Assert.AreEqual(0, core.tasks["task1"]);
        }
        [Test]
        public void showAllTasksTest()
        {
            //Arrange
            TodoList core = new TodoList();

            //Act
            core.addTask("task1");
            core.addTask("task2");
            core.addTask("task3");

            //Assert
            Assert.IsTrue(core.showAllTasks().SequenceEqual(new[] { "task1", "task2", "task3" }));

        }
        [Test]
        public void changeStatusOfTaskTest() 
        {
            //Arrange
            TodoList core = new TodoList();

            //Act
            core.addTask("task1");
            core.addTask("task2");
            core.addTask("task3");

            //check all tasks have status 0:
            Assert.IsTrue(core.tasks.Values.SequenceEqual(new[] {0 , 0, 0 }));

            //change status of task1
            core.changeStatus("task1", 1);

            //assert
            Assert.IsTrue(core.tasks.Values.SequenceEqual(new[] { 1, 0, 0 }));

            //Change value of task 1 and 2
            core.changeStatus("task1", 0);
            core.changeStatus("task2", 1);

            //Assert
            Assert.IsTrue(core.tasks.Values.SequenceEqual(new[] { 0, 1, 0 }));


        }
        [Test]
        public void searchForTaskTest() 
        {
            //Arrange
            TodoList core = new TodoList();

            //Act
            core.addTask("task1");
            core.addTask("task2");
            core.addTask("task3");

            //Assert
            Assert.IsTrue(core.searchForTask("task1"));
            Assert.IsTrue(core.searchForTask("task2"));
            Assert.IsTrue(core.searchForTask("task3"));
            Assert.IsFalse(core.searchForTask("task4"));
            Assert.IsFalse(core.searchForTask("task0"));

        }
        [Test]

        public void removeTaskTest() 
        {
            //Arrange
            TodoList core = new TodoList();

            //Act
            core.addTask("task1");
            core.addTask("task2");
            core.addTask("task3");


            //Assert
            Assert.IsTrue(core.tasks.ContainsKey("task1"));
            Assert.IsTrue(core.tasks.ContainsKey("task2"));

            //Remove
            core.removeTask("task1");

            //Check
            Assert.IsFalse(core.tasks.ContainsKey("task1"));
            Assert.IsTrue(core.tasks.ContainsKey("task2"));

            //Remove
            core.removeTask("task2");

            //Check
            Assert.IsFalse(core.tasks.ContainsKey("task1"));
            Assert.IsTrue(core.tasks.ContainsKey("task3"));


        }
        [Test]
        public void showIncompleteTasks() 
        {
            TodoList core = new TodoList();

            //Arrange
            core.addTask("task1");
            core.addTask("task2");
            core.addTask("task3");

            //check if all tasks are returned
            Assert.IsTrue(core.ShowIncompleteTasks().SequenceEqual(new[] { "task1", "task2", "task3" }));

            //change status of task1:
            core.changeStatus("task1", 1);

            //check if we get desired output
            Assert.IsTrue(core.ShowIncompleteTasks().SequenceEqual(new[] { "task2", "task3" }));

            //change status of task2
            core.changeStatus("task3", 1);

            // check again, now only task2 should be returned
            Assert.IsTrue(core.ShowIncompleteTasks().SequenceEqual(new[] { "task2" }));
            

        }

        [Test]
        public void showCompleteTasks()
        {
            TodoList core = new TodoList();

            //Arrange
            core.addTask("task1");
            core.addTask("task2");
            core.addTask("task3");

            //check if all tasks are returned
            Assert.IsTrue(core.ShowCompleteTasks().Count() == 0);

            //change status of task1:
            core.changeStatus("task1", 1);

            //check if we get desired output
            Assert.IsTrue(core.ShowCompleteTasks().SequenceEqual(new[] { "task1" }));

            //change status of task2
            core.changeStatus("task3", 1);

            // check again, now only task2 should be returned
            Assert.IsTrue(core.ShowCompleteTasks().SequenceEqual(new[] { "task1", "task3" }));


        }

        [Test]
        
        //test that 
        public void showTasksAlphabeticAsc() 
        {
            TodoList core = new TodoList();

            //Arrange
            core.addTask("A");
            core.addTask("B");
            core.addTask("X");
            core.addTask("R");
            core.addTask("O");

            //Control that you get desired output:

            Assert.IsTrue(core.showTasksAlphabeticAsc().SequenceEqual(new[] { "A", "B", "O", "R", "X" }));

        }
        [Test]

        //test that 
        public void showTasksAlphabeticDesc()
        {
            TodoList core = new TodoList();

            //Arrange
            core.addTask("A");
            core.addTask("B");
            core.addTask("X");
            core.addTask("R");
            core.addTask("O");

            //Control that you get desired output:

            Assert.IsTrue(core.showTasksAlphabeticDesc().SequenceEqual(new[] { "X", "R", "O", "B", "A" }));

        }

    }
}