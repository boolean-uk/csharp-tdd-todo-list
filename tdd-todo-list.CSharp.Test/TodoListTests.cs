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
        [Test]
        public void GetAllCompleteTasksTest3()
        {
            TodoList TestList = new TodoList();
            List<TodoObject> completeList = TestList.GetAllCompleteTasks();
            Assert.That(completeList.Count == 0);

        }
        [Test]
        public void GetAlIncompleteTasksTest1()
        {
            TodoList TestList = new TodoList();
            TestList.Add("ferdig");
            TestList.Todo[0].Completed = true;

            List<TodoObject> incompleteList = TestList.GetAllIncompleteTasks();
            Assert.That(incompleteList.All(t => t.Completed == false) && incompleteList.Count == 0);

        }
        [Test]
        public void GetAllIncompleteTasksTest2()
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

            List<TodoObject> incompleteList = TestList.GetAllIncompleteTasks();
            Assert.That(incompleteList.All(t => t.Completed == true) && incompleteList.Count == 2);

        }
        [Test]
        public void GetAllIncompleteTasksTest3()
        {
            TodoList TestList = new TodoList();
            List<TodoObject> incompleteList = TestList.GetAllIncompleteTasks();
            Assert.That(incompleteList.Count == 0);

        }
        [Test]
        public void SearchForTaskTest()
        {
            TodoList TestList = new TodoList();
            TestList.Add("ferdig");
            TestList.Add("ikke ferdig");
            bool testObj = TestList.SearchFor("ferdig");
            bool expectedObj = true;

            Assert.That(testObj == expectedObj);
        }
        [Test]
        public void SearchForNonexistantTaskTest()
        {
            TodoList TestList = new TodoList();
            TestList.Add("ferdig");
            TestList.Add("ikke ferdig");
            bool testObj = TestList.SearchFor("nonexistant");
            bool expectedObj = false;
            Assert.That(testObj == expectedObj);
        }
        [Test]
        public void RemoveTest()
        {
            TodoList TestList = new TodoList();
            TestList.Add("ferdig");
            TestList.Add("ikke ferdig");
            TestList.Remove(0);


            Assert.That(TestList.Todo.Count == 1 && !TestList.Todo.ContainsKey(0) && TestList.Todo[1].TaskStr == "ikke ferdig");
        }
        [Test]
        public void OrderAscendingTest()
        {
            TodoList TestList = new TodoList();
            TestList.Add("abbasad");
            TestList.Add("caabssdsa");
            TestList.Add("baabvb");
            List<TodoObject> sortedList = TestList.OrderList();
        }
        [Test]
        public void OrderDescendingTest()
        {
            TodoList TestList = new TodoList();
            TestList.Add("abbasad");
            TestList.Add("caabssdsa");
            TestList.Add("baabvb");
            List<TodoObject> sortedList = TestList.OrderList(false);
        }

        [Test]
        public void PriorityTest() 
        {
            TodoList TestList = new TodoList();
            TestList.Add("abbasad");
            TestList.Add("caabssdsa");
            TestList.Add("baabvb");
            TestList.Add("Viktig");
            TestList.Add("uviktig");
            TestList.Add("passe");
            TestList.PrioritiseTask(0, "LOW");
            TestList.PrioritiseTask(1, "MEDIUM");
            TestList.PrioritiseTask(2, "HIGH");
            TestList.PrioritiseTask(3, "HIGH");
            TestList.PrioritiseTask(4, "LOW");
            TestList.PrioritiseTask(5, "MEDIUM");
            Assert.That(
                TestList.Todo[0].Priority == "LOW" && 
                TestList.Todo[1].Priority == "MEDIUM" &&
                TestList.Todo[2].Priority == "HIGH" &&
                TestList.Todo[3].Priority == "HIGH" &&
                TestList.Todo[4].Priority == "LOW" &&
                TestList.Todo[5].Priority == "MEDIUM");
        }
        [Test]
        public void GetPriorityTest()
        {
            TodoList TestList = new TodoList();
            TestList.Add("abbasad");
            TestList.Add("caabssdsa");
            TestList.Add("baabvb");
            TestList.Add("Viktig");
            TestList.Add("uviktig");
            TestList.Add("passe");
            TestList.PrioritiseTask(0, "LOW");
            TestList.PrioritiseTask(1, "MEDIUM");
            TestList.PrioritiseTask(2, "HIGH");
            TestList.PrioritiseTask(3, "HIGH");
            TestList.PrioritiseTask(4, "LOW");
            TestList.PrioritiseTask(5, "MEDIUM");
            List<TodoObject> lowPriority = TestList.GetPriority("LOW");
            List<TodoObject> medPriority = TestList.GetPriority("MEDIUM");
            List<TodoObject> highPriority = TestList.GetPriority("HIGH");

            Assert.That(
                lowPriority.All(t => t.Priority == "LOW") &&
                medPriority.All(t => t.Priority == "MEDIUM") &&
                highPriority.All(t => t.Priority == "HIGH"));
        }
    }
}
