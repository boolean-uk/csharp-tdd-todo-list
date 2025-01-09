using NUnit.Framework;
using tdd_todo_list.CSharp.Main;
using Task = tdd_todo_list.CSharp.Main.Task;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void FirstTest()
        {
            TodoList core = new TodoList();
            Assert.Pass();
        }

        [TestCase("Task 1", "Something that just needs to be done")]
        [TestCase("Task 2", "Do some more work")]
        public void TestAddTaskAddsTask(string title, string description)
        {
            TodoList mylist = new TodoList();

            Task t = mylist.Add(title, description);
            Assert.That(t.title, Is.EqualTo(title));
            Assert.That(t.description, Is.EqualTo(description));
            Assert.NotNull(mylist.tasks.FirstOrDefault(x => x.title == title));
        }
        [Test]
        public void TestAddDoesNotAddTasksWithIdenticalTitles()
        {
            TodoList mylist = new TodoList();

            Task t1 = mylist.Add("t1", "work");
            Task t2 = mylist.Add("t1", "run");

            Assert.NotNull(mylist.tasks.FirstOrDefault(x => x.title == "t1" && x.description == "work"));
            Assert.That(mylist.tasks, Has.No.Member(t2));
            
        }

        [TestCase("Task 1", "Something that just needs to be done")]
        [TestCase("Task 2", "Do some more work")]
        public void TestGetAllTasks(string title, string description)
        { 
            TodoList mylist = new TodoList();
            mylist.Add(title, description);
            List<Task> all_tasks = mylist.GetTasks();
            Assert.That(all_tasks, Is.EquivalentTo(mylist.tasks)); //Contains the same elements
            Assert.AreNotSame(all_tasks, mylist.tasks); //Are not the same object
        }

        [TestCase("Task 1", "Something that just needs to be done")]
        [TestCase("Task 2", "Do some more work")]
        [TestCase("", "")]
        public void TestGetTask(string title, string description)
        {
            TodoList mylist = new TodoList();
            Task t1 = mylist.Add(title, description);
            Task t2 = mylist.GetTask(title);

            Assert.True(t1.Equals(t2));//Contains the same information
            Assert.AreNotSame(t2, t1);//Are not the same object
        }

        [TestCase("Task 1", "Run")]
        [TestCase("Task 2", "Code")]
        [TestCase("Task 3", "Jump")]
        [TestCase("Task 4", "")]
        public void TestChangeTask(string title, string description)
        {
            TodoList mylist = new TodoList();
            Task initialTask = mylist.Add(title, description);
            Task updatedTask = mylist.ChangeTask(title, true);
            Task actualTask = mylist.GetTask(title);

            Assert.True(initialTask.title ==  updatedTask.title);
            Assert.True(actualTask.status);
            Assert.AreNotSame(updatedTask, actualTask);
        }

        [Test]
        public void TestCompletedTasks()
        {
            TodoList mylist = new TodoList();

            mylist.Add("Task 1", "Zoom");
            mylist.Add("Task 2", "Have a coffee");
            mylist.Add("Task 3", "Code");
            mylist.Add("Task 4", "Zoom");
            mylist.Add("Task 5", "Lunsj");

            Task done1 = mylist.ChangeTask("Task 1", true);
            Task done2 = mylist.ChangeTask("Task 2", true);

            List<Task> completedTasks = mylist.GetCompletedTasks();

            Assert.AreEqual(2, completedTasks.Count);
            Assert.NotNull(completedTasks.FirstOrDefault(x => x.title == "Task 1" && x.status == true));
            Assert.NotNull(completedTasks.FirstOrDefault(x => x.title == "Task 2" && x.status == true));
        }

        [Test]
        public void TestIncompletedTasks()
        {
            TodoList mylist = new TodoList();

            mylist.Add("Task 1", "Zoom");
            mylist.Add("Task 2", "Have a coffee");
            mylist.Add("Task 3", "Code");
            mylist.Add("Task 4", "Zoom");
            mylist.Add("Task 5", "Lunsj");

            Task done1 = mylist.ChangeTask("Task 1", true);
            Task done2 = mylist.ChangeTask("Task 2", true);

            List<Task> incompleteTasks = mylist.GetIncompleteTasks();

            Assert.AreEqual(3, incompleteTasks.Count);
            Assert.NotNull(incompleteTasks.FirstOrDefault(x => x.title == "Task 3" && x.status == false));
            Assert.NotNull(incompleteTasks.FirstOrDefault(x => x.title == "Task 4" && x.status == false));
            Assert.NotNull(incompleteTasks.FirstOrDefault(x => x.title == "Task 5" && x.status == false));
        }


        [TestCase("Task 1", "Run")]
        [TestCase("Task 2", "Code")]
        [TestCase("Task 3", "Jump")]
        [TestCase("Task 4", "")]
        public void TestRemoveTask(string title, string status)
        {
            TodoList mylist = new TodoList();
            Task addedTask = mylist.Add(title, status);
            Task removedTask = mylist.RemoveTask(title);

            Assert.True(mylist.tasks.Count == 0);
            

        }

        [Test]
        public void TestSortTasks()
        {
            TodoList mylist = new TodoList();

            Task t1 = mylist.Add("a", "");
            Task t2 = mylist.Add("b", "");
            Task t3 = mylist.Add("c", "");

            List<Task> ascendingSort = mylist.SortTasksAlphabetically(true);
            List<Task> descendingSort = mylist.SortTasksAlphabetically(false);

            Assert.That(t1.status, Is.EqualTo(ascendingSort[0].status));
            Assert.That(t2.status, Is.EqualTo(ascendingSort[1].status));
            Assert.That(t3.status, Is.EqualTo(ascendingSort[2].status));

            Assert.That(t1.status, Is.EqualTo(descendingSort[2].status));
            Assert.That(t2.status, Is.EqualTo(descendingSort[1].status));
            Assert.That(t3.status, Is.EqualTo(descendingSort[0].status));


        }




        


    }
}