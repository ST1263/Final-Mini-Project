using Microsoft.AspNetCore.Hosting;
using ProjectNS.Interface;
using ProjectNS.Model;
using ProjectNS.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ProjectNS.Service
{
    public class RecallInfoService
    {
        IRecallInfo _recallinfoservice;
        private readonly IWebHostEnvironment _hostingEnvironment;
        public RecallInfoService(IRecallInfo recallinfoservice, IWebHostEnvironment hostingEnvironment)
        {
            _recallinfoservice = recallinfoservice;
            _hostingEnvironment = hostingEnvironment;
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
