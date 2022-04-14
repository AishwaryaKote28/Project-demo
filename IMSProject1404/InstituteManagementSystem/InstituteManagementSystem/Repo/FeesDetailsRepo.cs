using InstituteManagementSystem.Data;
using InstituteManagementSystem.Infra;
using InstituteManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstituteManagementSystem.Repo
{
    public class FeesDetailsRepo : IFeesDetails
    {
        DataBaseContext _context;

        public FeesDetailsRepo(DataBaseContext context)
        {
            _context = context;
        }
        public List<FeesDetails> GetAllRecords()
        {
            return _context.FeesDetails.ToList();
        }
        public FeesDetails GetRecieptByID(int RecieptId)
        {
            return _context.FeesDetails.FirstOrDefault(e => e.RecieptId == RecieptId);
        }
        public void AddFees(FeesDetails FeesDetails)
        {
            _context.Add(FeesDetails);
            _context.SaveChanges();
        }
        public void UpdateFees(FeesDetails FeesDetails)
        {
            _context.Update(FeesDetails);
            _context.SaveChanges();
        }
        //public void DeleteCourse(int CourseId)
        //{
        //    var DeleteCourse = _context.CourseDetails.Where(s => s.CourseId == CourseId).FirstOrDefault();
        //    if (DeleteCourse != null) {
        //        _context.Remove(DeleteCourse);
        //        _context.SaveChanges();
        //    }
        //}
    }
}

