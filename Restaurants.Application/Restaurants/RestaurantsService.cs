using AutoMapper;
using Microsoft.Extensions.Logging;
using Restaurants.Application.Dtos;
using Restaurants.Domain.Entities;
using Restaurants.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurants.Application.Restaurants
{
    public class RestaurantsService(IRestaurantsRepository restaurantsRepository,
                                    ILogger<RestaurantsService> logger,
                                    IMapper mapper) : IRestaurantsService
    {
        public async Task<int> Create(CreateRestaurantDto dto)
        {
            logger.LogInformation("Creating a new restaurant");
            var restaurant = mapper.Map<Restaurant>(dto);
            int id =await restaurantsRepository.Create(restaurant);
            return id;
        }

        public async Task<IEnumerable<RestaurantDto>> GetAllRestaurants()
        {
            logger.LogInformation("Getting all Restaurants");
            var restaurants = await restaurantsRepository.GetAllAsync();

            var restaurantDto = mapper.Map<IEnumerable<RestaurantDto>>(restaurants);
            return restaurantDto;
        }

        public async Task<RestaurantDto?> GetById(int id)
        {
            logger.LogInformation($"Getting Restaurants {id}");
            var restaurant = await restaurantsRepository.GetById(id);
            var restaurantDto = mapper.Map<RestaurantDto?>(restaurant);
            return restaurantDto;
        }
    }
}
