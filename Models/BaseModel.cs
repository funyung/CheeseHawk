using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheeseHawk.Models
{
	public abstract class BaseModel
	{
		[Key]
		public string Id { get; set; }
	}
}
