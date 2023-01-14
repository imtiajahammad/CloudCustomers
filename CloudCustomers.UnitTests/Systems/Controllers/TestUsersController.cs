namespace CloudCustomers.UnitTests.Systems.Controllers;


using CloudCustomers.API.Controllers;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Xunit;
using Moq;
using CloudCustomers.API.Services;
using CloudCustomers.API.Models;

public class TestUsersController
    {
        [Fact]
        public async Task Get_OnSuccess_ReturnsStatusCode200()
        {
            //Arrange
            var mockUserService = new Mock<IUsersService>();
            mockUserService.Setup(service => service.GetAllUsers())
                            .ReturnsAsync(new List<User>());
            var sut = new UsersController(mockUserService.Object);
            //Act
            var result =(OkObjectResult) await sut.Get();
            //Assert
            result.StatusCode.Should().Be(200);
        }

        [Fact]
        public async Task Get_OnSuccess_InvokesUsersServiceExactlyOnce()
        {
            //Arrange
            var mockUserService =new Mock<IUsersService>();
            mockUserService.Setup(service => service.GetAllUsers())
            .ReturnsAsync(new List<User>());
            var sut = new UsersController(mockUserService.Object);
            //Act
            //var result = (OkObjectResult) await sut.Get();
            var result = await sut.Get();
            //Asert
            mockUserService.Verify(service => service.GetAllUsers(),Times.Once());            
        }

    }