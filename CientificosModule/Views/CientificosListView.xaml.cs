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
using System.Windows.Navigation;
using System.Windows.Shapes;
using CientificosModule.ViewModels;


namespace CientificosModule.Views
{
    /// <summary>
    /// Interaction logic for CientificosList.xaml
    /// </summary>
    public partial class CientificosListView : UserControl
    {
        public CientificosListView(CientificosListViewModel viewmodel)
        {
            InitializeComponent();
            this.DataContext = viewmodel;
        }
    }
}
