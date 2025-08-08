using NUnit.Framework;
using System.Threading.Tasks;
using tdd_todo_list.CSharp.Main;
using Task = tdd_todo_list.CSharp.Main.Task;

namespace tdd_todo_list.CSharp.Test
{
    public class ExtensionTests
    {
        private TodoListExtension _extension;
        public ExtensionTests()
        {
            _extension = new TodoListExtension();
        }

        [Test]
        public void GetTaskTest()
        {
            string task1 = "Laundry";
            string task2 = "Dishwashing";
            string task3 = "Training";

            _extension.ToDoList.Add(task1);
            _extension.ToDoList.Add(task2);
            _extension.ToDoList.Add(task3);

            Task result = _extension.GetTask(2);

            Assert.That(result.Name, Is.EqualTo("Training"));
        }

        [Test]
        public void UpdateNameTest()
        {
            string task1 = "Laundry";
            string task2 = "Dishwashing";
            string task3 = "Training";

            _extension.ToDoList.Add(task1);
            _extension.ToDoList.Add(task2);
            _extension.ToDoList.Add(task3);

            Task result = _extension.UpdateName(2, "Walk a dog");

            Assert.That(result.Name, Is.EqualTo("Walk a dog"));

        }
        [Test]
        public void ChangeStatusTest()
        {
            string task1 = "Laundry";
            string task2 = "Dishwashing";
            string task3 = "Training";

            _extension.ToDoList.Add(task1);
            _extension.ToDoList.Add(task2);
            _extension.ToDoList.Add(task3);

            Task result = _extension.ChangeStatus(2);

            Assert.That(result.Status, Is.True);
        }
        [Test]
        public void CreatedTest()
        {
            string task1 = "Laundry";
            string task2 = "Dishwashing";
            string task3 = "Training";

            _extension.ToDoList.Add(task1);
            _extension.ToDoList.Add(task2);
            _extension.ToDoList.Add(task3);

            
            //Assert.That(result.Status, Is.True);
        }
    }
}
