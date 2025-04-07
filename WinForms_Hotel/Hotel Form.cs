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
    public partial class Hotel_Form : Form
    {
        private HotelRepository<Hotel> hotelRepository = new HotelRepository<Hotel>();
        public Hotel_Form()
        {
            InitializeComponent();


            Hotel_5Star hotel1 = new Hotel_5Star("Radison", "Kyiv", "Luxury Hotel", 1);
            Hotel_5Star hotel2 = new Hotel_5Star("Hilton", "Lviv", "Comfortable Hotel", 2);
            Hotel_5Star hotel3 = new Hotel_5Star("Premier Palace", "Odesa", "Elite Hotel", 3);


            hotelRepository.Add(hotel1);
            hotelRepository.Add(hotel2);
            hotelRepository.Add(hotel3);

            listAlailableHotels.DataSource = hotelRepository.GetAll();
            listAlailableHotels.DisplayMember = "Name";
        }

        private void btnAddHotel_Click(object sender, EventArgs e)
        {
            Hotel_Add hotelAddForm = new Hotel_Add(hotelRepository);

            hotelAddForm.FormClosed += (s, args) =>
            {
                listAlailableHotels.DataSource = null;
                listAlailableHotels.DataSource = hotelRepository.GetAll();
                listAlailableHotels.DisplayMember = "Name";
            };

            hotelAddForm.Show();
        }

        private void btnRemoveHotel_Click(object sender, EventArgs e)
        {
            if (listAlailableHotels.SelectedItem != null)
            {
                Hotel selectedHotel = (Hotel)listAlailableHotels.SelectedItem;

                hotelRepository.Remove(selectedHotel);

                listAlailableHotels.DataSource = null;
                listAlailableHotels.DataSource = hotelRepository.GetAll();
                listAlailableHotels.DisplayMember = "Name";
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть готель для видалення.");
            }
        }

        private void btnEditHotel_Click(object sender, EventArgs e)
        {
            if (listAlailableHotels.SelectedItem != null)
            {
                Hotel selectedHotel = (Hotel)listAlailableHotels.SelectedItem;

                Hotel_Edit hotelEditForm = new Hotel_Edit(hotelRepository, selectedHotel);

                hotelEditForm.FormClosed += (s, args) =>
                {
                    listAlailableHotels.DataSource = null;
                    listAlailableHotels.DataSource = hotelRepository.GetAll();
                    listAlailableHotels.DisplayMember = "Name";
                };

                hotelEditForm.Show();
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть готель для редагування.");
            }
        }

        private void listAlailableHotels_DoubleClick(object sender, EventArgs e)
        {
            if (listAlailableHotels.SelectedItem != null)
            {
                Hotel selectedHotel = (Hotel)listAlailableHotels.SelectedItem;

                Hotel_info hotelInfoForm = new Hotel_info(selectedHotel);

                hotelInfoForm.Show();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchQuery = txtboxHotelName.Text.Trim();

            if (string.IsNullOrEmpty(searchQuery))
            {
                MessageBox.Show("Будь ласка, введіть назву готелю для пошуку.");
                return;
            }

            Hotel foundHotel = hotelRepository.GetAll().FirstOrDefault(h => h.Name.Contains(searchQuery));
            if (foundHotel != null)
            {
                listAlailableHotels.SelectedItem = foundHotel;
            }
            else
            {
                MessageBox.Show("Готель не знайдено.");
            }
        }
    }
}
