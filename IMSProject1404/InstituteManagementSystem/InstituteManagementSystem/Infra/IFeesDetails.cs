using InstituteManagementSystem.Model;
using System.Collections.Generic;

namespace InstituteManagementSystem.Infra
{
    public interface IFeesDetails
    {
        public List<FeesDetails> GetAllRecords();
        public FeesDetails GetRecieptByID(int RecieptId);
        public void AddFees(FeesDetails FeesDetails);
        public void UpdateFees(FeesDetails FeesDetails);
       // public void DeleteStudent(int Student);
    }
}
