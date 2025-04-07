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
    public partial class Room_Add : Form
    {
        private RoomRepository<Room> roomRepository;
        public Room_Add(RoomRepository<Room> repository)
        {
            InitializeComponent();
            roomRepository = repository;
        }


        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtboxHotelName.Text) || string.IsNullOrEmpty(txtboxTypeOfRoom.Text) || string.IsNullOrEmpty(txtboxMaxGuests.Text) || string.IsNullOrEmpty(txtboxPrice.Text) || string.IsNullOrEmpty(txtboxID.Text))
            {
                MessageBox.Show("Будь ласка, заповніть усі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtboxID.Text, out int id))
            {
                MessageBox.Show("Введіть правильний id (число).", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtboxMaxGuests.Text, out int maxGuests))
            {
                MessageBox.Show("Введіть правильну кількість гостей (число).", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!float.TryParse(txtboxPrice.Text, out float price))
            {
                MessageBox.Show("Введіть правильну ціну (число).", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            foreach (var room in roomRepository.GetAll())
            {
                if (room.Id == id)
                {
                    MessageBox.Show("Цей id вже зайнятий. Виберіть інший id.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            string hotelName = txtboxHotelName.Text;
            string typeOfRoom = txtboxTypeOfRoom.Text;

            Room newRoom = new Room(hotelName, typeOfRoom, maxGuests, price, true, id);

            roomRepository.Add(newRoom);

            MessageBox.Show("Готель успішно додано!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
