var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();



app.MapGet("/weatherforecast", () =>
{
    return "Its very cold";
});

app.MapGet("/Metro", () =>
{
    return "12:30 Serdika, 12:45 Vasil Levski";
});

app.Run();


