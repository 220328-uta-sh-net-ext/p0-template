using Xunit;
using Models;

//Make sure you have your projects and namespaces you need here
namespace Tests;

public class ModelsTest
{
    [Fact]
    public void RestaurantShouldCreate()
    {
        //Arrange
        //In this case, the arrange step, was making sure that I had my Models namespace included here.

        //Act: Creating the restaurant object
        Restaurant testRestaurant = new Restaurant();

        //Assert: assert that my testRestaurant actually created and is not null
        Assert.NotNull(testRestaurant);
    }

}