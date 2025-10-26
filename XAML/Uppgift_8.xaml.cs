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

namespace XAML
{
    /// <summary>
    /// Interaction logic for Uppgift_8.xaml
    /// </summary>
    public partial class Uppgift_8 : Window
    {
        public Uppgift_8()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            string firstname = FirstNameBox.Text;
            string lastname = LastNameBox.Text;
            string email = EmailBox.Text;

            if (!string.IsNullOrEmpty(firstname) &&
                !string.IsNullOrEmpty(lastname))

            {
                string studentInfo = $"{firstname} {lastname} ({email})";

                StudentList.Items.Add(studentInfo);
            }
        }
    }
}
