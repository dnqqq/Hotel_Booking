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
    public partial class Room_info : Form
    {
        private User user;
        private Room _room;
        public Room_info(Room room, User user)
        {
            InitializeComponent();
            this.user = user;
            _room = room;

            lblTypeOfRoom.Text = _room.TypeOfRoom;
            lblMaxGuests.Text = "Max Guests: " + _room.MaxGuests.ToString();
            lblPrice.Text = "Price: " + _room.Price.ToString();
            lblHotelName.Text = "Hotel Name: " + _room.HotelName;
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            DateTime dateInSelected = dateIn.Value.Date;
            DateTime dateOutSelected = dateOut.Value.Date;

            if (dateInSelected < dateOutSelected)
            {
                var existingBookings = GetAllBookingsForRoom(_room);
                bool isRoomAvailable = true;

                foreach (var booking in existingBookings)
                {
                    DateTime existingDateIn = DateTime.Parse(booking.DateIn);
                    DateTime existingDateOut = DateTime.Parse(booking.DateOut);

                    // Якщо дати бронювання перетинаються
                    if ((dateInSelected >= existingDateIn && dateInSelected < existingDateOut) ||
                        (dateOutSelected > existingDateIn && dateOutSelected <= existingDateOut) ||
                        (dateInSelected <= existingDateIn && dateOutSelected >= existingDateOut))
                    {
                        isRoomAvailable = false;
                        break;
                    }
                }

                if (isRoomAvailable)
                {
                    // Пошук готелю за його ім'ям
                    //var hotelRepository = new HotelRepository<Hotel>(new JsonStorage<Hotel>(@"D:\\Learning\\ОП\\Hotel_Booking\\WinForms_Hotel\\WinForms_Hotel\\Storages\\hotelStorage.json"));
                    var hotelRepository = new HotelRepository<Hotel>(new MongoStorage<Hotel>("mongodb://localhost:27017", "HotelDB", "Hotels"));
                    Hotel hotel = hotelRepository.GetAll().FirstOrDefault(h => h.Name == _room.HotelName);

                    // Якщо готель знайдений
                    if (hotel != null)
                    {
                        Booking newBooking = new Booking(
                            hotel,          
                            user,           
                            _room,          
                            dateInSelected.ToString("yyyy-MM-dd"),
                            dateOutSelected.ToString("yyyy-MM-dd"),
                            "booked",
                            new Random().Next(1, 1000)  // Генерація випадкового ID
                        );

                        //var bookingRepository = new BookingRepository<Booking>(new JsonStorage<Booking>(@"D:\\Learning\\ОП\\Hotel_Booking\\WinForms_Hotel\\WinForms_Hotel\\Storages\\bookingStorage.json"));
                        var bookingRepository = new BookingRepository<Booking>(new MongoStorage<Booking>("mongodb://localhost:27017", "HotelDB", "Bookings"));

                        var validationResults = ValidationService.Validate(newBooking);
                        if (validationResults.Any())
                        {
                            string errors = string.Join("\n", validationResults.Select(r => r.ErrorMessage));
                            MessageBox.Show(errors, "Помилка валідації", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        bookingRepository.Add(newBooking);

                        MessageBox.Show("Бронювання успішно створено!");

                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Готель не знайдений.");
                    }
                }
                else
                {
                    MessageBox.Show("Ця кімната вже заброньована на ці дати. Спробуйте вибрати інші.");
                }
            }
            else
            {
                MessageBox.Show("Дата виїзду повинна бути пізніше дати заїзду.");
            }
        }


        private List<Booking> GetAllBookingsForRoom(Room room)
        {
            // Отримуємо всі бронювання з репозиторію
            //var bookingRepository = new BookingRepository<Booking>(new JsonStorage<Booking>(@"D:\\Learning\\ОП\\Hotel_Booking\\WinForms_Hotel\\WinForms_Hotel\\Storages\\bookingStorage.json"));
            var bookingRepository = new BookingRepository<Booking>(new MongoStorage<Booking>("mongodb://localhost:27017", "HotelDB", "Bookings"));
            return bookingRepository.GetAll().Where(b => b.Room.Id == room.Id).ToList();
        }


        private void btnProfile_Click(object sender, EventArgs e)
        {
            User_Profile userProfile = new User_Profile(user);
            userProfile.Show();
        }
    }
}
