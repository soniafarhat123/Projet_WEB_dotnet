using PS.Data.Infrastructure;
using ServicePattern;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class JeuxService : Service<Jeux> , IJeuxService
    {
        IUnitOfWork utk;
        public JeuxService(IUnitOfWork utwk) : base(utwk)
        {
            utk = utwk;
        }
    }
}
