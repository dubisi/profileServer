using Profile.Data;
using Profile.Model;

namespace Profile.Services
{
	public class ProfileCreate
	{
		private readonly ProfileContext _context;

		public ProfileCreate(ProfileContext context)
		{
			_context = context;
		}

		public Personal? CreateMe(Personal me)
		{
			_context.Personal.Add(me);
			_context.SaveChanges();


			return me;
		}

		public About? CreateAbout(About about)
		{
			_context.About.Add(about);
			_context.SaveChanges();


			return about;
		}

		public Education? CreateEducation(Education education)
		{
			var incometypes2 = _context.Personal.SingleOrDefault(x => x.Email == education.Personal!.Email);


			Education education2 = new Education { Id = education.Id, Name = education.Name, Title = education.Title, Description = education.Description, StartYear = education.StartYear, EndYear = education.EndYear, Personal = incometypes2 };
			_context.Add(education2);
			_context.SaveChanges(true);

			return education2;
		}

		public Experience? CreateExperince(Experience experience)
		{
			var persornal = _context.Personal.SingleOrDefault(x => x.Email == experience.
			Personal!.Email);

			Experience experience2 = new Experience { Id = experience.Id, Name = experience.Name, Title = experience.Title, Description = experience.Description, StartYear = experience.StartYear, EndYear = experience.EndYear, Personal = persornal };
			_context.Add(experience2);
			_context.SaveChanges();

			return experience2;
		}

		public Projects CreateProjects(Projects projects)
		{
			var personal = _context.Personal.SingleOrDefault(x => x.Email == projects.
			Personal!.Email);

			Projects projects1 = new Projects { Id = projects.Id, Name = projects.Name, Dev = projects.Dev, Languages = projects.Languages, Description = projects.Description, Link = projects.Link, ExternalLink = projects.ExternalLink, Personal = personal };

			_context.Add(projects1);
			_context.SaveChanges();
			return projects1;
		}

		public Skills CreateSkills(Skills skills)
		{
			var personal = _context.Personal.SingleOrDefault(x => x.Email == skills.Personal!.Email);

			Skills skills1 = new Skills { Id = skills.Id, Name = skills.Name, SkillSet = skills.SkillSet, Personal = personal };

			_context.Add(skills1);
			_context.SaveChanges();

			return skills1;
		}

		public Contact CreateContact(Contact contact)
		{
			var person = _context.Personal.SingleOrDefault(x => x.Email == contact.Personal!.Email);

			Contact contact1 = new Contact { Id = contact.Id, Name = contact.Name, Link = contact.Link, Personal = person };
			_context.Add(contact1);
			_context.SaveChanges();

			return contact1;
		}

	}
}


