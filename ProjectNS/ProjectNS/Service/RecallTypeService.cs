using ProjectNS.Interface;
using ProjectNS.Model;
using ProjectNS.ViewModel;
using System.Collections.Generic;
using System.Linq;

namespace ProjectNS.Service
{
    public class RecallTypeService
    {
        IRecallType _recalltypeservice;
        public RecallTypeService(IRecallType recalltypeservice)
        {
            _recalltypeservice = recalltypeservice;
        }

        public List<RecallTypeVM> GetRecallTypes()
        {
            return _recalltypeservice.GetRecallTypes().ToList();
        }

        public RecallType GetRecallTypeById(int RecallTypeId)
        {
            return _recalltypeservice.GetRecallTypeById(RecallTypeId);
        }

        public RecallType AddRecallType(RecallTypeVM recallTypeVM)
        {
            RecallType recallType = new RecallType()
            {
                RecallTypeId = recallTypeVM.RecallTypeId,
                RecallTypeName = recallTypeVM.RecallTypeName,
                Description = recallTypeVM.Description,
            };
            var addrecalltype =_recalltypeservice.AddRecallType(recallType);
            return addrecalltype;
        }

        public RecallType UpdateRecallType(RecallTypeVM recallTypeVM)
        {
            RecallType recallType = new RecallType()
            {
                RecallTypeId = recallTypeVM.RecallTypeId,
                RecallTypeName = recallTypeVM.RecallTypeName,
                Description = recallTypeVM.Description
            };
            var updaterecalltype =_recalltypeservice.UpdateRecallType(recallType);
            return updaterecalltype;
        }

        public void DeleteRecallType(int RecallTypeId)
        {
            _recalltypeservice.DeleteRecallType(RecallTypeId);
        }
    }
}
