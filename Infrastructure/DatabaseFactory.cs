using ResourceMetadata.Data;
using DataModel;

namespace Data.Infrastructure  
{
public class DatabaseFactory : Disposable, IDatabaseFactory
{
    private ComplainManagerEntities dataContext;
    public ComplainManagerEntities Get()
    {
        return dataContext ?? (dataContext = new ComplainManagerEntities());
    }
    protected override void DisposeCore()
    {
        if (dataContext != null)
            dataContext.Dispose();
    }
}
}
