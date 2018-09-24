using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
	class OrderRepository
	{
		/// <summary>
		/// Retrieve one customer.
		/// </summary>
		/// <param name="customerId"></param>
		/// <returns></returns>
		public Order Retrieve(int orderId)
		{
			Order order = new Order(orderId);

			if (orderId == 10)
			{
				order.OrderDate = new DateTimeOffset(2014, 04, 14, 10, 00, 00, new TimeSpan(7, 0, 0));

			}
			return order;
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
