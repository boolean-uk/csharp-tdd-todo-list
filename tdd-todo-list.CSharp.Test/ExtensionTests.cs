using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using System.Security.Cryptography.X509Certificates;

namespace tdd_todo_list.CSharp.Test
{
    public class ExtensionTests
    {            
        [Test]
        public void testGetTaskById()
        {
            var testname = "test";
            TodoListExtension todoListExtension = new TodoListExtension();
            todoListExtension.Add(testname);
            var todo = todoListExtension.getTaskById(1);
            var emptyTodo = todoListExtension.getTaskById(int.MaxValue);
            Assert.IsNotNull(todo);
            Assert.IsNull(emptyTodo);
            Assert.AreEqual(testname, todoListExtension.tasks[0].description);            
        }

        [Test]
        public void testUpdateName()
        {
            var testdesc = "test";
            var updatedDesc = "Updated description";
            TodoListExtension todoListExtension = new TodoListExtension();
            todoListExtension.Add(testdesc);
            Assert.AreEqual(todoListExtension.tasks[0].description, testdesc);
            todoListExtension.updateName(1, "Updated description");
            Assert.AreEqual(todoListExtension.tasks[0].description, updatedDesc);
        }

        [Test]
        public void testGetDateTime()
        {
            TodoListExtension todoListExtension = new TodoListExtension();
            List<string> dateTimes;
            // Test return 0 tasks
            dateTimes = todoListExtension.getDateTime();
            Assert.That(dateTimes.Count, Is.EqualTo(0));

            // Test return tasks and compare string
            todoListExtension.Add("Test");
            dateTimes = todoListExtension.getDateTime();
            var expectedTime = DateTime.Now.ToString();
            Assert.That(dateTimes[0], Is.EqualTo(expectedTime));
            
        }
    }
}
