using System;
using ResourceMetadata.Data;

namespace Data.Infrastructure  
{
    public interface IDatabaseFactory : IDisposable
    {
        ComplainManagerEntities Get();
    }
}
