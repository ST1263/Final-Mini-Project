using ProjectNS.Interface;
using ProjectNS.InterfaceService;
using ProjectNS.Model;
using ProjectNS.ViewModel;
using System.Collections.Generic;
using System.Linq;

namespace ProjectNS.Service
{
    public class RecallCategoriesService:IRecallCategoriesService 
    {
        private readonly IRecallCategories _recallcategoriesservice;
        public RecallCategoriesService(IRecallCategories recallcategoriesservice)
        {
            _recallcategoriesservice = recallcategoriesservice;
        }

        public List<RecallCategoriesVM> RecallCategories()
        {
            return _recallcategoriesservice.RecallCategories().ToList();
        }

        public RecallCategories RecallCategoriesById(int RecallCategoriesId)
        {
            return _recallcategoriesservice.RecallCategoriesById(RecallCategoriesId);
        }

        public RecallCategories AddRecallCategories(RecallCategoriesVM recallCategoriesVM)
        {
            RecallCategories recallCategories = new RecallCategories()
            {
                RecallCategoriesId = recallCategoriesVM.RecallCategoriesId,
                RecallCategoriesName = recallCategoriesVM.RecallCategoriesName,
                Description = recallCategoriesVM.Description,
            };
            return _recallcategoriesservice.AddRecallCategories(recallCategories);
        }

        public RecallCategories UpdateRecallCategories(RecallCategoriesVM recallCategoriesVM)
        {
            RecallCategories recallCategories = new RecallCategories()
            {
                RecallCategoriesId = recallCategoriesVM.RecallCategoriesId,
                RecallCategoriesName = recallCategoriesVM.RecallCategoriesName,
                Description = recallCategoriesVM.Description
            };
            return _recallcategoriesservice.UpdateRecallCategories(recallCategories);
        }

        public void DeleteRecallCategories(int RecallCategoriesId)
        {
            _recallcategoriesservice.DeleteRecallCategories(RecallCategoriesId);
        }
    }
}
