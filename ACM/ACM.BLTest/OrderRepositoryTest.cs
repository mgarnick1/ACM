﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ACM.BLTest
{
	[TestClass]
	public class OrderRepositoryTest
	{
		[TestMethod]
		public void RetrieveOrderDisplayTest()
		{
			var orderRepository = new OrderRepository();
			var expected = new OrderDisplay()
			{
				FirstName = "Bilbo",
				LastName = "Baggins",
				OrderDate = new DateTimeOffset(2014, 04, 14, 10, 00, 00, new TimeSpan(7, 0, 0)),
				ShippingAddress = new Address()
				{
					AddressType = 1,
					StreetLine1 = "Bag End",
					StreetLine2 = "Bagshot row",
					City = "Hobbiton",
					State = "Shire",
					Country = "Middle Earth",
					PostalCode = "144",
				},
				OrderDisplayItemList = new List<OrderDisplayItem>()
				{
					new OrderDisplayItem()
					{
						OrderQuantity = 2,
						ProductName = "Sun Flowers",
						PurchasePrice = 15.96M
					},
					new OrderDisplayItem()
					{
						OrderQuantity = 1,
						ProductName = "Rake",
						PurchasePrice = 6M
					}
				}
			};
			var actual = orderRepository.RetrieveOrderDisplay(10);

			Assert.AreEqual(expected.FirstName, actual.FirstName);
			Assert.AreEqual(expected.LastName, actual.LastName);
			Assert.AreEqual(expected.OrderDate, actual.OrderDate);

			Assert.AreEqual(expected.ShippingAddress.AddressType, actual.ShippingAddress.AddressType);
			Assert.AreEqual(expected.ShippingAddress.StreetLine1, actual.ShippingAddress.StreetLine1);
			Assert.AreEqual(expected.ShippingAddress.City, actual.ShippingAddress.City);
			Assert.AreEqual(expected.ShippingAddress.State, actual.ShippingAddress.State);
			Assert.AreEqual(expected.ShippingAddress.Country, actual.ShippingAddress.Country);
			Assert.AreEqual(expected.ShippingAddress.PostalCode, actual.ShippingAddress.PostalCode);

			for (int i = 0; i < 1; i++)
			{
				Assert.AreEqual(expected.OrderDisplayItemList[i].OrderQuantity, actual.OrderDisplayItemList[i].OrderQuantity);
				Assert.AreEqual(expected.OrderDisplayItemList[i].ProductName, actual.OrderDisplayItemList[i].ProductName);
				Assert.AreEqual(expected.OrderDisplayItemList[i].PurchasePrice, actual.OrderDisplayItemList[i].PurchasePrice);
			}
		}
	}
}
