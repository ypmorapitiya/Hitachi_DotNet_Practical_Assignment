using Hitachi_DotNet_Practical_Assignment.DAL.Models.Domains;
using Hitachi_DotNet_Practical_Assignment.DAL.Models.DTOs;
using Hitachi_DotNet_Practical_Assignment.DAL.Repositories;
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

namespace Hitachi_DotNet_Practical_Assignment.PL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            var newUser = new SignUpDTO() { 
                FirstName=t1.Text,
                LastName="last",
                Email="ypm@gmail.com",
                Password="123"
            };
            UserServiceWCF.Service1Client client=new UserServiceWCF.Service1Client();
            var result = client.SignUp(newUser);
            MessageBox.Show(result.ToString());
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            var user = new SignInDTO()
            {
                
                Email = t2.Text,
                Password = "123"
            };


            UserServiceWCF.Service1Client client = new UserServiceWCF.Service1Client();
            

            var result = client.SignIn(user);

            MessageBox.Show(result);

        }
    }
}
