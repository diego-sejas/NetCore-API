using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using WebApi_Disney.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApiDisneyContext>(options => {

    options.UseSqlServer(builder.Configuration.GetConnectionString("DBConnection"));
});

var app = builder.Build();


using (var scope = app.Services.CreateScope())
{
    var Context = scope.ServiceProvider.GetRequiredService<ApiDisneyContext>();
    Context.Database.Migrate();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Web Api Disney",
        Description = "Api personajes Peliculas Disney",
        TermsOfService = new Uri("https://disney.com"),
        Contact = new OpenApiContact
        {
            Name = "Contacto",
            Url = new Uri("https://example.com/contact")
        },
        License = new OpenApiLicense
        {
            Name = "Licencia",
            Url = new Uri("https://example.com/license")
        }
    });
});
