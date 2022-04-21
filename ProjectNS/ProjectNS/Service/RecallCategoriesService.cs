using ProjectNS.Interface;
using ProjectNS.Model;
using ProjectNS.ViewModel;
using System.Collections.Generic;
using System.Linq;

namespace ProjectNS.Service
{
    public class RecallCategoriesService
    {
        IRecallCategories _recallcategoriesservice;
        public RecallCategoriesService(IRecallCategories recallcategoriesservice)
        {
            _recallcategoriesservice = recallcategoriesservice;
        }

        public List<RecallCategoriesVM> GetRecallCategories()
        {
            return _recallcategoriesservice.GetRecallCategories().ToList();
        }

        public RecallCategories GetRecallCategoriesById(int RecallCategoriesId)
        {
            return _recallcategoriesservice.GetRecallCategoriesById(RecallCategoriesId);
        }

        public RecallCategories AddRecallCategories(RecallCategoriesVM recallCategoriesVM)
        {
            RecallCategories recallCategories = new RecallCategories()
            {
                RecallCategoriesId = recallCategoriesVM.RecallCategoriesId,
                RecallCategoriesName = recallCategoriesVM.RecallCategoriesName,
                Description = recallCategoriesVM.Description,
                /*RecallInfoId = recallCategoriesVM.RecallInfoId  
*/            };
            var addrecallcategories = _recallcategoriesservice.AddRecallCategories(recallCategories);
            return addrecallcategories;
        }

        public RecallCategories UpdateRecallCategories(RecallCategoriesVM recallCategoriesVM)
        {
            RecallCategories recallCategories = new RecallCategories()
            {
                RecallCategoriesId = recallCategoriesVM.RecallCategoriesId,
                RecallCategoriesName = recallCategoriesVM.RecallCategoriesName,
                Description = recallCategoriesVM.Description
            };
            var updaterecallcategories = _recallcategoriesservice.UpdateRecallCategories(recallCategories);
            return updaterecallcategories;
        }

        public void DeleteRecallCategories(int RecallCategoriesId)
        {
            _recallcategoriesservice.DeleteRecallCategories(RecallCategoriesId);
        }
    }
}
