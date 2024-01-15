using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [TestCase("Clean kitchen")]
        public void AddTodoTest(string description)
        {
            //arrange
            TodoList todolist = new TodoList();

            //act
            todolist.AddTodo(description);

            //assert
            Assert.IsTrue(todolist.Todos.Count > 0);

        }

        [Test]
        public void ShowAllTodosTest()
        {
            using (StringWriter sw = new StringWriter())
            {

                //arrange
                Console.SetOut(sw);

                TodoList todolist = new TodoList();
                todolist.AddTodo("Clean kitchen");
                todolist.AddTodo("Work out");

                string expected = "Description: Clean kitchen, Status: Incomplete\r\n" +
                    "Description: Work out, Status: Incomplete\r\n";
                //act
                todolist.ShowAllTodos();

                //assert
                Assert.AreEqual(expected, sw.ToString());

            }

        }

        [TestCase ("Clean kitchen", "Complete")]
        public void ChangeTodoStatusTest(string description, string status)
        {
            //arrange
            TodoList todolist = new TodoList();
            todolist.AddTodo(description);

            //act
            todolist.ChangeTodoStatus(description, status);


            //assert
            Assert.IsTrue(todolist.Todos.First().Value == status);
        }

        [Test]
        public void ShowCompletedTasksTest()
        {        
            using (StringWriter sw = new StringWriter()){

                //arrange
                Console.SetOut(sw);

                TodoList todolist = new TodoList();
                todolist.AddTodo("Clean kitchen");
                todolist.AddTodo("Clean bedroom");
                todolist.AddTodo("Work out");
                todolist.ChangeTodoStatus("Clean bedroom", "Complete");
                todolist.ChangeTodoStatus("Work out", "Complete");

                string expected = "Description: Clean bedroom, Status: Complete\r\n" +
                    "Description: Work out, Status: Complete\r\n";
                //act
                todolist.ShowCompletedTasks();

                //assert
                Assert.AreEqual(expected, sw.ToString());

            }
            
        }

        [Test]
        public void ShowIncompleteTasksTest()
        {
            
            using (StringWriter sw = new StringWriter())
            {

                //arrange
                Console.SetOut(sw);

                TodoList todolist = new TodoList();
                todolist.AddTodo("Clean kitchen");
                todolist.AddTodo("Clean bedroom");
                todolist.AddTodo("Work out");
                todolist.ChangeTodoStatus("Clean kitchen", "Complete");

                string expected = "Description: Clean bedroom, Status: Incomplete\r\n" +
                    "Description: Work out, Status: Incomplete\r\n";
                //act
                todolist.ShowIncompleteTasks();

                //assert
                Assert.AreEqual(expected, sw.ToString());

            }


        }

        [TestCase("Clean kitchen")]
        public void SearchForTaskTest(string description)
        {
            //arrange
            TodoList todolist = new TodoList();
            todolist.AddTodo("Clean kitchen");
            todolist.AddTodo("Clean bedroom");

            //act
            bool result = todolist.SearchForTask(description);

            //assert
            Assert.IsTrue(result = true);
        }

        [TestCase("Clean kitchen")]
        public void RemoveTodoTest(string description)
        {
            //arrange
            TodoList todolist = new TodoList();
            todolist.AddTodo(description);

            //act
            todolist.RemoveTodo(description);

            //assert
            Assert.IsTrue(todolist.Todos.Count == 0);
        }

        [Test]
        public void ShowTodosAlphabeticallyAscendingTest()
        {

            using (StringWriter sw = new StringWriter())
            {

                //arrange
                Console.SetOut(sw);

                TodoList todolist = new TodoList();
                todolist.AddTodo("Work out");
                todolist.AddTodo("Clean kitchen");
                todolist.AddTodo("Learn C#");


                //act
                todolist.ShowTodosAlphabeticallyAscending();
                string expected = "Description: Clean kitchen, Status: Incomplete\r\n" +
                    "Description: Learn C#, Status: Incomplete\r\n" + 
                    "Description: Work out, Status: Incomplete\r\n";

                //assert
                Assert.AreEqual(expected, sw.ToString());

            }
        }

        [Test]
        public void ShowTodosAlphabeticallyDescending()
        {
            using (StringWriter sw = new StringWriter())
            {

                //arrange
                Console.SetOut(sw);

                TodoList todolist = new TodoList();
                todolist.AddTodo("Work out");
                todolist.AddTodo("Clean kitchen");
                todolist.AddTodo("Learn C#");


                //act
                todolist.ShowTodosAlphabeticallyDescending();
                string expected = "Description: Work out, Status: Incomplete\r\n" +
                    "Description: Learn C#, Status: Incomplete\r\n" +
                    "Description: Clean kitchen, Status: Incomplete\r\n";

                //assert
                Assert.AreEqual(expected, sw.ToString());

            }
        }
    }
}