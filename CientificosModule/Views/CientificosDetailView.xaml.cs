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
    /// Interaction logic for CientificosDetailView.xaml
    /// </summary>
    public partial class CientificosDetailView : UserControl
    {
        public CientificosDetailView(CientificosDetailViewModel model)
        {
            InitializeComponent();
            this.DataContext = model;
        }
    }
}
