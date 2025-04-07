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
    public partial class Room_Edit : Form
    {
        private RoomRepository<Room> roomRepository;
        private Room roomToEdit;
        public Room_Edit(RoomRepository<Room> repository, Room room)
        {
            InitializeComponent();
            roomRepository = repository;
            roomToEdit = room;
            FillFields();
        }

        private void FillFields()
        {
            txtboxID.Text = roomToEdit.Id.ToString();
            txtboxTypeOfRoom.Text = roomToEdit.TypeOfRoom;
            txtboxMaxGuests.Text = roomToEdit.MaxGuests.ToString();
            txtboxPrice.Text = roomToEdit.Price.ToString();
        }

        private void btnEditRoom_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtboxTypeOfRoom.Text) || string.IsNullOrEmpty(txtboxMaxGuests.Text) || string.IsNullOrEmpty(txtboxPrice.Text) || string.IsNullOrEmpty(txtboxID.Text))
            {
                MessageBox.Show("Будь ласка, заповніть усі поля.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtboxID.Text, out int id))
            {
                MessageBox.Show("Введіть правильний id (число).", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Room existingRoom = roomRepository.GetById(id);
            if (existingRoom == null || existingRoom.Id != existingRoom.Id)
            {
                MessageBox.Show("Цей id не знайдений або вже використовуваний для іншого номеру.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            roomToEdit.TypeOfRoom = txtboxTypeOfRoom.Text;
            roomToEdit.MaxGuests = int.Parse(txtboxMaxGuests.Text);
            roomToEdit.Price = float.Parse(txtboxPrice.Text);

            roomRepository.Update(roomToEdit);

            MessageBox.Show("Номер успішно оновлено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
