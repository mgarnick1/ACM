using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
	public class CustomerRepository
	{
		/// <summary>
		/// Retrieve one customer.
		/// </summary>
		/// <param name="customerId"></param>
		/// <returns></returns>
		public Customer Retrieve(int customerId)
		{
			Customer customer = new Customer(customerId);
			
			if (customerId == 1)
			{
				customer.EmailAddress = "fbaggins@hobbiton.me";
				customer.FirstName = "Frodo";
				customer.LastName = "Baggins";
			}
			return customer;
		}

		/// <summary>
		/// Retrieve all customers
		/// </summary>
		/// <returns></returns>
		public List<Customer> Retrieve()
		{
			return new List<Customer>();
		}

		/// <summary>
		/// Save the current customer.
		/// </summary>
		/// <returns></returns>
		public bool Save()
		{
			return true;
		}
	}
}
