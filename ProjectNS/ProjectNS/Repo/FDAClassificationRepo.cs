using ProjectNS.Data;
using ProjectNS.Interface;
using ProjectNS.Model;
using ProjectNS.ViewModel;
using System.Collections.Generic;
using System.Linq;

namespace ProjectNS.Repo
{
    public class FDAClassificationRepo:IFDAClassification
    {
        private readonly NSDbContext _context;
        public FDAClassificationRepo(NSDbContext context)
        {
            _context = context;
        }

        public List<FDAClassificationVM> FDAClassifications()
        {
            return (from a in _context.FDAClassification
                          select new FDAClassificationVM
                          {
                              FDAClassificationId = a.FDAClassificationId,
                              FdaClassificationName = a.FdaClassificationName,
                              Description = a.Description
                          }).ToList();
        }

        public FDAClassification FDAClassificationById(int FDAClassificationId)
        {
            return _context.FDAClassification.FirstOrDefault(a => a.FDAClassificationId == FDAClassificationId);
        }

        public FDAClassification AddFDAClassification(FDAClassification fDAClassification)
        {
            _context.Add(fDAClassification);
            _context.SaveChanges();
            return fDAClassification;
        }

        public FDAClassification UpdateFDAClassification(FDAClassification fDAClassification)
        {
            _context.Update(fDAClassification);
            _context.SaveChanges();
            return fDAClassification;
        }

        public void DeleteFDAClassification(int FDAClassificationId)
        {
            var delfdaclassification = _context.FDAClassification.Where(s => s.FDAClassificationId == FDAClassificationId).FirstOrDefault();
            if (delfdaclassification != null)
            {
                _context.Remove(delfdaclassification);
                _context.SaveChanges();
            }
        }
    }
}
