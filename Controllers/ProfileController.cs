using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Profile.Model;
using Profile.Services;

namespace Profile.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ProfileController : ControllerBase
	{
		ProfileServices _service;


		public ProfileController(ProfileServices service)
		{
			_service = service;

		}

		[EnableCors("MyPolicy")]
		[HttpGet("person/", Name = "GetAll")]
		public IEnumerable<Personal> GetAll()
		{
			var personal = _service.GetAll();

			return personal;
		}

		[EnableCors("MyPolicy")]
		[HttpGet("person/{Id}", Name = "GetPerson")]
		public ActionResult<Personal> GetPersonById(int Id)
		{
			var personal = _service.GetPersonal(Id);

			if (personal == null)
			{
				return NotFound();
			}

			return personal;
		}

		[EnableCors("MyPolicy")]
		[HttpGet("about/{Id}", Name = "GetAbout")]
		public IEnumerable<About> GetAbout(int Id)
		{
			var about = _service.GetAbout(Id);

			/*			if (about == null)
						{
							return NotFound();
						}*/

			return about;
		}

		[EnableCors("MyPolicy")]
		[HttpGet("education/{Id}", Name = "GetEducation")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public IEnumerable<Education> GetEduById(int Id)
		{
			var education = _service.GetEducation(Id);

			/*			if (!education.Any())
						{
							return (IEnumerable<Education>)NotFound();
						}*/
			return education;
		}

		[EnableCors("MyPolicy")]
		[HttpGet("experience/{Id}", Name = "GetExperience")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public IEnumerable<Experience> GetExpById(int Id)
		{
			IEnumerable<Experience> experience = _service.GetExperience(Id);


			return experience;
		}

		[EnableCors("MyPolicy")]
		[HttpGet("projects/{Id}", Name = "GetProjects")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public IEnumerable<Projects> GetProById(int Id)
		{
			var projects = _service.GetProjects(Id);

			return projects;
		}

		[EnableCors("MyPolicy")]
		[HttpGet("skills/{Id}", Name = "GetSkills")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		public IEnumerable<Skills> GetSkillsById(int Id)
		{
			var skills = _service.GetSkills(Id);

			return skills;
		}

		[EnableCors("MyPolicy")]
		[HttpGet("contacts/{Id}", Name = "GetContacts")]
		public IEnumerable<Contact> GetContactsById(int Id)
		{
			var contact = _service.GetContact(Id);

			return contact;
		}

		[EnableCors("MyPolicy")]
		[HttpDelete("person/{Id}")]
		public IActionResult DeletePerson(int Id)
		{
			var person = _service.GetPersonal(Id);

			if (person != null)
			{
				_service.DeletePerson(Id);
				return Ok();
			}
			return NotFound();
		}

		[EnableCors("MyPolicy")]
		[HttpDelete("education/{Id}")]
		public IActionResult DeleteEducation(int Id)
		{
			var education = _service.GetEducation(Id);

			if (education != null)
			{
				_service.DeleteEducation(Id);
				return Ok();
			}
			return NotFound();
		}


		[HttpDelete("experience/{Id}")]
		public IActionResult DeleteExperience(int Id)
		{
			var experience = _service.GetExperience(Id);

			if (experience != null)
			{
				_service.DeleteExperience(Id);
				return Ok();
			}
			return NotFound();
		}

		[HttpDelete("projects/{Id}")]
		public IActionResult DeleteProjects(int Id)
		{
			var projects = _service.GetProjects(Id);

			if (projects != null)
			{
				_service.DeleteProjects(Id);
				return Ok();
			}
			return NotFound();
		}

		[HttpDelete("skills/{Id}")]
		public IActionResult DeleteSkills(int Id)
		{
			var skills = _service.GetSkills(Id);

			if (skills != null)
			{
				_service.DeleteSkills(Id);
				return Ok();
			}
			return NotFound();
		}


		[HttpDelete("contact/{Id}")]
		public IActionResult DeleteContact(int Id)
		{
			var contact = _service.GetContact(Id);

			if (contact != null)
			{
				_service.DeleteContact(Id);
				return Ok();
			}
			return NotFound();
		}

	}
}
