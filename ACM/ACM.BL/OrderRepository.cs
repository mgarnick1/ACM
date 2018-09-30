﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
	public class OrderRepository
	{
		/// <summary>
		/// Retrieve one customer.
		/// </summary>
		/// <param name="customerId"></param>
		/// <returns></returns>
		public Order Retrieve(int orderId)
		{
			Order order = new Order(orderId);

			
			return order;
		}


		public OrderDisplay RetrieveOrderDisplay(int orderId)
		{
			OrderDisplay orderDisplay = new OrderDisplay();

			var addressRepository = new AddressRepository();

			if( orderId == 10)
			{
				orderDisplay.FirstName = "Bilbo";
				orderDisplay.LastName = "Baggins";
				orderDisplay.OrderDate = new DateTimeOffset(2014, 04, 14, 10, 00, 00, new TimeSpan(7, 0, 0));
				orderDisplay.ShippingAddress = addressRepository.Retrieve(1);
			}

			orderDisplay.OrderDisplayItemList = new List<OrderDisplayItem>();
			
			if (orderId == 10)
			{
				var orderDisplayItem = new OrderDisplayItem()
				{
					ProductName = "Sun Flowers",
					PurchasePrice = 15.96M,
					OrderQuantity = 2
				};
				orderDisplay.OrderDisplayItemList.Add(orderDisplayItem);
				orderDisplayItem = new OrderDisplayItem()
				{
					ProductName = "Rake",
					PurchasePrice = 6M,
					OrderQuantity = 1
				};
				orderDisplay.OrderDisplayItemList.Add(orderDisplayItem);
			}
			return orderDisplay;
		}


		/// <summary>
		/// Save the current order.
		/// </summary>
		/// <returns></returns>
		public bool Save()
		{
			return true;
		}
	}
}
