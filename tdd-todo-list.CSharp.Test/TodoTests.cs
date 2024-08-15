using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using static tdd_todo_list.CSharp.Main.TodoList;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.ObjectModel;
using System.Xml.Linq;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class TodoTests
    {
         

        [TestCase("Write some code")]
        [TestCase("Write some more code")]
        [TestCase("Shop for groceries")]
        public void TestAddTask(string name)
        {
            //arrange
            TodoList todo = new TodoList();
            string expected = name;

            todo.AddTask(name, false);

            Assert.That(todo.SeeIfTaskExists(expected));            
        }

        [TestCase("Write some code", false)]
        [TestCase("Write some more code", true)]
        [TestCase("Shop for groceries", false)]
        public void TestToogleTask(string name, bool startingStatus)
        {
            //arrange
            TodoList todo = new TodoList();
            todo.AddTask(name, startingStatus); 
            bool expected = !startingStatus;

            bool result = todo.ToogleTaskStatus(name);

            Assert.That(result == expected);
        }


        [TestCase(TodoTaskStatus.Complete)]
        [TestCase(TodoTaskStatus.InComplete)]
        [TestCase(TodoTaskStatus.All)]
        public void TestPrintingTasks(TodoTaskStatus status)
        {
            //arrange
            TodoList todo = new TodoList();
            string expected = string.Empty;
            string taskName = "Watch Netflix episode ";
            for(int i = 1; i < 11; i++)
            {
                bool stat = false;
                if(i % 3 == 0)
                {
                    stat = true;
                }
                todo.AddTask(taskName + i.ToString(), stat);

                if (status == TodoTaskStatus.InComplete && stat == false)
                {
                    expected += taskName + i.ToString() + "\n";
                }
                else if( status == TodoTaskStatus.Complete && stat == true)
                {
                    expected += taskName + i.ToString() + "\n";
                }
                else // all
                {
                    expected += taskName + i.ToString() + "\n";
                }
            }



            string result = todo.PrintTasks(status, Order.AnyOrder);

            Assert.That(result == expected);
        }


        [TestCase("Write some code")]
        [TestCase("Write some more code")]
        [TestCase("Shop for groceries")]
        [TestCase("Write a story about purchasing a debug rubber ducky")]
        [TestCase("Code a new project")]
        [TestCase("Get bored of new project")]
        [TestCase("Code another new project")]
        public void TestSearchTask(string name)
        {
            //arrange
            TodoList todo = new TodoList();
            todo.AddTask("Write some code", false);
            todo.AddTask("Write some more code", false);
            todo.AddTask("Write a story about purchasing a debug rubber ducky", false);
            string expected = "Task was not found!";
            if (name[0] == 'W')
            {
                expected = "Task " + name + " exists!";
            }


            string result = todo.Search(name);
            Assert.That(result == expected);
        }



        [TestCase("Write some code")]
        [TestCase("Write some more code")]
        [TestCase("Shop for groceries")]
        [TestCase("Write a story about purchasing a debug rubber ducky")]
        [TestCase("Code a new project")]
        [TestCase("Get bored of new project")]
        [TestCase("Code another new project")]
        public void TestRemoveTask(string name)
        {
            //arrange
            TodoList todo = new TodoList();
            todo.AddTask("Write some code", false);
            todo.AddTask("Write some more code", false);
            todo.AddTask("Write a story about purchasing a debug rubber ducky", false);
            bool expected = false;
            if (name[0] == 'W')
            {
                expected = true;
            }


            bool result = todo.RemoveTask(name);
            Assert.That(result == expected);
        }




        [TestCase(Order.Descending, TodoTaskStatus.Complete)]
        [TestCase(Order.Descending, TodoTaskStatus.InComplete)]
        [TestCase(Order.Descending, TodoTaskStatus.All)]
        [TestCase(Order.Ascending, TodoTaskStatus.Complete)]
        [TestCase(Order.Ascending, TodoTaskStatus.InComplete)]
        [TestCase(Order.Ascending, TodoTaskStatus.All)]
        public void TestOrderBy(Order order, TodoTaskStatus status)
        {
            //assert 
            TodoList todo = new TodoList();
            todo.AddTask("Write some code", false);
            todo.AddTask("Write some more code", true);
            todo.AddTask("Write a story about purchasing a debug rubber ducky", false);
            todo.AddTask("Film a youtube intro", true);
            todo.AddTask("Build a website", false);
            todo.AddTask("Take a nap", false);
            todo.AddTask("Study for exam", true);
            todo.AddTask("Finish painting the fence", false);
            todo.AddTask("Go Shopping", false);

            string expected = string.Empty;
            if(Order.Descending == order && status == TodoTaskStatus.All)
            {
                expected = "Write some more code\nWrite some code\nWrite a story about purchasing a debug rubber ducky\nTake a nap\nStudy for exam\nGo Shopping\nFilm a youtube intro\nFinish painting the fence\nBuild a website\n";
            }
            else if (Order.Descending == order && status == TodoTaskStatus.Complete)
            {
                expected = "Study for exam\nWrite some more code\nFilm a youtube intro\n";
            }
            else if (Order.Descending == order && status == TodoTaskStatus.InComplete)
            {
                expected = "Write some code\nWrite a story about purchasing a debug rubber ducky\nTake a nap\nGo Shopping\nFinish painting the fence\nBuild a website\n;";
            }
            else if (Order.Ascending == order && status == TodoTaskStatus.All)
            {
                expected = "Build a website\nFinish painting the fence\nFilm a youtube intro\nGo Shopping\nStudy for exam\nTake a nap\nWrite a story about purchasing a debug rubber ducky\nWrite some code\nWrite some more code\n";
            }
            else if (Order.Ascending == order && status == TodoTaskStatus.Complete)
            {
                expected = "Film a youtube intro\nStudy for exam\nWrite some more code\n";
            }
            else if (Order.Ascending == order && status == TodoTaskStatus.InComplete)
            {
                expected = "Build a website\nFinish painting the fence\nGo Shopping\nTake a nap\nWrite a story about purchasing a debug rubber ducky\nWrite some code\n";
            }



            string result = todo.PrintTasks(status, order);

            Assert.That(expected == result);
        }

    }

    
}