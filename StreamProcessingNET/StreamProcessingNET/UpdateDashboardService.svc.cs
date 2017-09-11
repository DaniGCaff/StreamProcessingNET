using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Messaging;

namespace StreamProcessingNET
{
    public class UpdateDashboardService : IUpdateDashboardService
    {
        private static string QUEUE_ADDRESS = @".\Private$\GraphQueue";
        private static string QUEUE_NAME = @"Graph Queue";

        public void UpdateDashboardByGraphID(int graphId)
        {
            MessageQueue messageQueue = null;
            if (!MessageQueue.Exists(QUEUE_ADDRESS))
            {
                MessageQueue.Create(QUEUE_ADDRESS);
            }

            messageQueue = new MessageQueue(QUEUE_ADDRESS);
            messageQueue.Label = QUEUE_NAME;
            messageQueue.Send(graphId, "Update by graph ID");
        }
    }
}
