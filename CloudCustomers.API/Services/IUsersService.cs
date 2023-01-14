namespace CloudCustomers.API.Services;

using System;
using CloudCustomers.API.Models;

public interface IUsersService
{
    public Task<List<User>> GetAllUsers();
}