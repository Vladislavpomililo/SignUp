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

namespace SignUp
{ 

    public partial class MainWindow : Window
    {
        Context db;

        public MainWindow()
        {
            InitializeComponent();

            db = new Context();
        }

        private void Button_Click_Reg(object sender, RoutedEventArgs e)
        {

            EmailTextBox.Background = Brushes.Transparent;
            PassTextBox.Background = Brushes.Transparent;
            PassTextBox2.Background = Brushes.Transparent;
            LoginTextBox.Background = Brushes.Transparent;

            string email = EmailTextBox.Text.Trim().ToLower();
            string password = PassTextBox.Password.Trim();
            string password2 = PassTextBox2.Password.Trim();
            string login = LoginTextBox.Text.Trim();

            if (email.Length < 5 || !email.Contains("@") || !email.Contains("."))
            {
                EmailTextBox.ToolTip = "Incorrect";
                EmailTextBox.Background = Brushes.Red;
            }
           
            else if(password.Length < 5)
            {
                PassTextBox.ToolTip = "Incorrect";
                PassTextBox.Background = Brushes.Red;
            }

            else if(password != password2)
            {
                PassTextBox2.ToolTip = "Incorrect";
                PassTextBox2.Background = Brushes.Red;
            }

            else if (login.Length < 5)
            {
                LoginTextBox.ToolTip = "Incorrect";
                LoginTextBox.Background = Brushes.Red;
            }

            else
            {
                EmailTextBox.ToolTip = null;
                EmailTextBox.Background = Brushes.Transparent;
                PassTextBox.ToolTip = null;
                PassTextBox.Background = Brushes.Transparent;
                PassTextBox2.ToolTip = null;
                PassTextBox2.Background = Brushes.Transparent;
                LoginTextBox.ToolTip = null;
                LoginTextBox.Background = Brushes.Transparent;


                MessageBox.Show("good");

                User user = new User(email, password, login);

                db.Users.Add(user);
                db.SaveChanges();

                SignIn signIn = new SignIn();
                signIn.Show();
                this.Close();
            }

        }

        private void Button_Click_SignIn(object sender, RoutedEventArgs e)
        {
            SignIn signIn = new SignIn();
            signIn.Show();
            this.Close();
        }
    }
}
