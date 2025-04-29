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
    public partial class User_Profile : Form
    {
        private User user;
        private IDataStorage<Booking> bookingStorage = new JsonStorage<Booking>(@"D:\Learning\ОП\Hotel_Booking\WinForms_Hotel\WinForms_Hotel\Storages\bookingStorage.json");
        private BookingRepository<Booking> bookingRepository;
        public User_Profile(User user)
        {
            InitializeComponent();

            this.user = user;
            bookingRepository = new BookingRepository<Booking>(bookingStorage);

            lblUsername.Text = user.Name;


            if (!user.Admin)
            {
                // Фільтруємо бронювання тільки для поточного користувача
                var userBookings = bookingRepository.GetAll().Where(b => b.User.Id == user.Id).ToList();

                var bookingDetails = userBookings.Select(b => new
                {
                    HotelName = b.Hotel.Name,
                    RoomType = b.Room.TypeOfRoom,
                    DateIn = b.DateIn,
                    DateOut = b.DateOut,
                    Status = b.Status
                }).ToList();

                listBooked.DataSource = bookingDetails;
            }
            else
            {
                var userBookings = bookingRepository.GetAll();

                var bookingDetails = userBookings.Select(b => new
                {
                    _User = b.User.Name,
                    HotelName = b.Hotel.Name,
                    RoomType = b.Room.TypeOfRoom,
                    DateIn = b.DateIn,
                    DateOut = b.DateOut,
                    Status = b.Status
                }).ToList();

                listBooked.DataSource = bookingDetails;
            }


        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (listBooked.SelectedRows.Count > 0)
            {
                var selectedRow = listBooked.SelectedRows[0];

                string hotelName = selectedRow.Cells["HotelName"].Value.ToString();
                string roomType = selectedRow.Cells["RoomType"].Value.ToString();
                string dateIn = selectedRow.Cells["DateIn"].Value.ToString();
                string dateOut = selectedRow.Cells["DateOut"].Value.ToString();

                var result = MessageBox.Show($"Ви впевнені, що хочете видалити бронювання для готелю '{hotelName}' на період з {dateIn} по {dateOut}?",
                    "Підтвердження видалення", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    var bookingToRemove = bookingRepository.GetAll().FirstOrDefault(b => b.Hotel.Name == hotelName &&
                                                                                         b.Room.TypeOfRoom == roomType &&
                                                                                         b.DateIn == dateIn &&
                                                                                         b.DateOut == dateOut);

                    if (bookingToRemove != null)
                    {
                        bookingRepository.Remove(bookingToRemove.Id);
                        bookingStorage.Save();

                        var updatedBookings = bookingRepository.GetAll().Where(b => b.User.Id == user.Id).Select(b => new
                        {
                            HotelName = b.Hotel.Name,
                            RoomType = b.Room.TypeOfRoom,
                            DateIn = b.DateIn,
                            DateOut = b.DateOut,
                            Status = b.Status
                        }).ToList();

                        listBooked.DataSource = updatedBookings;
                        MessageBox.Show("Бронювання успішно видалено.");
                    }
                    else
                    {
                        MessageBox.Show("Не вдалося знайти вибране бронювання.");
                    }
                }
            }
            else
            {
                MessageBox.Show("Будь ласка, виберіть бронювання для видалення.");
            }
        }


    }
}
