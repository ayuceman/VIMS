using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bipa.EditModels
{
    public class ApplicationEM
    {
        public int ID { get; set; }
        public AppGenInfo AppGenInfo { get; set; }
        public AppHealthInfo AppHealthInfo { get; set; }
        public AppContactInfo AppContactInfo { get; set; }
        public AppExtraInfo AppExtraInfo { get; set; }
        public AppHistoryInfo AppHistoryInfo { get; set; }
        public AppTrainInfo AppTrainInfo { get; set; }
    }

    //public enum AppContent
    //{
    //    AppGenInfo=1,
    //    AppHealthInfo,
    //    AppContactInfo,
    //    AppExtraInfo,
    //    AppHistoryInfo,
    //    AppTrainInfo
    //}
}