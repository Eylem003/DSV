using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

public class Booking
{
    public string room { get; set; }
    public DateTime BookingDate { get; set; }
    public static string BookingTime { get; set; }
    public string Comment { get; set; }

    public class BookingController : Controller
    {
        private static List<Booking> bookings = new List<Booking>();


        public IActionResult BookRoom(string room)
        {
            ViewBag.Room = room;
            return View();
        }

        public IActionResult SubmitBooking(string room, DateTime BookingDate, string BookingTime, string comment)
        {
            if (string.IsNullOrEmpty(room) || string.IsNullOrEmpty(BookingTime) || string.IsNullOrEmpty(comment))
                return View("Error", new { message = "Alle felter skal udfyldes." });
        }
    }
}
