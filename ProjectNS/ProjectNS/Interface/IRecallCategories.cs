using ProjectNS.Model;
using ProjectNS.ViewModel;
using System.Collections.Generic;

namespace ProjectNS.Interface
{
    public interface IRecallCategories
    {
        public List<RecallCategoriesVM> GetRecallCategories();
        public RecallCategories GetRecallCategoriesById(int RecallCategoriesId);
        public RecallCategories AddRecallCategories(RecallCategories recallCategories);
        public RecallCategories UpdateRecallCategories(RecallCategories recallCategories);
        public void DeleteRecallCategories(int RecallCategoriesId);
    }
}
