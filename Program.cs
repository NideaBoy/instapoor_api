using instapoor_api.Lib;
using instapoor_api.Seeding;
using instapoor_api.Type;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<Cnn>();
builder.Services.AddTransient<Seeding>();
builder.Services.AddCors(option =>
{
    option.AddPolicy("Np", app =>
    {
        app.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
    });
});
var app = builder.Build();
var s = new Seeding();

// Configure the HTTP request pipeline.
if (app.Configuration["seed"] != null && app.Configuration["seed"].ToString() == "true")
{
    s.SeedProfile(app.Configuration.GetSection("MONGO").Get<ENV>().CNN);
    s.SeedPost(app.Configuration.GetSection("MONGO").Get<ENV>().CNN);
}
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseDefaultFiles();
app.UseStaticFiles();
app.UseCors("Np");
app.UseAuthorization();

app.MapControllers();

app.Run();
