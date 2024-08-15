using tdd_todo_list.CSharp.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Interfaces;


// THIS IS EXTENSION
namespace tdd_todo_list.CSharp.Test
{
    public class IdManagerTests
    {
       

        private IdManager idManager;


        [TestCase(0)]
        [TestCase(1)]
        [TestCase(-1)]
        [TestCase(-4)]
        [TestCase(3)]
        [TestCase(5)]
        public void TestFindingById(int id)
        {
            idManager = new IdManager();
            idManager.AddTask("task0", false, "01-06-2024 16:45");
            idManager.AddTask("task1", true, "08-04-2024 12:45");
            idManager.AddTask("task2", false, "02-06-2021 13:32");
            idManager.AddTask("task3", false, "22-06-2023 11:21");

            string expected = "404 task not found!";
            if (id == 0)
            {
                expected = "task" + id.ToString() + ", task incomplete, task created 01-06-2024 16:45";
            }
            else if (id == 1)
            {
                expected = "task" + id.ToString() + ", task complete, task created 08-04-2024 12:45";
            }
            else if (id == 2)
            {
                expected = "task" + id.ToString() + ", task incomplete, task created 02-06-2021 13:32";
            }
            else if (id == 3)
            {
                expected = "task" + id.ToString() + ", task incomplete, task created 22-06-2023 11:21";
            }

            string result = idManager.FindTaskByID(id);

            Assert.That(result == expected);
        }


        [TestCase(0, "NewName")]
        [TestCase(0, "SameName")]
        [TestCase(44, "ThisFileDoesNotExist")]
        public void TestUpdatingName(int id, string name)
        {
            idManager = new IdManager();
            idManager.AddTask("ThisIsAName", false, "22-06-2023 11:21");
            idManager.AddTask("SameName", false, "22-06-2013 11:21");
            string expectedName = name;

            bool result = idManager.UpdateTaskName(id, name);

            if(result)
            {
                Assert.That(idManager.FindTaskByID(id).Substring(0, name.Length) == expectedName);
            }
            else
            {
                Assert.That(idManager.FindTaskByID(id) == "404 task not found!");
            }

        }


        [TestCase(0)]
        [TestCase(1)]
        [TestCase(4)]
        public void TestToggleStatus(int id)
        {
            idManager = new IdManager();
            idManager.AddTask("ThisIsAName", false, "22-06-2023 11:21");
            idManager.AddTask("AnotherName", true, "22-06-2013 11:21");
            idManager.AddTask("Go shopping", true, "22-06-2013 11:21");

            string file = idManager.FindTaskByID(id);
            bool expected = !idManager.CheckStatus(id); //expected is opposite of current

            bool success = idManager.ToggleStatus(id);

            if (success)
            {
                Assert.That(idManager.GetStatus(id) == expected);
            }
            else
            {
                Assert.That(file == "404 task not found!");
            }
        }


        [TestCase("Paint the fence", false, "01-06-2024 16:45")]
        [TestCase("Walk the dog", true, "08-04-2024 12:45")]
        [TestCase("Play baseball", false, "02-06-2021 13:32")]
        public void TestViewHistory(string name, bool status, string timeStamp)

        {
            idManager = new IdManager();

            idManager.AddTask("Go shopping", true, "22-06-2013 11:21");
            idManager.AddTask(name, status, timeStamp);

            string completion = ", task incomplete";
            if(status)
            {
                completion = ", task complete";
            }

            string exptected = "Go shopping, task complete, task created 22-06-2013 11:21\n"+
                name + completion + ", task created " + timeStamp;


            string result = idManager.ViewHistory();

            Assert.That(result == exptected);
        }
    }
}
