<<<<<<< HEAD
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using NuGet.Protocol.Core.Types;
using Profile.Controllers;
=======
using Microsoft.OpenApi.Models;
>>>>>>> 60167df514ac0c0f85c7cacbd69397fd39ac45d7
using Profile.Data;
using Profile.Services;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
<<<<<<< HEAD
builder.Services.AddScoped<ProfileContext>();
builder.Services.AddScoped<ProfileServices>();
builder.Services.AddScoped<ProfileCreate>();

=======
>>>>>>> 60167df514ac0c0f85c7cacbd69397fd39ac45d7



// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
	c.SwaggerDoc("v1", new OpenApiInfo
	{
		Title = "Profile Api",
		Version = "v1",
		Description = "Profile that will connect you with potential",
		Contact = new OpenApiContact
		{
			Name = "Demaind Ubisi",
			Email = "dubisi265@gmail.com",

		}

	}); var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
	var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
	c.IncludeXmlComments(xmlPath);
});
<<<<<<< HEAD

/*builder.Services.AddSqlite<ProfileContext>("Data Source=Profile.db");*/
=======
builder.Services.AddScoped<ProfileServices>();
builder.Services.AddScoped<ProfileCreate>();
builder.Services.AddSqlite<ProfileContext>("Data Source=Profile.db");
>>>>>>> 60167df514ac0c0f85c7cacbd69397fd39ac45d7

var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
<<<<<<< HEAD
	app.UseSwaggerUI(options =>
	{
		options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
		options.RoutePrefix = string.Empty;
	});
=======
	app.UseSwaggerUI();
>>>>>>> 60167df514ac0c0f85c7cacbd69397fd39ac45d7

}

app.UseCors();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


app.Run();
