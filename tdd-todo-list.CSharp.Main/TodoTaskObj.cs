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
        private int id;
        private DateTime combined;

        public TodoTaskObj(string contentText, bool Complete)
        {
            this.contentText = contentText;
            this.complete = Complete;
            this.id = GetHashCode();
            DateTime date = DateTime.Now;
            TimeSpan time = new TimeSpan(36, 0, 0, 0);
            this.combined = date.Add(time);
        }

        public TodoTaskObj(string contentText)
        {
            this.contentText = contentText;
            this.complete = false;
            this.id = GetHashCode();
            DateTime date = DateTime.Now;
            TimeSpan time = new TimeSpan(36, 0, 0, 0);
            this.combined = date.Add(time);
        }

        public string ContentText
        {
            get { return contentText; }
            set { contentText = value; }

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

        public int Id { get { return id; } }

        public DateTime getcreationDateTime() { return combined; }
    }
}

