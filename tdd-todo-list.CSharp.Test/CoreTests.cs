using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void AddOneTaskTest()
        {
            TodoList core = new TodoList();
            bool result = core.add("Walk the dog");
            List<Todo> list = core.listTasks();
            int listSize = core.listTasks().Count;

            Assert.IsTrue(result);
            Assert.That(listSize == 1); // check if list increased in size by 1
            Assert.That(list.First().id == 1);
        }

        [Test]
        public void AddTwoTasksTest()
        {
            TodoList core = new TodoList();
            bool result1 = core.add("Walk the dog");
            bool result2 = core.add("Walk the cat?");
            List<Todo> list = core.listTasks();
            int listSize = core.listTasks().Count;

            Assert.IsTrue(result1);
            Assert.IsTrue(result2);
            Assert.That(listSize == 2); // check if list increased in size by 1
            Assert.That(list.First().id == 1);
            Assert.That(list.Last().id == 2);
        }

        [Test]
        public void AddThreeTasksTest()
        {
            TodoList core = new TodoList();
            bool result1 = core.add("Walk the dog");
            bool result2 = core.add("Walk the cat?");
            bool result3 = core.add("Walk the tree!?");
            List<Todo> list = core.listTasks();
            int listSize = core.listTasks().Count;

            Assert.IsTrue(result1);
            Assert.IsTrue(result2);
            Assert.IsTrue(result3);
            Assert.That(listSize == 3); // check if list increased in size by 1
            Assert.That(list.First().id == 1);
            Assert.That(list.Last().id == 3);
        }

        [Test]
        public void CompleteTaskTest()
        {
            TodoList core = new TodoList();
            bool result = core.add("Walk the dog");
            List<Todo> list = core.listTasks();
            int listSize = core.listTasks().Count;

            Assert.IsFalse(list.First().Complete);

            core.taskStatus(1);

            Assert.IsTrue(result);
            Assert.That(listSize == 1); // check if list increased in size by 1
            Assert.That(list.First().id == 1);
            Assert.IsTrue(list.First().Complete);
        }

        [Test]
        public void FetchCompleteTasksTest()
        {
            TodoList core = new TodoList();
            bool result1 = core.add("Walk the dog");
            bool result2 = core.add("Walk the cat?");
            List<Todo> list = core.listTasks();
            int listSize = core.listTasks().Count;

            Assert.IsFalse(list.First().Complete);

            core.taskStatus(1);

            Assert.IsTrue(result1);
            Assert.IsTrue(result2);
            Assert.That(listSize == 2); // check if list increased in size by 1
            Assert.That(list.First().id == 1);
            Assert.IsTrue(list.First().Complete);

            IEnumerable<Todo> sortedList = core.fetchTasks(true);

            Assert.That(sortedList.Count, Is.EqualTo(1));
            Assert.IsTrue(sortedList.First().Complete);

            core.taskStatus(2);

            Assert.IsTrue(list.Last().Complete);

            sortedList = core.fetchTasks(true);
            Assert.That(sortedList.Count, Is.EqualTo(2));
            Assert.That(sortedList.First().id == 1);
            Assert.That(sortedList.Last().id == 2);
            Assert.IsTrue(sortedList.First().Complete);
            Assert.IsTrue(sortedList.Last().Complete);

            sortedList = core.fetchTasks(false);
            Assert.That(sortedList.Count, Is.EqualTo(0));

            core.taskStatus(1);
            core.taskStatus(2);

            sortedList = core.fetchTasks(false);
            Assert.That(sortedList.Count, Is.EqualTo(2));
            Assert.That(sortedList.First().id == 1);
            Assert.That(sortedList.Last().id == 2);
            Assert.IsFalse(sortedList.First().Complete);
            Assert.IsFalse(sortedList.Last().Complete);
        }

        [Test]
        public void SearchForTaskTest()
        {
            TodoList core = new TodoList();
            bool result = core.add("Walk the dog");
            List<Todo> list = core.listTasks();
            int listSize = core.listTasks().Count;

            Assert.IsTrue(result);
            Assert.That(listSize == 1); // check if list increased in size by 1
            Assert.That(list.First().id == 1);

            Todo todo1 = core.searchTask(1);

            Assert.That(todo1.id, Is.EqualTo(1));
            Assert.That(todo1.task, Is.EqualTo("Walk the dog"));
            Assert.That(todo1.Complete, Is.EqualTo(false));

            Todo todo2 = core.searchTask(2);

            Assert.Null(todo2);
        }

        [Test]
        public void RemoveTaskTest()
        {
            TodoList core = new TodoList();
            bool result1 = core.add("Walk the dog");
            bool result2 = core.add("Walk the cat?");
            bool result3 = core.add("Walk the tree!?");
            List<Todo> list = core.listTasks();
            int listSize = core.listTasks().Count;

            Assert.IsTrue(result1);
            Assert.IsTrue(result2);
            Assert.IsTrue(result3);
            Assert.That(listSize == 3); // check if list increased in size by 1
            Assert.That(list.First().id == 1);
            Assert.That(list.Last().id == 3);

            bool result4 = core.remove(1);
            listSize = core.listTasks().Count;

            Assert.IsTrue(result4);
            Assert.That(listSize == 2);
            Assert.That(list.First().id == 2);
            Assert.That(list.Last().id == 3);

            bool result5 = core.remove(1);
            listSize = core.listTasks().Count;

            Assert.IsTrue(result5);
            Assert.That(listSize == 2);
            Assert.That(list.First().id == 2);
            Assert.That(list.Last().id == 3);
        }

        [Test]
        public void SortListByDescending()
        {
            TodoList core = new TodoList();
            bool result1 = core.add("aaa");
            bool result2 = core.add("bbb");
            bool result3 = core.add("ccc");
            List<Todo> list = core.listTasks();
            int listSize = core.listTasks().Count;

            Assert.IsTrue(result1);
            Assert.IsTrue(result2);
            Assert.IsTrue(result3);
            Assert.That(listSize == 3); // check if list increased in size by 1
            Assert.That(list.First().id == 1);
            Assert.That(list.Last().id == 3);

            List<Todo> listOrdered = core.listTasksSort(true);

            list = core.listTasks();

            Assert.That(listOrdered[0].id, Is.EqualTo(3));
            Assert.That(listOrdered[1].id, Is.EqualTo(2));
            Assert.That(listOrdered[2].id, Is.EqualTo(1));

            listOrdered = core.listTasksSort(false);

            list = core.listTasks();

            Assert.That(listOrdered[0].id, Is.EqualTo(1));
            Assert.That(listOrdered[1].id, Is.EqualTo(2));
            Assert.That(listOrdered[2].id, Is.EqualTo(3));


        }

    }
}