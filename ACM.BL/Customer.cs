using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Customer
    {

		public Customer()
		{

		}

		public Customer(int customerId)
		{
			this.CustomerId = customerId;
		}
		public static int InstanceCount { get; set; }

		private string _lastName;

		public string LastName
		{
			get { return _lastName; }
			set { _lastName = value; }
		}
	
		public string FirstName { get; set; }
		public string EmailAddress { get; set; }
		public int CustomerId { get; private set; }

		public string FullName
		{
			get 
			{
				string fullName = LastName;
				if (!string.IsNullOrWhiteSpace(FirstName))
				{
					if(!string.IsNullOrWhiteSpace(fullName))
					{
						fullName += ", ";
					}
					fullName += FirstName;
				}

				return fullName;
			 }
		}

		/// <summary>
		/// Retrieve one customer.
		/// </summary>
		/// <param name="customerId"></param>
		/// <returns></returns>
		public Customer Retrieve(int customerId)
		{
			return new Customer();
		}

		/// <summary>
		/// Retrieve
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

		/// <summary>
		/// Validate the customer
		/// </summary>
		/// <returns></returns>
		public bool Validate()
		{
			var isValid = true;

			if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
			if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

			return isValid;
		}

	}
}
