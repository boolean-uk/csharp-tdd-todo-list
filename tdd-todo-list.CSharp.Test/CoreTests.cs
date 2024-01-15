using tdd_todo_list.CSharp.Main;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class CoreTests
    {

        [Test]
        public void AddTask()
        {
            //Set Up
            TodoList list = new TodoList();

            //Execute
            list.add("Finish Boolean Exercise", true);
            list.add("Finish Boolean Exercise", false);

            //Verify
            Assert.IsTrue(list.toDoList.Count == 1);
            Assert.IsTrue(list.toDoList[0].Status == true);
        }

        [Test]
        public void ShowTasks()
        {
            //Set Up
            TodoList list = new TodoList();

            //Execute
            list.add("Finish Boolean Exercise", true);
            list.add("Finish Boolean Exercise", false);
            list.add("WAsH DisHeS", false);
            list.add("Vaccum House", true);
            list.show();

            //Verify
            Assert.IsTrue(list.toDoList.Count == 3);
            Assert.IsTrue(list.listString == "Your tasks:\nFinish Boolean Exercise: Completed\nWash Dishes: Incompleted\nVaccum House: Completed\n");
        }

        [Test]
        public void ChangeStatus()
        {
            //Set Up
            TodoList list = new TodoList();

            //Execute
            list.add("Finish Boolean Exercise", true);
            list.add("Finish Boolean Exercise", false);
            list.changeStatus("finish boolean exercise");

            //Verify
            Assert.IsTrue(list.toDoList.Count == 1);
            Assert.IsTrue(list.toDoList[0].Status == false);
        }

        [Test]
        public void ShowCompleteTasks()
        {
            //Set Up
            TodoList list = new TodoList();

            //Execute
            list.add("Finish Boolean Exercise", true);
            list.add("Finish Boolean Exercise", false);
            list.add("WAsH DisHeS", false);
            list.add("Vaccum House", true);
            list.show();
            list.showComplete();

            //Verify
            Assert.IsTrue(list.toDoList.Count == 3);
            Assert.IsTrue(list.listString == "Your tasks:\nFinish Boolean Exercise: Completed\nWash Dishes: Incompleted\nVaccum House: Completed\n");
            Assert.IsTrue(list.completeListString == "Your completed tasks:\nFinish Boolean Exercise\nVaccum House\n");
        }

        [Test]
        public void ShowIncompleteTasks()
        {
            //Set Up
            TodoList list = new TodoList();

            //Execute
            list.add("Finish Boolean Exercise", true);
            list.add("Finish Boolean Exercise", false);
            list.add("WAsH DisHeS", false);
            list.add("Vaccum House", true);
            list.show();
            list.showIncomplete();

            //Verify
            Assert.IsTrue(list.toDoList.Count == 3);
            Assert.IsTrue(list.listString == "Your tasks:\nFinish Boolean Exercise: Completed\nWash Dishes: Incompleted\nVaccum House: Completed\n");
            Assert.IsTrue(list.incompleteListString == "Your incompleted tasks:\nWash Dishes\n");
        }

        [Test]
        public void SearchTask()
        {
            //Set Up
            TodoList list = new TodoList();

            //Execute
            list.add("Finish Boolean Exercise", true);
            list.add("Finish Boolean Exercise", false);
            list.add("WAsH DisHeS", false);
            list.add("Vaccum House", true);
            list.show();
            list.showIncomplete();

            //Verify
            Assert.IsTrue(list.search("Finish Boolean Exercise"));
            Assert.IsFalse(list.search("Finish Exercise"));
        }

        [Test]
        public void RemoveTask()
        {
            //Set Up
            TodoList list = new TodoList();

            //Execute
            list.add("Finish Boolean Exercise", true);
            list.add("Finish Boolean Exercise", false);
            list.add("WAsH DisHeS", false);
            list.add("Vaccum House", true);
            list.remove("finish boolean exercise");

            //Verify
            Assert.IsFalse(list.toDoList[0].Task == "Finish Boolean Exercise");
        }

        [Test]
        public void ShowAscending()
        {
            //Set Up
            TodoList list = new TodoList();

            //Execute
            list.add("Finish Boolean Exercise", true);
            list.add("Finish Boolean Exercise", false);
            list.add("WAsH DisHeS", false);
            list.add("Vaccum House", true);
            list.showAscending();

            //Verify
            Assert.IsTrue(list.ascendingListString == "Your tasks in ascending order:\nFinish Boolean Exercise: Completed\nVaccum House: Completed\nWash Dishes: Incompleted\n");
        }

        [Test]
        public void ShowDescending()
        {
            //Set Up
            TodoList list = new TodoList();

            //Execute
            list.add("Finish Boolean Exercise", true);
            list.add("Finish Boolean Exercise", false);
            list.add("WAsH DisHeS", false);
            list.add("Vaccum House", true);
            list.showDescending();

            //Verify
            Assert.IsTrue(list.descendingListString == "Your tasks in descending order:\nWash Dishes: Incompleted\nVaccum House: Completed\nFinish Boolean Exercise: Completed\n");
        }
    }
}