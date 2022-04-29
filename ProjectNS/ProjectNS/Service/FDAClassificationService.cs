﻿using ProjectNS.Interface;
using ProjectNS.Model;
using ProjectNS.ViewModel;
using System.Collections.Generic;
using System.Linq;

namespace ProjectNS.Service
{
    public class FDAClassificationService
    {
        IFDAClassification _fdaclassificationservice;
        public FDAClassificationService(IFDAClassification fdaclassificationservice)
        {
            _fdaclassificationservice = fdaclassificationservice;
        }

        public List<FDAClassificationVM> GetFDAClassifications()
        {
            return _fdaclassificationservice.GetFDAClassifications().ToList();
        }

        public FDAClassification GetFDAClassificationById(int FDAClassificationId)
        {
            return _fdaclassificationservice.GetFDAClassificationById(FDAClassificationId);
        }

        public FDAClassification AddFDAClassification(FDAClassificationVM fDAClassificationVM)
        {
            FDAClassification fDAClassification = new FDAClassification()
            {
                FDAClassificationId = fDAClassificationVM.FDAClassificationId,
                FdaClassificationName = fDAClassificationVM.FdaClassificationName,
                Description = fDAClassificationVM.Description,
            };
            return _fdaclassificationservice.AddFDAClassification(fDAClassification);
        }

        public FDAClassification UpdateFDAClassification(FDAClassificationVM fDAClassificationVM)
        {
            FDAClassification fDAClassification = new FDAClassification()
            {
                FDAClassificationId = fDAClassificationVM.FDAClassificationId,
                FdaClassificationName = fDAClassificationVM.FdaClassificationName,
                Description = fDAClassificationVM.Description
            };
            return _fdaclassificationservice.UpdateFDAClassification(fDAClassification);
        }

        public void DeleteFDAClassification(int FDAClassificationId)
        {
            _fdaclassificationservice.DeleteFDAClassification(FDAClassificationId);
        }
    }
}
