namespace CloudCustomers.API.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CloudCustomers.API.Models;

public class UsersService : IUsersService
{
    public UsersService()
    {
        
    }

    public Task<List<User>> GetAllUsers()
    {
        throw new NotImplementedException();
    }
}