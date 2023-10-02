﻿using Project.Models;

namespace Project.Business.Abstract
{
    public interface IUserService
    {
        void Add(User user);
        void Update(User user);

        User GetById(Guid id);

        User GetByMail(string mail);

        User GetByRefreshToken(string refreshToken);
    }
}