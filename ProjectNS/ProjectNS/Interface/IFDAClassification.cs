using ProjectNS.Model;
using ProjectNS.ViewModel;
using System.Collections.Generic;

namespace ProjectNS.Interface
{
    public interface IFDAClassification
    {
        public List<FDAClassificationVM> GetFDAClassifications();
        public FDAClassification GetFDAClassificationById(int FDAClassificationId);
        public FDAClassification AddFDAClassification(FDAClassification fDAClassification);
        public FDAClassification UpdateFDAClassification(FDAClassification fDAClassification);
        public void DeleteFDAClassification(int FDAClassificationId);
    }
}
