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
	public class ModelsController : ControllerBase
	{
		private readonly IUnitOfWork _unitOfWork;

		public ModelsController(IUnitOfWork unitOfWork)
		{
			_unitOfWork = unitOfWork;
		}

		// GET: api/Models
		[HttpGet]
		public async Task<IActionResult> GetModels()
		{
			var makes = await _unitOfWork.Models.GetAll();
			return Ok(makes);

		}

		// GET: api/Models/5
		[HttpGet("{id}")]
		public async Task<IActionResult> GetModel(int id)
		{
			var make = await _unitOfWork.Models.Get(q => q.Id == id);

			if (make == null)
			{
				return NotFound();
			}

			return Ok(make);
		}

		// PUT: api/Models/5
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPut("{id}")]
		public async Task<IActionResult> PutModel(int id, Model make)
		{
			if (id != make.Id)
			{
				return BadRequest();
			}

			_unitOfWork.Models.Update(make);
			try
			{
				await _unitOfWork.Save(HttpContext);
			}
			catch (DbUpdateConcurrencyException)
			{
				if (!await ModelExists(id))
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

		// POST: api/Models
		// To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
		[HttpPost]
		public async Task<ActionResult<Model>> PostModel(Model make)
		{
			await _unitOfWork.Models.Insert(make);
			await _unitOfWork.Save(HttpContext);

			return CreatedAtAction("GetModel", new { id = make.Id }, make);
		}

		// DELETE: api/Models/5
		[HttpDelete("{id}")]
		public async Task<IActionResult> DeleteModel(int id)
		{

			var make = await _unitOfWork.Models.Get(q => q.Id == id);
			if (make == null)
			{
				return NotFound();
			}

			await _unitOfWork.Models.Delete(id);
			await _unitOfWork.Save(HttpContext);

			return NoContent();
		}

		private async Task<bool> ModelExists(int id)
		{
			var make = await _unitOfWork.Models.Get(q => q.Id == id);
			return make == null;
		}
	}
}
