using tdd_todo_list.CSharp.Main;
using NUnit.Framework;
using System.Threading.Tasks;
using System.Text;

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

        [TestCase ("Laundry")]
        [TestCase ("Dishes")]
        
        
        public void AddTaskToTodo(string task)
        {
            //Arrange
            TodoList core = new TodoList();
            
            //Act 
            core.AddTask(task);

            //Assert
            Assert.IsTrue(core.Todos.Count == 1);   
        }

        [Test]
        public void ShowAllTasks()
        {
            //Arrange
            TodoList core = new TodoList();

            //Act 
            core.AddTask("Laundry");
            core.showTodoList();
            
            //Assert
            Assert.AreEqual(1, core.Todos.Count);
        }

        [Test]
        
        public void changeTaskStatus()
        {
            //Arrange
            TodoList core = new TodoList();
            string task = "laundry";

            //Act 

            core.AddTask (task);
            core.changeTaskStatus(task);

            //Assert
            Assert.IsTrue(core.Todos[task] == true);
        }

        [Test]

        public void showCompletedTasks()
        {
            //Arrange
            TodoList core = new TodoList();

            //Act 
            core.AddTask("Laundry");
            core.changeTaskStatus("Laundry");

            //Assert
            Assert.AreEqual(1, core.Todos.Count);
        }

        [Test]
        public void showIncompletedTasks()
        {
            //Arrange
            TodoList core = new TodoList();

            //Act 
            core.AddTask("Laundry");
            

            //Assert
            Assert.AreEqual(1, core.Todos.Count);
        }

        [TestCase("Dishes")] 

        public void NotFound(string task)
        {
            //Arrange
            TodoList core = new TodoList();
            
            string msg = "Task not in list";
            //Act
            core.AddTask(task);
            string searched = core.search(task);

            //Assert
            Assert.AreEqual(searched, msg);
        }

        [TestCase("Dishes")] 

        public void RemoveTask(string task)
        {
            //Arrange
            TodoList core = new TodoList(); 
            
            //Act
            core.AddTask("Dishes");
            core.RemoveTask(task);

            //Assert
            Assert.IsTrue(!core.Todos.ContainsKey(task));
        }

        [Test]

        public void SortAlphabeticalAsc()
        {
            //Arrange
            TodoList core = new TodoList();
            string ordered = "[dishes, False][wash car, False]";

            //Act
            core.AddTask("Wash car");
            core.AddTask("Dishes");
            string sorted = core.SortAlphaAsc();

            //Arrange
            Assert.AreEqual(sorted, ordered);
        }

        [Test]

        public void SortDescending()
        {
            //Arrange
            TodoList core = new TodoList();
            string ordered = "[wash car, False][dishes, False]";

            //Act
            core.AddTask("Dishes");
            core.AddTask("Wash car");
            string sorted = core.SortDecs();

            //Arrange
            Assert.AreEqual(sorted, ordered);
        }
    }
}