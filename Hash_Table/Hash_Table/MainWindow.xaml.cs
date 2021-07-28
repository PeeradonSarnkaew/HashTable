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

namespace Hash_Table
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hashtable hashtable;
        public MainWindow()
        {
            InitializeComponent();
            hashtable = new Hashtable();
        }

        private void ADD(object sender, RoutedEventArgs e)
        {
            hashtable.Add(keyBox.Text.ToString(),valueBox.Text.ToString());
            MessageBox.Show("Add Key:" + keyBox.Text.ToString() + "Add Value:" + valueBox.Text.ToString());
        }

        private void REMOVE(object sender, RoutedEventArgs e)
        {
            
            hashtable.Remove(keyBox.Text.ToString());
           
            MessageBox.Show("Remove Key:" + keyBox.Text.ToString());
        }

        private void SHOWALL(object sender, RoutedEventArgs e)
        {
            ICollection icollection = hashtable.Keys;
            foreach (string i in icollection)
            {
                MessageBox.Show(hashtable[i].ToString());
            }
        }
    }
}
