using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        
        TodoList todo;

        [SetUp]
        public void SetUp()
        {
            todo = new TodoList();

        }

        [Test]
        public void FirstTest()
        {
            // task 1
            todo.AddTaskToList(new TodoList.Task("Call mother", false), 1);

            Assert.That(todo.todoList.Count, Is.EqualTo(1));
        }

        [Test]
        public void SecondTest()
        {
            // task 1
            todo.AddTaskToList(new TodoList.Task("Call mother", false), 1);
            todo.AddTaskToList(new TodoList.Task("By food", false), 2);
            todo.AddTaskToList(new TodoList.Task("Clean house", false), 3);

            Assert.That(todo.todoList.Count, Is.EqualTo(3));
        }

        [Test]
        public void ThirdTest()
        {

            // task 2
            todo.AddTaskToList(new TodoList.Task("Call mother", false),1);
            todo.AddTaskToList(new TodoList.Task("By food", false), 2);
            todo.AddTaskToList(new TodoList.Task("Clean house", false), 3);

            List<string> list = new List<string>();

            list = todo.ShowList();

            Assert.That(list, Is.EqualTo(new List<string> { "Call mother", "By food", "Clean house" }));
        }

        [Test]
        public void FourthTest()
        {
            // task 3
            TodoList.Task task = new TodoList.Task("Call mother", false);
            todo.AddTaskToList(task, 1);
            bool isInThere = todo.ChangeStatus(1);

            Assert.That(isInThere, Is.EqualTo(true));
            Assert.That(todo.todoList[1].complete, Is.EqualTo(true));
        }

        [Test]
        public void FifthTest()
        {

            // task 3
            TodoList.Task task = new TodoList.Task("Call mother", false);

            todo.AddTaskToList(new TodoList.Task("By food", false), 1);
            todo.AddTaskToList(new TodoList.Task("Clean house", false), 2);
            bool isInThere = todo.ChangeStatus(3);

            Assert.That(isInThere, Is.EqualTo(false));
        }

        [Test]
        public void SixthTest()
        {
            // task 4

            todo.AddTaskToList(new TodoList.Task("By food", false), 1);
            todo.AddTaskToList(new TodoList.Task("Clean house", true), 2);
            todo.AddTaskToList(new TodoList.Task("Call mother", false), 3);
            todo.AddTaskToList(new TodoList.Task("Clean car", true), 4);

            List<string> list = todo.GetCompleatedTasks();

            Assert.That(list, Is.EqualTo(new List<string> { "Clean house", "Clean car" }));



        }

        [Test]
        public void SeventhTest()
        {
            // task 5


            todo.AddTaskToList(new TodoList.Task("By food", false), 1);
            todo.AddTaskToList(new TodoList.Task("Clean house", true), 2);
            todo.AddTaskToList(new TodoList.Task("Call mother", false), 3);
            todo.AddTaskToList(new TodoList.Task("Clean car", true), 4);

            List<string> list = todo.GetIncompleatedTasks();

            Assert.That(list, Is.EqualTo(new List<string> { "By food", "Call mother" }));



        }


        [Test]
        public void EighthTest()
        {
            // task 6

            todo.AddTaskToList(new TodoList.Task("By food", false), 1);
            todo.AddTaskToList(new TodoList.Task("Clean house", false), 2);
            todo.AddTaskToList(new TodoList.Task("Call mother", false), 3);
            todo.AddTaskToList(new TodoList.Task("Clean car", false), 4);

            string task = todo.SearchForTask(2);

            Assert.That(task, Is.EqualTo(new string("Task: Clean house, Status: incomplete")));



        }

        [Test]
        public void NinthTest()
        {
            // task 6

            todo.AddTaskToList(new TodoList.Task("By food", false), 1);
            todo.AddTaskToList(new TodoList.Task("Clean house", false), 2);
            todo.AddTaskToList(new TodoList.Task("Call mother", false), 3);
            todo.AddTaskToList(new TodoList.Task("Clean car", false), 4);

            string task = todo.SearchForTask(5);

            Assert.That(task, Is.EqualTo(new string("TaskID not in todolist")));



        }


        [Test]
        public void TenthTest()
        {
            // task 6

            todo.AddTaskToList(new TodoList.Task("By food", false), 1);
            todo.AddTaskToList(new TodoList.Task("Clean house", true), 2);
            todo.AddTaskToList(new TodoList.Task("Call mother", false), 3);
            todo.AddTaskToList(new TodoList.Task("Clean car", false), 4);

            string task = todo.SearchForTask(2);

            Assert.That(task, Is.EqualTo(new string("Task: Clean house, Status: complete")));



        }

        [Test]
        public void EleventhTest()
        {
            // task 7

            todo.AddTaskToList(new TodoList.Task("Do things", false), 1);
            todo.AddTaskToList(new TodoList.Task("Clean house", false), 2);
            todo.AddTaskToList(new TodoList.Task("By food", false), 3);
            todo.AddTaskToList(new TodoList.Task("Clean car", false), 4);



            string task = todo.RemoveTask(2);

            Assert.That(task, Is.EqualTo(new string("Task: Clean house, was removed from todolist")));
            Assert.That(todo.todoList.Count, Is.EqualTo(3));



        }

        [Test]  
        public void TwelfthTest()
        {
            // task 7

            todo.AddTaskToList(new TodoList.Task("Do things", false), 1);
            todo.AddTaskToList(new TodoList.Task("Clean house", false), 2);
            todo.AddTaskToList(new TodoList.Task("By food", false), 3);
            todo.AddTaskToList(new TodoList.Task("Clean car", false), 4);



            string task = todo.RemoveTask(5);

            Assert.That(task, Is.EqualTo(new string("TaskID not in todolist")));



        }

        [Test]
        public void ThirteenthTest()
        {
            // task 8

            todo.AddTaskToList(new TodoList.Task("Do things", false), 1);
            todo.AddTaskToList(new TodoList.Task("Clean house", false), 2);
            todo.AddTaskToList(new TodoList.Task("By food", false), 3);
            



            List<string> tasks = todo.SortAlphabeticallyAssending();

            Assert.That(tasks, Is.EqualTo(new List<string> { "By food", "Clean house", "Do things" }));



        }

        [Test]
        public void FourteenthTest()
        {
            // task 9

            todo.AddTaskToList(new TodoList.Task("Do things", false), 1);
            todo.AddTaskToList(new TodoList.Task("Clean house", false), 2);
            todo.AddTaskToList(new TodoList.Task("By food", false), 3);




            List<string> tasks = todo.SortAlphabeticallyDescening();    

            Assert.That(tasks, Is.EqualTo(new List<string> { "Do things", "Clean house", "By food" }));



        }




    }
}