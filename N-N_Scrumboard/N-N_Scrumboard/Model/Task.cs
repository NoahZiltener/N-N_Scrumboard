using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_N_Scrumboard.Model
{
    public class Task
    { 
        private string _title;

        public string Title
        {
            get { return _title; }

            set { _title = value; }
        }

        private string _description;

        public string Description
        {
            get { return _description; }

            set { _description = value; }
        }

        private User _assinedTo;

        public User AssinedTo
        {
            get { return _assinedTo; }

            set { _assinedTo = value; }
        }

        public override string ToString()
        {
            return Title;
        }
    }
}
