using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tdd_todo_list.CSharp.Main;

namespace tdd_todo_list.CSharp.Test
{
    public class TodoListTests
    {

        [Test]
        public void AddOneTaskTest()
        {
            TodoList TestList = new TodoList();
            string Task = "test task";
            TestList.Add(Task);
            int expectedLength = 1;
            int length = TestList.Todo.Count;

            Assert.That(length == expectedLength);
        }
        [Test]
        public void AddTwoTaskTest()
        {
            TodoList TestList = new TodoList();
            string Task1 = "test task";
            TestList.Add(Task1);
            string Task2 = "test task2";
            TestList.Add(Task2);
            int expectedLength = 2;
            int length = TestList.Todo.Count;

            Assert.That(length == expectedLength);
        }
        [Test]
        public void GetAllObjectsTest()
        {
            TodoList TestList = new TodoList();
            TestList.Add("test1");
            TestList.Add("test2");
            List<TodoObject> allTasks =TestList.GetAllTasks();

            Assert.That(allTasks.Count == 2);
        }

        [Test]
        public void GetAllTaskStringsTest()
        {
            TodoList TestList = new TodoList();
            TestList.Add("test1");
            TestList.Add("test2");

            List<string> taskStrings = TestList.GetAllStringTasks();

            Assert.That(taskStrings.Contains("test1") && taskStrings.Contains("test2"));
        }
        [Test]
        public void GetAllCompleteTasksTest1()
        {
            TodoList TestList = new TodoList();
            TestList.Add("ferdig");
            TestList.Todo[0].Completed = true;
            
            List<TodoObject> completeList = TestList.GetAllCompleteTasks();
            Assert.That(completeList.All( t => t.Completed == true) && completeList.Count == 1);

        }
        [Test]
        public void GetAllCompleteTasksTest2()
        {
            TodoList TestList = new TodoList();
            TestList.Add("ferdig");
            TestList.Add("ikke ferdig");
            TestList.Add("ferdig");
            TestList.Add("ikke ferdig");
            TestList.Add("ferdig");
            TestList.Todo[0].Completed = true;
            TestList.Todo[2].Completed = true;
            TestList.Todo[4].Completed = true;

            List<TodoObject> completeList = TestList.GetAllCompleteTasks();
            Assert.That(completeList.All(t => t.Completed == true) && completeList.Count == 3);

        }
    }
}
