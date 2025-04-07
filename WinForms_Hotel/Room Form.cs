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
    public partial class Room_Form : Form
    {
        private RoomRepository<Room> roomRepository = new RoomRepository<Room>();
        public Room_Form()
        {
            InitializeComponent();


            Room room1 = new Room("Hilton", "Lux", 4, 150, true, 1);
            Room room2 = new Room("Radison", "Standart", 2, 70, false, 2);


            roomRepository.Add(room1);
            roomRepository.Add(room2);

            listAlailableRooms.DataSource = roomRepository.GetAll();
            listAlailableRooms.DisplayMember = "TypeOfRoom"; //sdlffffffffffffffffffffffffffffffffffffff
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            Room_Add roomAddForm = new Room_Add(roomRepository);

            roomAddForm.FormClosed += (s, args) =>
            {
                listAlailableRooms.DataSource = null;
                listAlailableRooms.DataSource = roomRepository.GetAll();
                listAlailableRooms.DisplayMember = "TypeOfRoom"; //fsdsdsdsdsdsdsdsdsdsdsdsdsdsdsd
            };

            roomAddForm.Show();
        }

        private void btnRemoveRoom_Click(object sender, EventArgs e)
        {
            if (listAlailableRooms.SelectedItem != null)
            {
                Room selectedRoom = (Room)listAlailableRooms.SelectedItem;

                roomRepository.Remove(selectedRoom);

                listAlailableRooms.DataSource = null;
                listAlailableRooms.DataSource = roomRepository.GetAll();
                listAlailableRooms.DisplayMember = "TypeOfRoom"; //dssssssssssssssssssssss
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
                    listAlailableRooms.DisplayMember = "TypeOfRoom"; //fffffffffffffffffffffffff
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
