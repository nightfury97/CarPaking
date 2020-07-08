using CSDL.EF;

namespace CSDL.Services.Infrastructure
{
    public class DbFactory : IDbFactory
    {
        private CarParking_CSDL dbContext;

        public void Dispose()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }

        public CarParking_CSDL Init()
        {
            return dbContext ?? (dbContext = new CarParking_CSDL());
        }
    }
}