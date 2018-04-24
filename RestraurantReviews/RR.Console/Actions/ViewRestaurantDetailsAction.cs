﻿using RR.Console.Controllers;

namespace RR.Console.Actions
{
    public class ViewRestaurantDetailsAction : IApplicationAction
    {
        private readonly RestaurantController _restaurantController;
        private readonly IInputOutput _inputOutput;

        public ViewRestaurantDetailsAction(RestaurantController restaurantController, IInputOutput inputOutput)
        {
            _restaurantController = restaurantController;
            _inputOutput = inputOutput;
        }

        public void Execute()
        {
            _restaurantController.AllRestaurants().Render();

            var input = _inputOutput.ReadString();

            _restaurantController.RestaurantDetails(input).Render();
        }
    }
}