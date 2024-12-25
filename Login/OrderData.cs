﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public static class OrderData
    {
        public static string MovieTitle { get; set; }
        public static string Studio { get; set; }
        public static string Ticket { get; set; }
        public static string ShowTime { get; set; }
        public static string Date { get; set; }
        public static string SeatNumber { get; set; }
        public static string PaymentMethod { get; set; }
        public static string TotalPrice { get; set; }
        public static int TicketCount { get; set; }
  
    }
    public static class GlobalHistory
    {
       
        public static List<ListViewItem> HistoryItems { get; set; } = new List<ListViewItem>();
        public static int OrderCounter { get; set; } = 1; // Mulai dari nomor pesanan 1

    }


}
