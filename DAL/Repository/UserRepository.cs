﻿using DAL.EF;
using DAL.Entities;
using DAL.Repository.Interfaces;
using InternetShcool.DAL.Repository.Base;

namespace DAL.Repository;

public class UserRepository : Repo<User, Guid>, IUserRepository
{
    public UserRepository(ApplicationDbContext context)
        : base(context)
    {

    }
}
