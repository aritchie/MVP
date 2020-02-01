using System;
using System.Threading;
using System.Threading.Tasks;
using Shiny.Jobs;


namespace MVP.Services
{
    public class DataSyncJob : IJob
    {
        public async Task<bool> Run(JobInfo jobInfo, CancellationToken cancelToken)
        {
            return true;
        }
    }
}
