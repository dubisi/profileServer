using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Profile.Model;
using Profile.Services;

namespace Profile.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AddProfileController : ControllerBase
	{
		readonly ProfileCreate _create;


		public AddProfileController(ProfileCreate create)
		{
			_create = create;
		}

		/// <summary>
		/// Add person to the database.
		/// </summary>
		/// <returns>The requested body</returns>
		[HttpPost("person")]
		[Produces("application/json")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult CreateMe(Personal personal)
		{
			var me = _create.CreateMe(personal);
			return CreatedAtRoute("GetPerson", new { Id = me!.Id }, me);
		}

		[HttpPost("about")]
		[Produces("application/json")]
		[ProducesResponseType(StatusCodes.Status200OK)]
		[ProducesResponseType(StatusCodes.Status500InternalServerError)]
		public IActionResult CreateAbout(About about)
		{
			var aboutMe = _create.CreateAbout(about);
			return CreatedAtRoute("GetAbout", new { Id = aboutMe!.Id }, aboutMe);
		}

		[HttpPost("education")]
		public IActionResult CreateEdu(Education educations)
		{
			var education = _create.CreateEducation(educations);
			return CreatedAtRoute("GetEducation", new { Id = education!.Id }, education);
		}

		[HttpPost("experience")]
		public IActionResult CreateExp(Experience experiences)
		{
			var experience = _create.CreateExperince(experiences);
			return CreatedAtRoute("GetExperience", new { Id = experience!.Id }, experience);
		}

		[HttpPost("project")]

		public IActionResult CreateProjects(Projects projects)
		{
			var project = _create.CreateProjects(projects);
			return CreatedAtRoute("GetProjects", new { Id = project.Id }, project);
		}

		[HttpPost("skill")]
		public IActionResult CreateSkills(Skills skills)
		{
			var skill = _create.CreateSkills(skills);
			return CreatedAtRoute("GetSkills", new { Id = skill!.Id }, skill);
		}

		[HttpPost("contact")]
		public IActionResult CreateContacts(Contact contact)

		{
			var contacts = _create.CreateContact(contact);
			return CreatedAtRoute("GetContacts", new { Id = contacts.Id }, contacts);
		}
	}
}
