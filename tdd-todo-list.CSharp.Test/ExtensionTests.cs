using tdd_todo_list.CSharp.Main;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace tdd_todo_list.CSharp.Test
{
    public class ExtensionTests
    {
        private TodoListExtension _extension;
        public ExtensionTests()
        {
            _extension = new TodoListExtension();
        }

        [TestCase(2)]
        public void GetTask(int id)
        {
            //Arreng
            TodoListExtension ext = new TodoListExtension();

            //Act 
            ext.getTaskById(id);

            //Assert
            
        }   
    }
}
