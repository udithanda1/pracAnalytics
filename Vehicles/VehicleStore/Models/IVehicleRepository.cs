using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleStore.Models
{
    interface IVehicleRepository
    {
        IEnumerable<VehicleInfo> GetAll();
        IEnumerable<VehicleInfo> GetVehiclesByYear(int year);
        IEnumerable<VehicleInfo> GetVehiclesByMake(string make);
        VehicleInfo Get(Guid Id);
        void Remove(Guid Id);
        bool Update(VehicleInfo item);
        VehicleInfo Add(VehicleInfo item);
    }
}
