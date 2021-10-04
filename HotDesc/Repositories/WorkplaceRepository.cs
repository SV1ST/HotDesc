using HotDesc.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotDesc.Repositories
{
    public class WorkplaceRepository : IWorkplaceRepository
    {
        private ApplicationContext db;
        public WorkplaceRepository(ApplicationContext context)
        {
            db = context;
        }
        public Task<List<Workplace>> GetAllData()
        {
            return db.Workplaces.ToListAsync();
        }
        public Task<List<Workplace>> GetBookData()
        {
            return db.Workplaces.Where(x => x.IsInUse == false).ToListAsync();
        }
        public Task<Workplace> GetRowByWorkplaceId(int id)
        {
            return this.db.Workplaces.Where(x => x.Id == id).FirstOrDefaultAsync();
        }
        public async Task CreateWorkpalce(string id)
        {
            Workplace workplace = new Workplace { Description = id };
            db.Workplaces.Add(workplace);
            await db.SaveChangesAsync();

        }
        public async Task EditOneWorkplace(Workplace giveWorkplace, string description, bool mouse, bool keyboard, bool systemUnit, bool monitor, bool notebook)
        {
            Workplace workplace = giveWorkplace;
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

            workplace.Description = description;
            workplace.Devices = chosenDevices;

            await db.SaveChangesAsync();
        }
        public async Task DeleteWorkplace(int id)
        {
            WorkplaceRepository hook = new WorkplaceRepository(db);
            Workplace workplace = await hook.GetRowByWorkplaceId(id);
            if (workplace.ReservationId != null)
            {
                var reservation = db.Reservations.Where(x => x.Id == workplace.ReservationId).FirstOrDefault();
                db.Remove(reservation);
            }
            db.Remove(workplace);
            await db.SaveChangesAsync();
        }
        public async Task Edit(int id, string description, bool mouse, bool keyboard, bool systemUnit, bool monitor, bool notebook)
        {
            WorkplaceRepository hook = new WorkplaceRepository(db);
            Workplace workplace = await hook.GetRowByWorkplaceId(id);
            await hook.EditOneWorkplace(workplace, description, mouse, keyboard, systemUnit, monitor, notebook);
        }
    }
}
