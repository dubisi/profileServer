
using Microsoft.OpenApi.Models;
using Profile.Data;
using Profile.Services;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);
var MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

// Add services to the container.
builder.Services.AddScoped<ProfileContext>();
builder.Services.AddScoped<ProfileServices>();
builder.Services.AddScoped<ProfileCreate>();

builder.Services.AddCors(options =>
{
	options.AddPolicy(name: "MyPolicy",
				policy =>
				{
					policy.WithOrigins("https://dubisi-1dcfa.web.app", "https://dubisi.github.io").AllowAnyHeader()
												  .AllowAnyMethod();
				});
});


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

/*builder.Services.AddSqlite<ProfileContext>("Data Source=Profile.db");*/
var app = builder.Build();



// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI(options =>
	{
		options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
		options.RoutePrefix = string.Empty;
	});

}

app.UseCors(MyAllowSpecificOrigins);

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();


app.Run();
