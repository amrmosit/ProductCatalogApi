var builder = WebApplication.CreateBuilder(args);

// Register controllers for endpoint mapping
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


// Map the controllers
app.MapControllers();
app.Run();
