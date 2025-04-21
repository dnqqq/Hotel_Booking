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
using WinForms_Hotel.Interfaces;
using WinForms_Hotel.Repositories;

namespace WinForms_Hotel
{
    public partial class Room_Form : Form
    {
        private bool isAdmin;
        private IDataStorage<Room> roomStorage = new JsonStorage<Room>(@"D:\\Learning\\ОП\\Hotel_Booking\\WinForms_Hotel\\WinForms_Hotel\\Storages\\roomStorage.json");
        private RoomRepository<Room> roomRepository;

        public Room_Form(bool isAdmin)
        {
            InitializeComponent();
            this.isAdmin = isAdmin;

            roomRepository = new RoomRepository<Room>(roomStorage);

            listAlailableRooms.DataSource = roomRepository.GetAll();
            listAlailableRooms.DisplayMember = "TypeOfRoom";

            if (!isAdmin)
            {
                btnAddRoom.Hide();
                btnRemoveRoom.Hide();
                btnEditRoom.Hide();
            }
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            Room_Add roomAddForm = new Room_Add(roomRepository);

            roomAddForm.FormClosed += (s, args) =>
            {
                listAlailableRooms.DataSource = null;
                listAlailableRooms.DataSource = roomRepository.GetAll();
                listAlailableRooms.DisplayMember = "TypeOfRoom";
            };

            roomAddForm.Show();
        }

        private void btnRemoveRoom_Click(object sender, EventArgs e)
        {
            if (listAlailableRooms.SelectedItem != null)
            {
                Room selectedRoom = (Room)listAlailableRooms.SelectedItem;

                roomRepository.Remove(selectedRoom.Id);

                listAlailableRooms.DataSource = null;
                listAlailableRooms.DataSource = roomRepository.GetAll();
                listAlailableRooms.DisplayMember = "TypeOfRoom";
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть номер для видалення.");
            }
        }

        private void btnEditRoom_Click(object sender, EventArgs e)
        {
            if (listAlailableRooms.SelectedItem != null)
            {
                Room selectedRoom = (Room)listAlailableRooms.SelectedItem;

                Room_Edit roomEditForm = new Room_Edit(roomRepository, selectedRoom);

                roomEditForm.FormClosed += (s, args) =>
                {
                    listAlailableRooms.DataSource = null;
                    listAlailableRooms.DataSource = roomRepository.GetAll();
                    listAlailableRooms.DisplayMember = "TypeOfRoom";
                };

                roomEditForm.Show();
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть номер для редагування.");
            }
        }

        private void listAlailableRooms_DoubleClick(object sender, EventArgs e)
        {
            if (listAlailableRooms.SelectedItem != null)
            {
                Room selectedRoom = (Room)listAlailableRooms.SelectedItem;

                Room_info roomInfoForm = new Room_info(selectedRoom);

                roomInfoForm.Show();
            }
        }
    }
}
