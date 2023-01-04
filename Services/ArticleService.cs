using Domain;
using PS.Data.Infrastructure;
using ServicePattern;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public class ArticleService : Service<Article>, IArticleService
    {
        IUnitOfWork utk;
        public ArticleService(IUnitOfWork utwk) : base(utwk)
        {
            utk = utwk;
        }
    }
}
