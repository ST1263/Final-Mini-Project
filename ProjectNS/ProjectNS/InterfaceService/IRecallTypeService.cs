using ProjectNS.Model;
using ProjectNS.ViewModel;
using System.Collections.Generic;

namespace ProjectNS.InterfaceService
{
    interface IRecallTypeService
    {
        public List<RecallTypeVM> RecallTypes();
        public RecallType RecallTypeById(int RecallTypeId);
        public RecallType AddRecallType(RecallTypeVM recallTypeVM);
        public RecallType UpdateRecallType(RecallTypeVM recallTypeVM);
        public void DeleteRecallType(int RecallTypeId);
    }
}
