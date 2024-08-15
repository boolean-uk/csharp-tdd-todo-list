using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_todo_list.CSharp.Main
{

    public class TodoTaskObj
    {
        private string contentText;
        //True if complete false if incomplete
        private bool complete;

        public TodoTaskObj(string contentText, bool Complete)
        {
            this.contentText = contentText;
            this.complete = Complete;
        }

        public TodoTaskObj(string contentText)
        {
            this.contentText = contentText;
            this.complete = false;
        }

        public string ContentText
        {
            get { return contentText; }

        }

        public bool Complete
        {
            get { return complete; }
            set { complete = value; }
        }

        public void ChangeStatus()
        {
            if (complete)
            {
                complete = false;
            }
            else
            {
                complete = true;
            }
        }
        override
        public string ToString()
        {
            string status;
            if (Complete) 
            {
                status = "Completed"; 
            } else { 
                status = "Inomplete"; 
            }
            return $"{this.contentText} => {status}"; 
        }
    }
}

