using Azure.Storage.Blobs;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var blobstring = builder.Configuration.GetConnectionString("connectionString");
var database = builder.Configuration.GetConnectionString("database");

//builder.Services.AddDbContext<MAppContext>(options => options.UseNpgsql(database));

BlobServiceClient blobServiceClient = new(blobstring);


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
