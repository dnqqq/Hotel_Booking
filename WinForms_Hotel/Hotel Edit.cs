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
            selectStars.Items.AddRange(new object[] { 1, 2, 3, 4, 5 });
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
            if (!int.TryParse(txtboxID.Text, out int id))
            {
                MessageBox.Show("Введіть правильний id (число).", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Hotel existingHotel = hotelRepository.GetById(id);
            if (existingHotel != null && existingHotel.Id != hotelToEdit.Id)
            {
                MessageBox.Show("Цей id вже використовуваний для іншого готелю.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            hotelToEdit.Id = id;
            hotelToEdit.Name = txtboxHotelName.Text;
            hotelToEdit.Location = txtboxLocation.Text;
            hotelToEdit.Description = txtboxDescription.Text;
            hotelToEdit.Stars = (int)selectStars.SelectedItem;

            var validationResults = ValidationService.Validate(hotelToEdit);
            if (validationResults.Any())
            {
                MessageBox.Show(string.Join("\n", validationResults.Select(r => r.ErrorMessage)), "Помилки валідації", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            hotelRepository.Update(hotelToEdit);
            MessageBox.Show("Готель успішно оновлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

    }
}
