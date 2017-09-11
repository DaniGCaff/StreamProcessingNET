using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace StreamProcessingNET
{
    [ServiceContract]
    public interface IUpdateDashboardService
    {

        [OperationContract(IsOneWay=true)]
        void UpdateDashboardByGraphID(int value);
    }
}
