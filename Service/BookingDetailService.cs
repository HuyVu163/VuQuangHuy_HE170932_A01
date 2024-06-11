using BusinessObjects.Models;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class BookingDetailService(BookingDetailRepository bookingDetailRepository)
    {
        private readonly BookingDetailRepository bookingDetailRepository = bookingDetailRepository;

        public IEnumerable<BookingDetail> GetBookingDetailByRoomID(int RoomID)
        {
            return bookingDetailRepository.GetBookingDetailByRoomID(RoomID);
        }

        public IEnumerable<BookingDetail> GetBookingDetailByBookingReservationID(int BookingReservationID)
        {
            return bookingDetailRepository.GetBookingDetailByBookingReservationID(BookingReservationID);
        }

        public IEnumerable<BookingDetail> GetAlls()
        {
            return bookingDetailRepository.GetAlls();
        }
    }
}
