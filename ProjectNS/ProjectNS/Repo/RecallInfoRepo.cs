using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using ProjectNS.Data;
using ProjectNS.Interface;
using ProjectNS.Model;
using ProjectNS.ViewModel;
using System.Collections.Generic;
using System.Linq;

namespace ProjectNS.Repo
{
    public class RecallInfoRepo:IRecallInfo
    {
        private readonly NSDbContext  _context;
        
        public RecallInfoRepo(NSDbContext context)
        {
            _context = context;    
        }

        public List<RecallInfoVM> RecallInfos()
        {
            return (from a in _context.RecallInfo
                          select new RecallInfoVM
                          {
                              RecallInfoId = a.RecallInfoId,
                              RecallId = a.RecallId,
                              RecallName = a.RecallName,
                              RecallType = a.RecallType,
                              RecallDate = a.RecallDate,
                              ZNumber = a.ZNumber,
                              FDAClassification = a.FDAClassification,
                              RecallCategories = a.RecallCategories,
                              RecallStatus = a.RecallStatus,
                              MarkAsUrgent = a.MarkAsUrgent,
                              CustomizeedContent = a.CustomizeedContent,
                              SupplierVoluntaryRegulatoryMandate = a.SupplierVoluntaryRegulatoryMandate,
                              SupportingMaterial = a.SupportingMaterial,
                              Description = a.Description,
                          }).ToList();
        }   

        public RecallInfo RecallInfoById(int RecallinfoId)
        {
            return _context.RecallInfo.FirstOrDefault(a => a.RecallInfoId == RecallinfoId);
        }

        public RecallInfo AddRecallInfo(RecallInfo recallInfo)
        {
            _context.Add(recallInfo);
            _context.SaveChanges();
            return recallInfo;
        }

        public RecallInfo UpdateRecallInfo(RecallInfo recallInfo)
        {
            _context.Update(recallInfo);
            _context.SaveChanges();
            return recallInfo;
        }

        public void DeleteRecallInfo(int RecallinfoId)
        {
            var delrecallinfo = _context.RecallInfo.Where(s => s.RecallInfoId == RecallinfoId).FirstOrDefault();
            if (delrecallinfo != null)
            {
                _context.Remove(delrecallinfo);
                _context.SaveChanges();
            }
        }
    }
}
