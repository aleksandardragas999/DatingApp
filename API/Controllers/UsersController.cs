using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace API.Controllers
{
	[ApiController]
	[Route("api/[controller]")] //	api/users
	public class UsersController : ControllerBase
	{
		private readonly DataContext _context;

		public UsersController(DataContext context)
		{
			_context = context;
		}


		[HttpGet]
		public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()	// predstavlja kolekciju objekata IEnumerable
		{
			var users = await _context.AppUsers.ToListAsync();

			return users;
		}

		[HttpGet("{id}")] //	/api/users/2

		public async Task<ActionResult<AppUser>> GetUser(int id) 
		{
			return  await _context.AppUsers.FindAsync(id);
		}



    }
}
