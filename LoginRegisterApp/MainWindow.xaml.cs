using System;
using System.Data.SQLite;
using System.Windows;
using System.Windows.Media.Imaging;
using System.IO;
using System.Threading.Tasks;

namespace AuthorizationApp
{
    public partial class MainWindow : Window
    {
        private const string ConnectionString = "Data Source=Atlant.db;Version=3;";

        public MainWindow()
        {
            InitializeComponent();

            using (var connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string sql = @"CREATE TABLE IF NOT EXISTS Users (
                                Login TEXT NOT NULL,
                                Password TEXT NOT NULL
                           );";

                using (var command = new SQLiteCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        private void ExtBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            HideUserInformation();
            string login = txtLogin.Text;
            string password = txtPassword.Password;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Пожалуйста, введите логин и пароль.", "Ошибка получения данных");
                return;
            }

            if (AuthenticateUser(login, password))
            {
                DisplayUserInformation(login);
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль.\nУбедитесь в правильности ввода данных", "Ошибка входа");
            }
        }

        private bool AuthenticateUser(string login, string password)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE Login = @Login AND Password = @Password";
                
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@Password", password);

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    connection.Close();

                    return count > 0;
                }
            }
        }

        private void DisplayUserInformation(string login)
        {
           
            string gifSuccess = "loading-success.gif";
            string currentDirectory = Directory.GetCurrentDirectory();
            string gifSuccessPath = Path.Combine(currentDirectory, gifSuccess);
            userImage.Source = new BitmapImage(new Uri(gifSuccessPath));
            loginText.Content = $"{login},";
            welcomeText.Content = "Добро пожаловать в систему 'Атлант'!";
            welcomeText.Visibility = Visibility.Visible;
            loginText.Visibility = Visibility.Visible;
        }

        private void HideUserInformation()
        {
            string pngUser = "user-icon-default.jpg";
            string currentDirectory = Directory.GetCurrentDirectory();
            string pngUserPath = Path.Combine(currentDirectory, pngUser);
            userImage.Source = new BitmapImage(new Uri(pngUserPath));
            welcomeText.Visibility = Visibility.Hidden;
            loginText.Visibility = Visibility.Hidden;
        }

        private void ClearUser_Click(object sender, RoutedEventArgs e)
        {
            HideUserInformation();
            string login = txtLogin.Text;
            string password = txtPassword.Password;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Пожалуйста, введите логин и пароль.", "Ошибка получения данных");
                return;
            }

            if (UserExists(login) != true)
            {
                MessageBox.Show("Пользователь с таким логином не существует в системе 'Атлант'.", "Ошибка очистки");
                return;
            }
            if (DeleteUser(login, password))
            {
                MessageBox.Show("Пользователь очищен из системы 'Атлант'.", "Успешно");
                return;
            }
        }

        private void ListButton_Click(object sender, RoutedEventArgs e)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT Login, Password FROM Users";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        string userList = "Список зарегистрированных пользователей:\n";

                        while (reader.Read())
                        {
                            userList += reader["Login"].ToString() + " - " + reader["Password"].ToString() + "\n";
                        }

                        MessageBox.Show(userList, "Список пользователей");
                    }
                }

                connection.Close();
            }
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            HideUserInformation();
            string login = txtLogin.Text;
            string password = txtPassword.Password;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Пожалуйста, введите логин и пароль.", "Ошибка получения данных");
                return;
            }

            if (UserExists(login))
            {
                MessageBox.Show("Пользователь с таким логином уже существует в системе 'Атлант'.", "Ошибка регистрации");
                return;
            }

            if (InsertUser(login, password))
            {
                MessageBox.Show("Теперь вы можете войти в систему 'Атлант'.", "Регистрация завершена");
            }
            else
            {
                MessageBox.Show("Пожалуйста, обратитесь к вашему администратору для решения вопроса.", "Ошибка регистрации");
            }
        }

        private bool UserExists(string login)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE Login = @Login";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Login", login);

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    connection.Close();

                    return count > 0;
                }
            }
        }

        private bool InsertUser(string login, string password)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string query = "INSERT INTO Users (Login, Password) VALUES (@Login, @Password)";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@Password", password);

                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    return rowsAffected > 0;
                }
            }
        }

        private bool DeleteUser(string login, string password)
        {
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                connection.Open();
                string query = "DELETE FROM Users WHERE Login = @Login AND Password = @Password";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Login", login);
                    command.Parameters.AddWithValue("@Password", password);

                    int rowsAffected = command.ExecuteNonQuery();
                    connection.Close();

                    return rowsAffected > 0;
                }
            }
        }

    } 
}
