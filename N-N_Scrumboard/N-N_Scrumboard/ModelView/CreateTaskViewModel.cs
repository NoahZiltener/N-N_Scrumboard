using N_N_Scrumboard.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task = N_N_Scrumboard.Model.Task;

namespace N_N_Scrumboard.ModelView
{
    class CreateTaskViewModel : INotifyPropertyChanged
    {
        private Board _board;
        private Task _task;

        public CreateTaskViewModel() 
        {
            _board = Board.getInstance();
            _task = new Task();
        }

        public Task Task
        {
            get { return _task; }
            set
            {
                if (_task != value)
                {
                    _task = value;
                    OnPropertyChange("Task");
                }
            }
        }

        public String Title
        {
            get { return _task.Title; }
            set
            {
                if (_task.Title != value)
                {
                    _task.Title = value;
                    OnPropertyChange("Title");
                }
            }
        }

        public String Description
        {
            get { return _task.Description; }
            set
            {
                if (_task.Description != value)
                {
                    _task.Description = value;
                    OnPropertyChange("Description");
                }
            }
        }

        public User AssinedTo
        {
            get { return _task.AssinedTo; }
            set
            {
                if (_task.AssinedTo != value)
                {
                    _task.AssinedTo = value;
                    OnPropertyChange("AssinedTo");
                }
            }
        }

        public List<User> Users
        {
            get { return _board.Users; }
        }

        public void CreateTask()
        {
            if(!(_board.ToDo.Contains(_task) || _board.InProgress.Contains(_task) || _board.Review.Contains(_task) || _board.Done.Contains(_task)))
            {
                _board.ToDo.Add(_task);
            }
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
