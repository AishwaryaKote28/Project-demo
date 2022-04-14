using InstituteManagementSystem.Infra;
using InstituteManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstituteManagementSystem.Service
{
    public class FeesDetailsService
    {
        IFeesDetails _service;
        public FeesDetailsService(IFeesDetails service)
        {
            _service = service;
        }
        public List<FeesDetails> GetAllRecords()
        {
            return _service.GetAllRecords().ToList();
            //List<Supplier> supplier = _sservice.GetSupplier();
            // return supplier.ToList();
        }
        public FeesDetails GetRecieptByID(int RecieptId)
        {
            return _service.GetRecieptByID(RecieptId);
        }
        public void AddFees(FeesDetails FeesDetails)
        {
            _service.AddFees(FeesDetails);
        }
        public void UpdateFees(FeesDetails FeesDetails)
        {
            _service.UpdateFees(FeesDetails);
        }       
    }
}
