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
    public partial class Hotel_Edit : Form
    {
        private HotelRepository<Hotel> hotelRepository;
        private Hotel hotelToEdit;
        public Hotel_Edit(HotelRepository<Hotel> repository, Hotel hotel)
        {
            InitializeComponent();
            hotelRepository = repository;
            hotelToEdit = hotel;
            InitializeStarsComboBox();
            FillFields();
        }

        private void InitializeStarsComboBox()
        {
            selectStars.Items.Add(1);
            selectStars.Items.Add(2);
            selectStars.Items.Add(3);
            selectStars.Items.Add(4);
            selectStars.Items.Add(5);
            selectStars.SelectedIndex = hotelToEdit.Stars - 1;
        }

        private void FillFields()
        {
            txtboxID.Text = hotelToEdit.Id.ToString();
            txtboxHotelName.Text = hotelToEdit.Name;
            txtboxLocation.Text = hotelToEdit.Location;
            txtboxDescription.Text = hotelToEdit.Description;
            selectStars.SelectedItem = hotelToEdit.Stars;
        }

        private void btnEditHotel_Click(object sender, EventArgs e)
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

            Hotel existingHotel = hotelRepository.GetById(id);
            if (existingHotel == null || existingHotel.Id != hotelToEdit.Id)
            {
                MessageBox.Show("Цей id не знайдений або вже використовуваний для іншого готелю.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            hotelToEdit.Name = txtboxHotelName.Text;
            hotelToEdit.Location = txtboxLocation.Text;
            hotelToEdit.Description = txtboxDescription.Text;
            hotelToEdit.Stars = (int)selectStars.SelectedItem;

            hotelRepository.Update(hotelToEdit);

            MessageBox.Show("Готель успішно оновлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
