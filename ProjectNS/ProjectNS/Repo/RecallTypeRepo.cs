using ProjectNS.Data;
using ProjectNS.Interface;
using ProjectNS.Model;
using ProjectNS.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectNS.Repo
{
    public class RecallTypeRepo : IRecallType
    {
        private readonly NSDbContext _context;
        public RecallTypeRepo(NSDbContext context)
        {
            _context = context;
        }

        public List<RecallTypeVM> RecallTypes()
        {
            return (from a in _context.RecallType
                          select new RecallTypeVM
                          {
                              RecallTypeId = a.RecallTypeId,
                              RecallTypeName = a.RecallTypeName,
                              Description = a.Description
                          }).ToList();
        }

        public RecallType RecallTypeById(int RecallTypeId)
        {
            return _context.RecallType.FirstOrDefault(a => a.RecallTypeId == RecallTypeId);
        }

        public RecallType AddRecallType(RecallType recallType)
        {
            _context.Add(recallType);
            _context.SaveChanges();
            return recallType;
        }

        public RecallType UpdateRecallType(RecallType recallType)
        {
            _context.Update(recallType);
            _context.SaveChanges();
            return recallType;
        }

        public void DeleteRecallType(int RecallTypeId)
        {
            var delrecalltype = _context.RecallType.Where(s => s.RecallTypeId == RecallTypeId).FirstOrDefault();
            if (delrecalltype != null)
            {
                _context.Remove(delrecalltype);
                _context.SaveChanges();
            }
        }
    }
}
