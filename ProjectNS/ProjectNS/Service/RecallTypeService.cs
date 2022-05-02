using ProjectNS.Interface;
using ProjectNS.InterfaceService;
using ProjectNS.Model;
using ProjectNS.ViewModel;
using System.Collections.Generic;
using System.Linq;

namespace ProjectNS.Service
{
    public class RecallTypeService: IRecallTypeService
    {
        private readonly IRecallType _recalltypeservice;
        public RecallTypeService(IRecallType recalltypeservice)
        {
            _recalltypeservice = recalltypeservice;
        }

        public List<RecallTypeVM> RecallTypes()
        {
            return _recalltypeservice.RecallTypes().ToList();
        }

        public RecallType RecallTypeById(int RecallTypeId)
        {
            return _recalltypeservice.RecallTypeById(RecallTypeId);
        }

        public RecallType AddRecallType(RecallTypeVM recallTypeVM)
        {
            RecallType recallType = new RecallType()
            {
                RecallTypeId = recallTypeVM.RecallTypeId,
                RecallTypeName = recallTypeVM.RecallTypeName,
                Description = recallTypeVM.Description,
            };
            return _recalltypeservice.AddRecallType(recallType);
        }

        public RecallType UpdateRecallType(RecallTypeVM recallTypeVM)
        {
            RecallType recallType = new RecallType()
            {
                RecallTypeId = recallTypeVM.RecallTypeId,
                RecallTypeName = recallTypeVM.RecallTypeName,
                Description = recallTypeVM.Description
            };
            return _recalltypeservice.UpdateRecallType(recallType);
        }

        public void DeleteRecallType(int RecallTypeId)
        {
            _recalltypeservice.DeleteRecallType(RecallTypeId);
        }
    }
}
