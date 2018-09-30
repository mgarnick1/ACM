using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
	public class ProductRepository
	{
		/// <summary>
		/// Retrieve one customer.
		/// </summary>
		/// <param name="customerId"></param>
		/// <returns></returns>
		public Product Retrieve(int productId)
		{
			Product product = new Product(productId);
			Object myObject = new object();

			Console.WriteLine("Object: " + myObject.ToString());
			Console.WriteLine("Object: " + product.ToString());

			if (productId == 2)
			{
				product.ProductName = "SunFlowers";
				product.ProductDescription = "Assorted Size Set of 4 Bright Yellow Mini Sunflowers";
				product.CurrentPrice = 15.96M;
			}
			return product;
		}

		/// <summary>
		/// Save the current products.
		/// </summary>
		/// <returns></returns>
		public bool Save(Product product)
		{
			var success = true;
			if (product.HasChanges && product.IsValid)
			{
				if (product.IsNew)
				{

				}

				else
				{

				}
			}
			return success;
		}
	}
}
