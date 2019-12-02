using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Doctor_sAppointmentBookingSystem.Models
{
    class Database
    {
        public Users Users { get; set; }
        public Patients Patients { get; set; }
        public Doctors Doctors  { get; set; }
        public Departments Departments { get; set; }
        public Admins Admins { get; set; }
        public  Reports Reports { get; set; }
        public Bookings Bookings { get; set; }

        public Database()
        {
            Users = new Users();
            Patients= new Patients();
            Doctors = new Doctors();
            Departments = new Departments();
            Reports = new Reports();
            Bookings = new Bookings();
            Admins = new Admins();

        }
    }
}
