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
            selectStars.Items.AddRange(new object[] { 1, 2, 3, 4, 5 });
            selectStars.SelectedIndex = 4;
        }

        private void btnAddHotel_Click(object sender, EventArgs e)
        {
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

            Hotel newHotel = new Hotel(
                txtboxHotelName.Text,
                txtboxLocation.Text,
                txtboxDescription.Text,
                id,
                (int)selectStars.SelectedItem
            );

            var validationResults = ValidationService.Validate(newHotel);
            if (validationResults.Any())
            {
                MessageBox.Show(string.Join("\n", validationResults.Select(r => r.ErrorMessage)), "Помилки валідації", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            hotelRepository.Add(newHotel);
            MessageBox.Show("Готель успішно додано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
