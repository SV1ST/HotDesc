using HotDesc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotDesc.Repositories
{
    public interface IReservationRepository
    {
        Task<List<Reservation>> GetAllData();
        Task<List<Reservation>> DeleteReservationForUser(int fold);
        Task DeleteReservationForUser(int id, int fold);
        Task DeleteReservation(int id);
        Task Book(int workplaces, string userHold, bool mouse, bool keyboard, bool systemUnit, bool monitor, bool notebook);
    }
}
