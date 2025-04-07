using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinForms_Hotel.Classes;
using WinForms_Hotel.Repositories;

namespace WinForms_Hotel
{
    public partial class Hotel_Add : Form
    {
        private HotelRepository<Hotel> hotelRepository;
        public Hotel_Add(HotelRepository<Hotel> repository)
        {
            InitializeComponent();
            hotelRepository = repository;
            InitializeStarsComboBox();
        }

        private void InitializeStarsComboBox()
        {
            selectStars.Items.Add(1);
            selectStars.Items.Add(2);
            selectStars.Items.Add(3);
            selectStars.Items.Add(4);
            selectStars.Items.Add(5);
            selectStars.SelectedIndex = 4;
        }

        private void btnAddHotel_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtboxHotelName.Text) || string.IsNullOrEmpty(txtboxLocation.Text) || string.IsNullOrEmpty(txtboxDescription.Text) || string.IsNullOrEmpty(txtboxID.Text))
            {
                MessageBox.Show("Будь ласка, заповніть усі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtboxID.Text, out int id))
            {
                MessageBox.Show("Введіть правильний id (число).", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var hotel in hotelRepository.GetAll())
            {
                if (hotel.Id == id)
                {
                    MessageBox.Show("Цей id вже зайнятий. Виберіть інший id.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            string name = txtboxHotelName.Text;
            string location = txtboxLocation.Text;
            string description = txtboxDescription.Text;
            int stars = (int)selectStars.SelectedItem;

            Hotel_5Star newHotel = new Hotel_5Star(name, location, description, id, stars);

            hotelRepository.Add(newHotel);

            MessageBox.Show("Готель успішно додано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
