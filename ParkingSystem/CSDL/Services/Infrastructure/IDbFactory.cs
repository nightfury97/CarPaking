using CSDL.EF;
using System;

namespace CSDL.Services.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        CarParking_CSDL Init();
    }
}