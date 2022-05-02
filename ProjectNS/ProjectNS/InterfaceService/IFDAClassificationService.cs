using ProjectNS.Model;
using ProjectNS.ViewModel;
using System.Collections.Generic;

namespace ProjectNS.InterfaceService
{
    interface IFDAClassificationService
    {
        public List<FDAClassificationVM> FDAClassifications();
        public FDAClassification FDAClassificationById(int FDAClassificationId);
        public FDAClassification AddFDAClassification(FDAClassificationVM fDAClassificationVM);
        public FDAClassification UpdateFDAClassification(FDAClassificationVM fDAClassificationVM);
        public void DeleteFDAClassification(int FDAClassificationId);
    }
}
