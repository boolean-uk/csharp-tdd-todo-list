using tdd_todo_list.CSharp.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    [TestFixture]
    public class ExtensionTests
    {
        private TodoListExtension _extension;
        public ExtensionTests()
        {
            _extension = new TodoListExtension();
        }
        [Test]
        public void searchTaskByIdTest()
        {
            _extension.addTask("Cut firewood", 111);
            _extension.addTask("Go fishing", 112);
            _extension.addTask("Help grandma", 113);
            _extension.addTask("Fix hole in roof", 114);
            Assert.True(_extension.searchTaskById(111));
            Assert.True(_extension.searchTaskById(112));
            Assert.True(_extension.searchTaskById(114));
            Assert.False(_extension.searchTaskById(2));
            Assert.False(_extension.searchTaskById(115));
        }
        [Test]
        public void updateNameTest()
        {
            _extension.addTask("Cut firewood", 111);
            _extension.addTask("Go fishing", 112);
            _extension.addTask("Help grandma", 113);
            _extension.addTask("Fix hole in roof", 114);
            Assert.AreEqual("Chop firewood", _extension.updateName(111, "Chop firewood"));
            Assert.AreEqual("Bring grandma food", _extension.updateName(113, "Bring grandma food"));
            Assert.AreNotEqual("Cut firewood", _extension.updateName(111, "Chop firewood"));
            Assert.AreNotEqual("Help grandma", _extension.updateName(113, "Bring grandma food"));
        }
        [Test]
        public void changeStatusTest()
        {
            _extension.addTask("Cut firewood", 111);
            _extension.addTask("Go fishing", 112);
            _extension.addTask("Help grandma", 113);
            _extension.addTask("Fix hole in roof", 114);
            Assert.True(_extension.completeTask(111));
            Assert.True(_extension.completeTask(112));
        }
    }
}
