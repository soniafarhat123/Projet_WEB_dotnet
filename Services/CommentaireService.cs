using PS.Data.Infrastructure;
using ServicePattern;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class CommentaireService : Service<Commentaire>, ICommentaireService
    {
        IUnitOfWork utk;
        public CommentaireService(IUnitOfWork utwk) : base(utwk)
        {
            utk = utwk;
        }
    }
}
