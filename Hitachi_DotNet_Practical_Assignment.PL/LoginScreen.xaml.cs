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
    /// Interaction logic for LoginScreen.xaml
    /// </summary>
    public partial class LoginScreen : Window
    {
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            var user = new SignInDTO()
            {
                Email = UsernameText.Text,
                Password = PasswordText.Password
            };

            if (user.Email == "" || user.Password == "")
            {
                MessageBox.Show("Fill all the feilds");
                return;
            }
            UserServiceWCF.Service1Client client = new UserServiceWCF.Service1Client();


            var result = client.SignIn(user);

            MessageBox.Show(result);
            UsernameText.Text = "";
            PasswordText.Password = "";

        }
        private void ToSignUp_Click(object sender, RoutedEventArgs e)
        {
            SignUpScreen register = new SignUpScreen();
            this.Close();
            register.Show();

        }
    }
}
