using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Acme.Common;
using ACM.BL;

namespace ACM.BLTest
{
	/// <summary>
	/// Summary description for UnitTest1
	/// </summary>
	[TestClass]
	public class LoggingServiceTest
	{
		public LoggingServiceTest()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		[TestMethod]
		public void WriteToFileTest()
		{
			var changedItems = new List<ILoggable>();

			var customer = new Customer(1)
			{
				EmailAddress = "fbaggins@hobbiton.me",
				FirstName = "Frodo",
				LastName = "Baggins",
				AddressList = null
			};

			changedItems.Add(customer as ILoggable);

			var product = new Product(2)
			{
				ProductName = "Rake",
				ProductDescription = "Garden Rake with Steel Head",
				CurrentPrice = 6M
			};
			changedItems.Add(product as ILoggable);

			LoggingService.WriteToFile(changedItems);
			
		}
	}
}
