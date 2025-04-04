using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;
using System.Xml;
using Microsoft.AspNetCore.Mvc;

public class Booking
{
    public string room { get; set; }
    public DateTime BookingDate { get; set; }
    public static string BookingTime { get; set; }
    public string Comment { get; set; }


    public class BookingController<var> : Controller
    {
        private static List<Booking> bookings = new List<Booking>();


        public IActionResult BookRoom(string room)
        {
            ViewBag.Room = room;
            return View();
        }

        public IActionResult SubmitBooking(string room, DateTime bookingDate, string BookingTime, string comment)
        {
            if (string.IsNullOrEmpty(room) || string.IsNullOrEmpty(BookingTime) || string.IsNullOrEmpty(comment))
                return View("Error", new { message = "Alle felter skal udfyldes." });
            return null;
        }
        
    }
}

