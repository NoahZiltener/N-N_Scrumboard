using N_N_Scrumboard.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User = N_N_Scrumboard.Model.User;

namespace N_N_Scrumboard.ModelView
{
    class CreateUserViewModel : INotifyPropertyChanged
    {
        private Board _board;
        private User _user;

        public CreateUserViewModel()
        {
            _board = Board.getInstance();
            _user = new User();
        }

        public String Name
        {
            get { return _user.Name; }
            set
            {
                if (_user.Name != value)
                {
                    _user.Name = value;
                    OnPropertyChange("Name");
                }
            }
        }

        public String Job
        {
            get { return _user.Job; }
            set
            {
                if (_user.Job != value)
                {
                    _user.Job = value;
                    OnPropertyChange("Job");
                }
            }
        }

        public void CreateUser()
        {
            _board.Users.Add(_user);

        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
