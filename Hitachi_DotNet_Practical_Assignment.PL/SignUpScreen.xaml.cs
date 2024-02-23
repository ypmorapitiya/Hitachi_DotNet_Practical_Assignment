using Hitachi_DotNet_Practical_Assignment.DAL.Models.DTOs;
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

namespace Hitachi_DotNet_Practical_Assignment.PL
{
    /// <summary>
    /// Interaction logic for SignUpScreen.xaml
    /// </summary>
    public partial class SignUpScreen : Window
    {
        public SignUpScreen()
        {
            InitializeComponent();
        }
        private void SignUp_Click(object sender, RoutedEventArgs e)
        {
            var newUser = new SignUpDTO()
            {
                FirstName = FirstNameText.Text,
                LastName = LastNameText.Text,
                Email = EmailText.Text,
                Password = PasswordText.Password
            };
            if (newUser.FirstName == "" || newUser.LastName == "" ||
                newUser.Password == "" || newUser.Email == "")
            {
                MessageBox.Show("Fill all the feilds");
                return;
            }
            UserServiceWCF.Service1Client client = new UserServiceWCF.Service1Client();
            var result = client.SignUp(newUser);
            MessageBox.Show(result.ToString());
            FirstNameText.Text = "";
            LastNameText.Text = "";
            EmailText.Text = "";
            PasswordText.Password = ""; 
        }

        private void ToSignIn_Click(object sender, RoutedEventArgs e)
        {
            LoginScreen login = new LoginScreen();
            this.Close();
            login.Show();

        }
    }
}
