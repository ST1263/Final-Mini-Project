using ProjectNS.Model;
using ProjectNS.ViewModel;
using System.Collections.Generic;


namespace ProjectNS.InterfaceService
{
    interface IRecallCategoriesService
    {
        public List<RecallCategoriesVM> RecallCategories();
        public RecallCategories RecallCategoriesById(int RecallCategoriesId);
        public RecallCategories AddRecallCategories(RecallCategoriesVM recallCategoriesVM);
        public RecallCategories UpdateRecallCategories(RecallCategoriesVM recallCategoriesVM);
        public void DeleteRecallCategories(int RecallCategoriesId);
    }
}
