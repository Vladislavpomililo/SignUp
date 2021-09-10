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

namespace SignUp
{

    public partial class SignIn : Window
    {

        public SignIn()
        {
            InitializeComponent();

        }

        private void Button_Click_SignInApp(object sender, RoutedEventArgs e)
        {
            
            string password = PassTextBox.Password.Trim();
            string login = LoginTextBox.Text.Trim();

            if (password.Length < 5)
            {
                PassTextBox.ToolTip = "Incorrect";
                PassTextBox.Background = Brushes.Red;
            }

            else if (login.Length < 5)
            {
                LoginTextBox.ToolTip = "Incorrect";
                LoginTextBox.Background = Brushes.Red;
            }
            else
            {
                PassTextBox.ToolTip = null;
                PassTextBox.Background = Brushes.Transparent;
                LoginTextBox.ToolTip = null;
                LoginTextBox.Background = Brushes.Transparent;

                User userSignIn = null;
                using(Context dbContext = new Context())
                {
                    userSignIn = dbContext.Users.Where(a=>a.Login == login && a.Password == password).FirstOrDefault();
                }

                if(userSignIn != null)
                {
                    UserWindow userWindow = new UserWindow();
                    userWindow.Show();
                    Close();
                }
                else
                {
                    MessageBox.Show("Incorrect");
                }

            }


        }

        private void Button_Click_SignUp(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
