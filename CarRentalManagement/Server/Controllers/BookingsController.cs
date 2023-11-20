using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CarRentalManagement.Server.Data;
using CarRentalManagement.Shared.Domain;
using CarRentalManagement.Server.IRepository;
using System.Reflection.Metadata.Ecma335;

namespace CarRentalManagement.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class BookingsController : ControllerBase
	{
		private readonly IUnitOfWork _unitOfWork;

		public BookingsController(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		// GET: api/Bookings
		[HttpGet]
		public async Task<IActionResult> GetBookings()
		{
			var makes = await _unitOfWork.Bookings.GetAll();
			return Ok(makes);

		}

		// GET: api/Bookings/5
		[HttpGet("{id}")]
		public async Task<IActionResult> GetBooking(int id)
		{
			var make = await _unitOfWork.Bookings.Get(q => q.Id == id);

			if (make == null)
			{
				return NotFound();
			}

			return Ok(make);
		}

		// PUT: api/Bookings/5
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPut("{id}")]
		public async Task<IActionResult> PutBooking(int id, Booking make)
		{
			if (id != make.Id)
			{
				return BadRequest();
			}

			_unitOfWork.Bookings.Update(make);
			try
			{
				await _unitOfWork.Save(HttpContext);
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!await BookingExists(id))
				{
					return NotFound();
				}
				else
				{
					throw;
				}
			}

			return NoContent();
		}

		// POST: api/Bookings
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPost]
		public async Task<ActionResult<Booking>> PostBooking(Booking make)
		{
			await _unitOfWork.Bookings.Insert(make);
			await _unitOfWork.Save(HttpContext);

			return CreatedAtAction("GetBooking", new { id = make.Id }, make);
		}

		// DELETE: api/Bookings/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteBooking(int id)
		{

			var make = await _unitOfWork.Bookings.Get(q => q.Id == id);
			if (make == null)
			{
				return NotFound();
			}

			await _unitOfWork.Bookings.Delete(id);
			await _unitOfWork.Save(HttpContext);

			return NoContent();
		}

		private async Task<bool> BookingExists(int id)
		{
			var make = await _unitOfWork.Bookings.Get(q => q.Id == id);
			return make == null;
		}
	}
}
