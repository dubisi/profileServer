using Microsoft.EntityFrameworkCore;
using Profile.Data;
using Profile.Model;


namespace Profile.Services
{
	public class ProfileServices
	{
		private readonly ProfileContext _context;

		public ProfileServices(ProfileContext context)
		{
			_context = context;
		}

		public IEnumerable<Personal> GetAll()
		{
			return _context.Personal.AsNoTracking().ToList();
		}

		public About? GetAbout(int Id)
		{
			return _context.About!.Find(Id);
		}

		public Personal? GetPersonal(int Id)
		{
			return _context.Personal!.Find(Id);
		}

		public IEnumerable<Education> GetEducation(int Id)
		{
			return _context.Education.Where(x => x.Personal!.Id == Id).ToList();
		}

		public IEnumerable<Experience> GetExperience(int Id)
		{
			return _context.Experiences.Where(x => x.Personal!.Id == Id).ToList();
		}

		public IEnumerable<Projects> GetProjects(int Id) { return _context.Projects.Where(x => x.Personal!.Id == Id).ToList(); }

		public IEnumerable<Skills> GetSkills(int Id) { return _context.Skills.Where(x => x.Personal!.Id == Id).ToList(); }

		public IEnumerable<Contact> GetContact(int Id)
		{
			return _context.Contact.Where(x => x.Personal!.Id == Id).ToList();
		}

		public void DeletePerson(int Id)
		{
			var person = _context.Personal.Find(Id);

			if (person is not null)
			{
				_context.Remove(person);
				_context.SaveChanges();
			}


		}

		public void DeleteEducation(int Id)
		{
			var education = _context.Education.Find(Id);

			if (education is not null)
			{
				_context.Remove(education);
				_context.SaveChanges();
			}
		}

		public void DeleteExperience(int Id)
		{
			var experience = _context.Experiences.Find(Id);

			if (experience is not null)
			{
				_context.Remove(experience);
				_context.SaveChanges();
			}
		}

		public void DeleteProjects(int Id)
		{
			var projects = _context.Projects.Find(Id);

			if (projects is not null)
			{
				_context.Remove(projects);
				_context.SaveChanges();
			}
		}

		public void DeleteSkills(int Id)
		{
			var skills = _context.Skills.Find(Id);

			if (skills is not null)
			{
				_context.Remove(skills);
				_context.SaveChanges();
			}
		}

		public void DeleteContact(int Id)
		{
			var contact = _context.Contact.Find(Id);

			if (contact is not null)
			{
				_context.Remove(contact);
				_context.SaveChanges();
			}
		}
	}
}
