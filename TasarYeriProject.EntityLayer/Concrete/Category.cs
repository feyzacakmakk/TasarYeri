﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TasarYeriProject.EntityLayer.Abstract;

namespace TasarYeriProject.EntityLayer.Concrete
{
	public class Category:IEntity
	{
		[Key]
		public int CategoryId { get; set; }
		public string? CategoryName { get; set; }

		public List<Product>? Products { get; set; }
	}
}
