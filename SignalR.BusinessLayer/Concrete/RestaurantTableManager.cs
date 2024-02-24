﻿using SignalR.BusinessLayer.Abstract;
using SignalR.DataAccessLayer.Abstract;
using SignalR.EntityLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalR.BusinessLayer.Concrete
{
    public class RestaurantTableManager:IRestaurantTableService
    {
        private readonly IRestaurantTableDal _restaurantTableDal;

        public RestaurantTableManager(IRestaurantTableDal restaurantTableDal)
        {
            _restaurantTableDal = restaurantTableDal;
        }

        public void TAdd(RestaurantTable entity)
        {
            _restaurantTableDal.Add(entity);
        }

        public void TDelete(RestaurantTable entity)
        {
            _restaurantTableDal.Delete(entity);
        }

        public RestaurantTable TGetByID(int id)
        {
            return _restaurantTableDal.GetByID(id);
        }

        public List<RestaurantTable> TGetListAll()
        {
            return _restaurantTableDal.GetListAll();
        }

        public int TRestaurantTableCount()
        {
            return _restaurantTableDal.RestaurantTableCount();
        }

        public void TUpdate(RestaurantTable entity)
        {
            _restaurantTableDal.Update(entity);
        }
    }
}
