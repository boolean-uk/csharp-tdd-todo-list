using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using System.Runtime.CompilerServices;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void testAddTask()
        {
            string testInput = "Test";
            TodoList todoList = new TodoList();
            todoList.Add(testInput);


            Todo createdTask = todoList.tasks[0];
            // check that desc == testInput
            Assert.That(createdTask.description, Is.EqualTo(testInput));

            // check that status == false
            Assert.That(createdTask.done, Is.EqualTo(false));

            // check that id == 1
            Assert.That(createdTask.id, Is.EqualTo(1));
            // Check that 1 task has been added to todoList
            Assert.AreEqual(1, todoList.tasks.Count);
        }


        [Test]
        public void testGetTasks()
        {

            TodoList todoList = new TodoList();
            todoList.Add("Test");
            // check that a list of Todos has been return
            Assert.That(todoList.Tasks(), Is.InstanceOf<List<Todo>>());
            // check that the returned list is of length 1
            Assert.That(todoList.tasks.Count, Is.EqualTo(1));

        }

        [Test]
        public void testChangeStatus()
        {
            TodoList todoList = new TodoList();
            todoList.Add("Test");

            int nrOfTodos = todoList.tasks.Count - 1;
            int id = todoList.tasks[nrOfTodos].id;


            Assert.That(todoList.tasks[nrOfTodos].done, Is.False);
            todoList.ChangeStatus(id);

            Assert.That(todoList.tasks[nrOfTodos].done, Is.True);

            //Change back to false and check
            todoList.ChangeStatus(id);
            Assert.That(todoList.tasks[nrOfTodos].done, Is.False);

        }

        [Test]
        public void testCompletedTasks()
        {
            List<Todo> completedTasks;
            TodoList todoList = new TodoList();

            todoList.Add("1");
            todoList.Add("2");
            todoList.Add("3");
            todoList.Add("4");

            // test that a empty list is returned if no tasks are done
            completedTasks = todoList.CompletedTasks();
            Assert.That(completedTasks.Count, Is.EqualTo(0));


            // test that all of the returned tasks has done == true
            todoList.ChangeStatus(1);
            todoList.ChangeStatus(3);
            todoList.ChangeStatus(4);
            completedTasks = todoList.CompletedTasks();
            foreach (Todo todo in completedTasks)
            {
                Assert.That(todo.done, Is.True);
            }

            //Check that the list count is not 0
            Assert.That(completedTasks.Count, Is.Not.EqualTo(0));
        }

        [Test]
        public void testIncompleteTasks()
        {
            List<Todo> incompleteTasks;
            TodoList todoList = new TodoList();

            //Test that an empty list is return if only done tasks are present
            todoList.Add("1");
            todoList.Add("2");
            todoList.ChangeStatus(1);
            todoList.ChangeStatus(2);
            incompleteTasks = todoList.IncompleteTasks();
            Assert.That(incompleteTasks.Count, Is.EqualTo(0));


            todoList.Add("3");
            incompleteTasks = todoList.IncompleteTasks();
            foreach (Todo todo in incompleteTasks)
            {
                Assert.That(todo.done, Is.False);
            }
            //Check that the list count is not 0
            Assert.That(incompleteTasks.Count, Is.Not.EqualTo(0));
        }

        [Test]
        public void testSearchTask()
        {
            TodoList todoList = new TodoList();
            // add an id
            todoList.Add("1");

            // search for exisiting id
            todoList.SearchTask(1);
            Assert.That(todoList.SearchTask(1), Is.EqualTo(""));

            //serach for non exsisiting id
            Assert.That(todoList.SearchTask(2), Is.EqualTo("Id:2 was not found"));
        }

        [Test]
        public void TestRemove() {
            
            TodoList todoList = new TodoList();
            todoList.Add("1");
            todoList.Add("2");

            // Test removing non exisiting id
            todoList.Remove(3);
            Assert.That(todoList.tasks.Count, Is.EqualTo(2));

            // Test removing id
            todoList.Remove(1);
            Assert.That(todoList.tasks.Count, Is.EqualTo(1));

            // Check that the specified id was removed
            for (int i = 0; i < todoList.tasks.Count; i++)
            {
                Assert.That(todoList.tasks[i].id, Is.Not.EqualTo(1));
            }

        }

        [Test]
        public void TestTasksAcending()
        {
            TodoList todoList = new TodoList();
            List<Todo> acendingTasks = new List<Todo>();
            todoList.Add("3");
            todoList.Add("1");
            todoList.Add("2");
            todoList.Add("b");
            todoList.Add("c");
            todoList.Add("a");
            acendingTasks = todoList.TasksAcending();

            string[] expectedStringArr = { "1", "2", "3", "a", "b", "c" };
            string[] acutallStringArr = new string[todoList.tasks.Count];

            for (int i = 0; i < acutallStringArr.Length;i++)
            {
                acutallStringArr[i] = acendingTasks[i].description;
            }

            Assert.That(acutallStringArr, Is.EqualTo(expectedStringArr));
        }

        [Test]
        public void TestTasksDecending()
        {
            TodoList todoList = new TodoList();
            List<Todo> decendingTasks = new List<Todo>();
            todoList.Add("3");
            todoList.Add("1");
            todoList.Add("2");
            todoList.Add("b");
            todoList.Add("c");
            todoList.Add("a");
            decendingTasks = todoList.TasksDecending();

            string[] expectedStringArr = { "c", "b", "a", "3", "2", "1" };
            string[] acutallStringArr = new string[todoList.tasks.Count];

            for (int i = 0; i < acutallStringArr.Length; i++)
            {
                acutallStringArr[i] = decendingTasks[i].description;
            }

            Assert.That(acutallStringArr, Is.EqualTo(expectedStringArr));
        }
    }
}