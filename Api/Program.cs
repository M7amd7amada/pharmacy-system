using Api.Extensions;
using Api.Constants;

var app = WebApplication.CreateBuilder().ConfigureServices().Build();

if (app.Environment.IsDevelopment()
    || app.Environment.IsEnvironment(GlobalConstants.Local)
    || app.Environment.IsEnvironment(GlobalConstants.Test))
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
else
{
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();