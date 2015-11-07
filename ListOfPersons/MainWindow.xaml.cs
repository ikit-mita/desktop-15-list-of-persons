using ListOfPersons.Model;
using System.Windows;
using System.Collections.Generic;
using ListOfPersons.ViewModel;

namespace ListOfPersons
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var vm = (MainViewModel)DataContext;
            try
            {
                if (string.IsNullOrWhiteSpace(newNameTextBox.Text))
                {
                    throw new System.Exception();
                }

                var age = int.Parse(newAgeTextBox.Text);

                vm.AddNewPerson(newNameTextBox.Text, age);
            }
            catch
            {
                MessageBox.Show("Не удалось добавить человека");
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var vm = (MainViewModel)DataContext;
            vm.RemovePerson();
        }
    }
}
