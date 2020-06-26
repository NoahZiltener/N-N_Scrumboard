using N_N_Scrumboard.ModelView;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace N_N_Scrumboard.View
{
    /// <summary>
    /// Interaction logic for CreateUserView.xaml
    /// </summary>
    public partial class CreateUserView : Window
    {
        private readonly CreateUserViewModel _CreateUserViewModel;
        public CreateUserView()
        {
            InitializeComponent();
            _CreateUserViewModel = new CreateUserViewModel();
            DataContext = _CreateUserViewModel;
        }

        private void ButtonSave(object sender, RoutedEventArgs e)
        {
            if(String.IsNullOrEmpty(Name.Text) || String.IsNullOrEmpty(Job.Text))
            {
                MessageBox.Show("Please enter a Name and Job.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                _CreateUserViewModel.CreateUser();
                Close();
            }
        }
    }
}
