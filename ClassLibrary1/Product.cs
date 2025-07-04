﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
	public class Product : IEntity //category copy paste
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string? Description { get; set; }
		public decimal Price { get; set; }
		public string? Brand { get; set; }
		public int Stock { get; set; }
		public bool IsActive { get; set; }
		public Category? Category { get; set; } //Product ile Category arasında 1 e 1 ilişki kuruldu
		public int CategoryId { get; set; }
		public DateTime CreateDate { get; set; }
	}
}
