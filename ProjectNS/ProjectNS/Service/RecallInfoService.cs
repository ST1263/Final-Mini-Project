using Microsoft.AspNetCore.Hosting;
using ProjectNS.Interface;
using ProjectNS.InterfaceService;
using ProjectNS.Model;
using ProjectNS.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProjectNS.Service
{
    public class RecallInfoService:IRecallInfoService
    {
        private readonly IRecallInfo _recallinfoservice;
        public RecallInfoService(IRecallInfo recallinfoservice)
        {
            _recallinfoservice = recallinfoservice;
        }

        public List<RecallInfoVM> RecallInfos()
        {
            return _recallinfoservice.RecallInfos().ToList();
        }

        public RecallInfo RecallInfoById(int RecallinfoId)
        {
            return _recallinfoservice.RecallInfoById(RecallinfoId);
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
                SupplierVoluntaryRegulatoryMandate = recallInfoVM.SupplierVoluntaryRegulatoryMandate,
                SupportingMaterial = recallInfoVM.SupportingMaterial,
                Description = recallInfoVM.Description,
            };
            return _recallinfoservice.AddRecallInfo(recallInfo);
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
                SupplierVoluntaryRegulatoryMandate = recallInfoVM.SupplierVoluntaryRegulatoryMandate,
                SupportingMaterial = recallInfoVM.SupportingMaterial,
                Description = recallInfoVM.Description,
            };
            return _recallinfoservice.UpdateRecallInfo(recallInfo);
        }

        public void DeleteRecallInfo(int RecallinfoId)
        {
            _recallinfoservice.DeleteRecallInfo(RecallinfoId);
        }
    }
}
