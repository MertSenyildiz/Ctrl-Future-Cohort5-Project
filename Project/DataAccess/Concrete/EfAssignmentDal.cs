﻿using Microsoft.EntityFrameworkCore;
using Project.Core.DataAccess;
using Project.DataAccess.Abstract;
using Project.Models;

namespace Project.DataAccess.Concrete
{
    public class EfAssignmentDal : EntityRepositoryBase<Assignment, ProjectDbContext>, IAssignmentDal
    {
        IDbContextFactory<ProjectDbContext> _dbContextFactory;
        public EfAssignmentDal(IDbContextFactory<ProjectDbContext> dbContextFactory) : base(dbContextFactory)
        { }
    }
}