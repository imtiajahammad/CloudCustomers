namespace CloudCustomers.UnitTests.Systems.Controllers;


using CloudCustomers.API.Controllers;
using FluentAssertions;
using Microsoft.AspNetCore.Mvc;
using Xunit;


    public class TestUsersController
    {
        [Fact]
        public async Task Get_OnSuccess_ReturnsStatusCode200()
        {
            //Arrange
             var sut = new UsersController();
            //Act
            var result =(OkObjectResult) await sut.Get();
            //Assert
            result.StatusCode.Should().Be(200);
        }

        [Fact]
        public async Task Get_OnSuccess_InvokesUserServices()
        {
            //Arrange
            var sut = new UsersController();
            //Act
            var result = (OkObjectResult) await sut.Get();
            //Asert
            
        }

    }