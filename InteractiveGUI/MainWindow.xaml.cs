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

namespace InteractiveGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        Controller c = Controller.GetInstance();
        

        List<string> personList = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
        }

      

        private void Delete(object sender, RoutedEventArgs e)
        {
            //Delete
            
        }

        private void Up(object sender, RoutedEventArgs e)
        {
            //Up
            
        }

        private void Down(object sender, RoutedEventArgs e)
        {
            //Down
            
        }

        private void New_Person(object sender, RoutedEventArgs e)
        {
            //New Person
            TextBox1.IsEnabled = true;
            TextBox2.IsEnabled = true;
            TextBox3.IsEnabled = true;
            TextBox4.IsEnabled = true;
            NewPerson.IsEnabled = true;
            DeletePerson.IsEnabled = true;
            UpButton.IsEnabled = true;
            DownButton.IsEnabled = true;
           

            

            string FirstName = TextBox1.Text;
            string LastName = TextBox2.Text;
            int Age = 0;
            string TelephoneNo = TextBox4.Text;
            c.AddPerson();
        }

        private void FirstName(object sender, TextChangedEventArgs e)
        {

        }

        private void LastName(object sender, TextChangedEventArgs e)
        {

        }

        private void Age(object sender, TextChangedEventArgs e)
        {

        }

        private void TelephoneNo(object sender, TextChangedEventArgs e)
        {

        }
    }
}
