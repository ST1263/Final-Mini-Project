using ProjectNS.Model;
using ProjectNS.ViewModel;
using System.Collections.Generic;

namespace ProjectNS.InterfaceService
{
    interface IRecallInfoService
    {
        public List<RecallInfoVM> RecallInfos();
        public RecallInfo RecallInfoById(int RecallinfoId);
        public RecallInfo AddRecallInfo(RecallInfoVM recallInfoVM);
        public RecallInfo UpdateRecallInfo(RecallInfoVM recallInfoVM);
        public void DeleteRecallInfo(int RecallinfoId);
    }
}
