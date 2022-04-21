using ProjectNS.Model;
using ProjectNS.ViewModel;
using System.Collections.Generic;

namespace ProjectNS.Interface
{
    public interface IRecallType
    {
        public List<RecallTypeVM> GetRecallTypes();
        public RecallType GetRecallTypeById(int RecallTypeId);
        public RecallType AddRecallType(RecallType recallType);
        public RecallType UpdateRecallType(RecallType recallType);
        public void DeleteRecallType(int RecallTypeId);
    }
}
