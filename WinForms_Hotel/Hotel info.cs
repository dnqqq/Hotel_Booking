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
    public partial class Hotel_info : Form
    {
        private bool isAdmin;
        private Hotel _hotel;
        public Hotel_info(Hotel hotel, bool isAdmin)
        {
            InitializeComponent();
            _hotel = hotel;
            this.isAdmin = isAdmin;

            lblHotelName.Text = _hotel.Name;
            lblHotelLocation.Text = _hotel.Location;
            lblHotelDescription.Text = _hotel.Description;
            lblHotelStars.Text = $"{_hotel.Stars} Stars";
        }

        private void btnShowRooms_Click(object sender, EventArgs e)
        {

            Room_Form roomForm = new Room_Form(isAdmin);

            roomForm.Show();
        }

    }
}
