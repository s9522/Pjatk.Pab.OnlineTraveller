using System;

namespace Pjatk.Pab.OnlineTraveller.Core.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        int Commit();
    }
}