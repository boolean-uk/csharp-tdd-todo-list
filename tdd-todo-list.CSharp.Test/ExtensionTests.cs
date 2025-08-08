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

        private void AddCourse()
        {
            string task1 = "Laundry";
            string task2 = "Dishwashing";
            string task3 = "Training";

            _extension.ToDoList.Add(task1);
            _extension.ToDoList.Add(task2);
            _extension.ToDoList.Add(task3);
        }

        [Test]
        public void GetTaskTest()
        {
            AddCourse();

            Task result = _extension.GetTask(2);

            Assert.That(result.Name, Is.EqualTo("Training"));
        }

        [Test]
        public void UpdateNameTest()
        {
            AddCourse();

            Task result = _extension.UpdateName(2, "Walk a dog");

            Assert.That(result.Name, Is.EqualTo("Walk a dog"));

        }
        [Test]
        public void ChangeStatusTest()
        {
            AddCourse();

            Task result = _extension.ChangeStatus(2);

            Assert.That(result.Status, Is.True);
        }
        //[Test]
        //public void CreatedTest()
        //{
        //    string task1 = "Laundry";
        //    string task2 = "Dishwashing";
        //    string task3 = "Training";

        //    _extension.ToDoList.Add(task1);
        //    _extension.ToDoList.Add(task2);
        //    _extension.ToDoList.Add(task3);


        //    //Assert.That(result.Status, Is.True);
        //}

        [Test]
        public void CategoriseTest()
        {
            AddCourse();

            _extension.Categorise(2, Category.Work);

            Assert.That(_extension.ToDoList.ToDoList[2].Category, Is.EqualTo(Category.Work));
        }
        [Test]
        public void ShowCategoriseTest()
        {
            AddCourse();

            _extension.Categorise(0, Category.Work);
            _extension.Categorise(1, Category.Admin);
            _extension.Categorise(2, Category.Study);

            List<Task> sorted = _extension.SeeTaskByCategory();

            TodoList expected = new TodoList();

            expected.Add("Dishwashing");
            expected.Add("Training");
            expected.Add("Laundry");

            for (int i = 0; i < sorted.Count; i++)
            {
                Assert.That(sorted[i].Name, Is.EqualTo(expected.ToDoList[i].Name));
            }

        }
    }
}
