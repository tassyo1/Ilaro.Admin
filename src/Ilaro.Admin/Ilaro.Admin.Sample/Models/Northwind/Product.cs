﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Ilaro.Admin.DataAnnotations;
using Ilaro.Admin.Core;

namespace Ilaro.Admin.Sample.Models.Northwind
{
	public class Product
	{
		public int ProductID { get; set; }

		[Required, MaxLength(40)]
		public string ProductName { get; set; }

		[ForeignKey("Supplier")]
		public int SupplierID { get; set; }

		[ForeignKey("CategoryID")]
		public Category Category { get; set; }

		[MaxLength(20)]
		public string QuantityPerUnit { get; set; }

		public decimal UnitPrice { get; set; }

		public short? UnitsInStock { get; set; }

		public short? UnitsOnOrder { get; set; }

		public short? ReorderLevel { get; set; }

		[Required]
		public bool Discontinued { get; set; }

		[OnDelete(DeleteOption.AskUser)]
		public ICollection<OrderDetail> OrderDetails { get; set; }

		public override string ToString()
		{
			return ProductName;
		}
	}
}