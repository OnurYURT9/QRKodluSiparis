﻿using SignalRBusinessLayer.Abstract;
using SignalREntityLayer.Entities;
using SignaRDataAccessLayer.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignalRBusinessLayer.Concrete
{
	public class OrderManager : IOrderService
	{
		private readonly IOrderDal _orderDal;

		public OrderManager(IOrderDal orderDal)
		{
			_orderDal = orderDal;
		}

		public void TAdd(Order entity)
		{
			throw new NotImplementedException();
		}

		public void TDelete(Order entity)
		{
			throw new NotImplementedException();
		}

		public Order TGetByID(int id)
		{
			throw new NotImplementedException();
		}

		public List<Order> TGetListAll()
		{
			throw new NotImplementedException();
		}

		public int TTotalOrderCount()
		{
			return _orderDal.TotalOrderCount();
		}

		public void TUpdate(Order entity)
		{
			throw new NotImplementedException();
		}
	}
}