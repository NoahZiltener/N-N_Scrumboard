using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_N_Scrumboard.Model
{
    class Task
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

        /*private user _assinedTo;

        public string AssinedTo
        {
            get { return _assinedTo; }

            set { _assinedTo = value; }
        }*/
    }
}
