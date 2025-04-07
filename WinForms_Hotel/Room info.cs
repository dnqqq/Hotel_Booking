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

namespace WinForms_Hotel
{
    public partial class Room_info : Form
    {
        private Room _room;
        public Room_info(Room room)
        {
            InitializeComponent();
            _room = room;

            lblTypeOfRoom.Text = _room.TypeOfRoom;
            lblMaxGuests.Text = "Max Guests: " + _room.MaxGuests.ToString();
            lblPrice.Text = "Price: " + _room.Price.ToString();
            lblHotelName.Text = "Hotel Name: " + _room.HotelName;
        }

        private void btnBook_Click(object sender, EventArgs e)
        {

        }
    }
}
