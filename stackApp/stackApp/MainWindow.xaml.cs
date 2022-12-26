using System;
using System.Collections;
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

namespace stackApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Stack stack;
        public MainWindow()
        {
            InitializeComponent();
            stack = new Stack();
        }

        private void bttnAdd_Click(object sender, RoutedEventArgs e)
        {
            stack.Push(txtValue.Text);
            txtValue.Clear();

            foreach (string data in stack)
            {
                MessageBox.Show(data);
                
            }

        }
    }
}
