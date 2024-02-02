using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarRentalManagement.Shared.Domain
{
	public class Colour : BaseDomainModel
	{
		[Required]
		[StringLength(100, MinimumLength = 2, ErrorMessage = "First Name does not meet length requiremts")]
		public string? Name { get; set; }
	}
}
