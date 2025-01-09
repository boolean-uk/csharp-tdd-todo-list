using tdd_todo_list.CSharp.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test;

[TestFixture]
public class ExtensionTests
{
    [Test]
    public void UpdateTaskTitleTest()
    {
        TodoListExtension todoList = TodoListExtension.CreateList("A", "A");
        todoList.AddTask("B", "B");
        todoList.UpdateTaskTitle(todoList.Tasks[0].UUID, "C");
        Assert.That(todoList.Tasks[0].Title, Is.EqualTo("C"));
    }
}
