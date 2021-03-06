﻿using Microsoft.ServiceFabric.Services.Remoting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace StateAggregator.Interfaces
{
    [ServiceContract]
    public interface IStateAggregator: IService
    {
        [OperationContract]
        Task ReportProgress(string name, int percent, string message, string user);
        [OperationContract]
        Task ReportCompletion(string name, string url, string user);
        [OperationContract]
        Task<List<JobStatus>> ListJobs();
        [OperationContract]
        Task ReportCancellation(string url);
    }
}
