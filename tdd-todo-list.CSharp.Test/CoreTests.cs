using NUnit.Framework;
using System;
using tdd_todo_list.CSharp.Main;
using Task = tdd_todo_list.CSharp.Main.Task;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void AddingTask()
        {
            TodoList list = new TodoList();
            string name = "Do your homework";
            bool result = false;
            result = list.Add(name);

            Assert.That(result, Is.True);
            Assert.That(list.ToDoList[0].Name, Is.EqualTo(name));
            Assert.That(list.ToDoList[0].Id, Is.EqualTo(1));
        }

        [Test]
        public void SeeAllTasks()
        {
            TodoList list = new TodoList();
            string task1 = "Laundry";
            string task2 = "Dishwashing";
            string task3 = "Training";

            list.Add(task1);
            list.Add(task2);
            list.Add(task3);

            Assert.That(list.Amout_tasks, Is.EqualTo(3));
        }


        [Test]
        public void ChangeStatus()
        {
            TodoList list = new TodoList();
            string task1 = "Laundry";
            string task2 = "Dishwashing";

            list.Add(task1);
            list.Add(task2);

            list.ChangeStatus(task1);
            list.ChangeStatus(task2);
            list.ChangeStatus(task2);

            Assert.That(list.ToDoList[0].Status, Is.True);
            Assert.That(list.ToDoList[1].Status, Is.False);
        }
        [Test]
        public void CompleteTasks()
        {
            TodoList list = new TodoList();
            string task1 = "Laundry";
            string task2 = "Dishwashing";
            string task3 = "Training";

            list.Add(task1);
            list.Add(task2);
            list.Add(task3);

            list.ChangeStatus(task1);
            list.ChangeStatus(task2);

            TodoList complete_list = list.CompleteTasks();


            for (int i = 0; i < complete_list.Amout_tasks; i++)
            {
                Assert.That(list.ToDoList[i].Status, Is.True);
            }
                Assert.That(complete_list.Amout_tasks, Is.EqualTo(2));
        }

        [Test]
        public void IncompleteAllTasks()
        {
            TodoList list = new TodoList();
            string task1 = "Laundry";
            string task2 = "Dishwashing";
            string task3 = "Training";
            string task4 = "Walk with dog";

            list.Add(task1);
            list.Add(task2);
            list.Add(task3);
            list.Add(task4);

            list.ChangeStatus(task1);
            list.ChangeStatus(task2);

            TodoList incomplete_list = list.IncompleteTasks();

            for (int i = 0; i < incomplete_list.Amout_tasks; i++)
            {
                Assert.That(incomplete_list.ToDoList[i].Status, Is.False);
            }
            Assert.That(incomplete_list.Amout_tasks, Is.EqualTo(2));
        }
        [Test]
        public void Search()
        {
            TodoList list = new TodoList();
            string task1 = "Laundry";
            string task2 = "Dishwashing";

            list.Add(task1);
            list.Add(task2);

            bool result = list.Search("Laundry");
            bool result2 = list.Search("Play games");
            Assert.That(result, Is.True);
            Assert.That(result2, Is.False);
        }
        [Test]
        public void Remove()
        {
            TodoList list = new TodoList();
            string task1 = "Laundry";
            string task2 = "Dishwashing";

            list.Add(task1);
            list.Add(task2);

            bool result = list.Remove("Laundry");
            bool result2 = list.Remove("Play games");
            Assert.That(result, Is.True);
            Assert.That(result2, Is.False);
            Assert.That(list.Amout_tasks, Is.EqualTo(1));
        }

        [Test]
        public void OrderAlhabetA()
        {
            TodoList list = new TodoList();
            string task1 = "Laundry";
            string task2 = "Dishwashing";
            string task3 = "Training";
            string task4 = "Walk with dog";

            list.Add(task1);
            list.Add(task2);
            list.Add(task3);
            list.Add(task4);

            TodoList alphabet = list.AlphabetA();

            TodoList expected = new TodoList();

            expected.Add("Dishwashing");
            expected.Add("Laundry");
            expected.Add("Training");
            expected.Add("Walk with dog");


            for (int i = 0; i < alphabet.Amout_tasks; i++)
            {
                Assert.That(alphabet.ToDoList[i].Name, Is.EqualTo(expected.ToDoList[i].Name));
            }
        }

        [Test]
        public void OrderAlphabetD()
        {
            TodoList list = new TodoList();
            string task1 = "Laundry";
            string task2 = "Dishwashing";
            string task3 = "Training";
            string task4 = "Walk with dog";

            list.Add(task1);
            list.Add(task2);
            list.Add(task3);
            list.Add(task4);

            TodoList alphabet = list.AlphabetD();

            TodoList expected = new TodoList();

            expected.Add("Walk with dog");
            expected.Add("Training");
            expected.Add("Laundry");
            expected.Add("Dishwashing");

            for (int i = 0; i < alphabet.Amout_tasks; i++)
            {
                Assert.That(alphabet.ToDoList[i].Name, Is.EqualTo(expected.ToDoList[i].Name));
            }
        }

        [Test]
        public void PrioritiseTest()
        {
            TodoList list = new TodoList();
            string task1 = "Laundry";
            string task2 = "Dishwashing";
            string task3 = "Training";
            string task4 = "Walk with dog";

            list.Add(task1);
            list.Add(task2);
            list.Add(task3);
            list.Add(task4);

            list.Prioritise("Laundry", Priority.medium);

            Priority excepted = Priority.medium;

            Console.WriteLine("1. Sjekker prioritet for Laundry " + list.ToDoList[0].Priority);
            Assert.That(list.ToDoList[0].Priority, Is.EqualTo(excepted));
            Assert.That(list.ToDoList[1].Priority, Is.EqualTo(Priority.low));
        }
        [Test]
        public void SeePriority()
        {
            TodoList list = new TodoList();
            string task1 = "Laundry";
            string task2 = "Dishwashing";
            string task3 = "Training";
            string task4 = "Walk with dog";
            string task5 = "Doing homework";
            string task6 = "Give food to your dog";

            list.Add(task1);
            list.Add(task2);
            list.Add(task3);
            list.Add(task4);
            list.Add(task5);
            list.Add(task6);

            list.Prioritise("Dishwashing", Priority.medium);
            list.Prioritise("Training", Priority.medium);
            list.Prioritise("Give food to your dog", Priority.high);


            List<Task> sorted = list.SeeTaskByPriority();

            TodoList expected = new TodoList();

            expected.Add("Laundry");
            expected.Add("Walk with dog");
            expected.Add("Doing homework");
            expected.Add("Dishwashing");
            expected.Add("Training");
            expected.Add("Give food to your dog");

            for (int i = 0; i < sorted.Count; i++)
            {
                Assert.That(sorted[i].Name, Is.EqualTo(expected.ToDoList[i].Name));
            }

        }
    }
}