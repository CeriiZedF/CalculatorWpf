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

namespace MVVSCalculatorWpf
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private VievModel viev_model;
        public MainWindow()
        {
            InitializeComponent();
            viev_model = new VievModel();
        }

        

        private void combobox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var temp = sender as ComboBox;
            label.Content = VM.Difference(temp.SelectedIndex);
            
        }
    }
}
