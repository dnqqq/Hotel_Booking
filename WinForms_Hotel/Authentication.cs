using System;
using System.Windows.Forms;
using WinForms_Hotel.Classes;
using WinForms_Hotel.Repositories;
using System.Collections.Generic;

namespace WinForms_Hotel
{
    public partial class Authentication : Form
    {
        private UserRepository<User> userRepository;

        public Authentication()
        {
            InitializeComponent();
            var storage = new JsonStorage<User>(@"D:\Learning\ОП\Hotel_Booking\WinForms_Hotel\WinForms_Hotel\Storages\usersStorage.json");
            userRepository = new UserRepository<User>(storage);
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            string name = txtboxUsername.Text;
            string password = txtboxPassword.Text;

            var user = userRepository.GetAll().FirstOrDefault(u => u.Name.Equals(name, StringComparison.OrdinalIgnoreCase));

            if (user != null && user.VerifyPassword(password))
            {
                MessageBox.Show("Успішна авторизація!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Hotel_Form hotelForm = new Hotel_Form(user);
                hotelForm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Невірне ім'я користувача або пароль.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void btnSignUp_Click(object sender, EventArgs e)
        {
            string name = txtboxUsername.Text;
            string password = txtboxPassword.Text;

            if (userRepository.GetAll().Any(u => u.Name.Equals(name, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show("Користувач з таким іменем вже існує.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = new Random().Next(1, 10000);

            string salt = BCrypt.Net.BCrypt.GenerateSalt();
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(password + salt);

            bool isAdmin = false; 
            User newUser = new User(name, passwordHash, salt, id, isAdmin);
            userRepository.Add(newUser);

            MessageBox.Show("Реєстрація успішна!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

            Hotel_Form hotelForm = new Hotel_Form(newUser);
            hotelForm.Show();

            this.Hide();
        }

    }
}