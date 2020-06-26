using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace N_N_Scrumboard.Model
{
    public class User
    {
        private string _name;
        private string _job;

        public string Name 
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Job
        {
            get { return _job; }
            set { _job = value; }
        }

        public override string ToString()
        {
            return Name + ", " + Job;
        }
    }
}
