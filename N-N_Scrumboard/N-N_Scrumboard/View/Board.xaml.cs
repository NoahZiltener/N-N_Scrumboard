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
    /// Interaction logic for main.xaml
    /// </summary>
    public partial class BoardView : Window
    {
        private readonly BoardViewModel _boardviewModel;
        public BoardView()
        {
            InitializeComponent();
            _boardviewModel = new BoardViewModel();
            DataContext = _boardviewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _boardviewModel.CreateNewTask();
        }
    }
}
