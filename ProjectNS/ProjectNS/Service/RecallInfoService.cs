using ProjectNS.Interface;
using ProjectNS.Model;
using ProjectNS.ViewModel;
using System.Collections.Generic;
using System.Linq;

namespace ProjectNS.Service
{
    public class RecallInfoService
    {
        IRecallInfo _recallinfoservice;
        public RecallInfoService(IRecallInfo recallinfoservice)
        {
            _recallinfoservice = recallinfoservice;
        }

        public List<RecallInfoVM> GetRecallInfos()
        {
            return _recallinfoservice.GetRecallInfos().ToList();
        }

        public RecallInfo GetRecallInfoById(int RecallinfoId)
        {
            return _recallinfoservice.GetRecallInfoById(RecallinfoId);
        }

        public RecallInfo AddRecallInfo(RecallInfoVM recallInfoVM)
        {
            RecallInfo recallInfo = new RecallInfo()
            {
                RecallInfoId = recallInfoVM.RecallInfoId,
                RecallId = recallInfoVM.RecallId,
                RecallName = recallInfoVM.RecallName,
                RecallType = recallInfoVM.RecallType,
                RecallDate = recallInfoVM.RecallDate,
                ZNumber = recallInfoVM.ZNumber,
                FDAClassification = recallInfoVM.FDAClassification,
                RecallCategories =recallInfoVM.RecallCategories,
                RecallStatus = recallInfoVM.RecallStatus,
                MarkAsUrgent = recallInfoVM.MarkAsUrgent,
                CustomizeedContent = recallInfoVM.CustomizeedContent,
                SupplierVoluntary = recallInfoVM.SupplierVoluntary,
                RegulatoryMandate = recallInfoVM.RegulatoryMandate,
                SupportingMaterial = recallInfoVM.SupportingMaterial,
                Description = recallInfoVM.Description,
            };
            var addrecallinfo = _recallinfoservice.AddRecallInfo(recallInfo);
            return addrecallinfo;
        }

        public RecallInfo UpdateRecallInfo(RecallInfoVM recallInfoVM)
        {
            RecallInfo recallInfo = new RecallInfo()
            {
                RecallInfoId = recallInfoVM.RecallInfoId,
                RecallId = recallInfoVM.RecallId,
                RecallName = recallInfoVM.RecallName,
                RecallType = recallInfoVM.RecallType,
                RecallDate = recallInfoVM.RecallDate,
                ZNumber = recallInfoVM.ZNumber,
                FDAClassification = recallInfoVM.FDAClassification,
                RecallCategories = recallInfoVM.RecallCategories,
                RecallStatus = recallInfoVM.RecallStatus,
                MarkAsUrgent = recallInfoVM.MarkAsUrgent,
                CustomizeedContent = recallInfoVM.CustomizeedContent,
                SupplierVoluntary = recallInfoVM.SupplierVoluntary,
                RegulatoryMandate = recallInfoVM.RegulatoryMandate,
                SupportingMaterial = recallInfoVM.SupportingMaterial,
                Description = recallInfoVM.Description,
            };
            var updaterecallinfo = _recallinfoservice.UpdateRecallInfo(recallInfo);
            return updaterecallinfo;
        }

        public void DeleteRecallInfo(int RecallinfoId)
        {
            _recallinfoservice.DeleteRecallInfo(RecallinfoId);
        }
    }
}
