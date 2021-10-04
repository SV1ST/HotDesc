using HotDesc.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotDesc.Repositories
{
    public class ReservationRepository : IReservationRepository
    {
        private ApplicationContext db;

        public ReservationRepository(ApplicationContext context)
        {
            db = context;
        }
        public async Task<List<Reservation>> GetAllData()
        {
            return await db.Reservations.ToListAsync();
        }
        public async Task DeleteReservation(int id)
        {
            var reservation = db.Reservations.Where(x => x.Id == id).FirstOrDefault();
            var workplace = db.Workplaces.Where(x => x.ReservationId == id).FirstOrDefault();
            workplace.ReservationId = null;
            workplace.IsInUse = false;
            workplace.Devices = null;
            db.Remove(reservation);
            await db.SaveChangesAsync();

        }
        public async Task Book(int workplaces, string userHold, bool mouse, bool keyboard, bool systemUnit, bool monitor, bool notebook)
        {
            string chosenDevices = "";

            if (mouse)
                chosenDevices += "mouse ";
            if (keyboard)
                chosenDevices += "key ";
            if (systemUnit)
                chosenDevices += "systemUnit ";
            if (monitor)
                chosenDevices += "monitor ";
            if (notebook)
                chosenDevices += "notebook ";

            var workplace = db.Workplaces.Where(x => x.Id == Convert.ToInt32(workplaces)).FirstOrDefault();

            workplace.IsInUse = true;
            
            Employee employee = db.Employees.Where(x => x.Login == userHold).FirstOrDefault();
            Reservation reservation = new Reservation { EmployeeId = employee.Id, Date = DateTime.Now };
            workplace.Reservation = reservation;
            db.Reservations.Add(reservation);
            workplace.Devices = chosenDevices;
            await db.SaveChangesAsync();
        }
        public async Task<List<Reservation>> DeleteReservationForUser(int fold)
        {
            return await db.Reservations.Where(x => x.EmployeeId == Convert.ToInt32(fold)).ToListAsync();
        }
        public async Task DeleteReservationForUser(int id, int fold)
        {
            var reservation = db.Reservations.Where(x => x.Id == id).FirstOrDefault();
            var workplace = db.Workplaces.Where(x => x.ReservationId == id).FirstOrDefault();
            workplace.ReservationId = null;
            workplace.IsInUse = false;
            workplace.Devices = null;
            db.Remove(reservation);
            await db.SaveChangesAsync();
        }

    }
}
