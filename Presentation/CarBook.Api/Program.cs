using CarBook.Application.Services;
using FluentValidation.AspNetCore;
using CarBook.Application.Validators.ReviewValidators;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using CarBook.Application.Tools;
using CarBook.Api.Hubs;
using CarBook.Api.Extensions;


var builder = WebApplication.CreateBuilder(args);
builder.Services.AddHttpClient();
builder.Services.AddProjectServices();
builder.Services.AddApplicationService(builder.Configuration);

builder.Services.AddCors(opt =>
{
    opt.AddPolicy("CorsPolicy", builder =>
    {
        builder.AllowAnyHeader()
        .AllowAnyMethod()
        .SetIsOriginAllowed((host) => true)
        .AllowCredentials();
    });
});
builder.Services.AddSignalR();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
{
    opt.RequireHttpsMetadata = false;
    opt.TokenValidationParameters = new TokenValidationParameters()
    {
        ValidAudience = JwtTokenDefaults.ValidAuidience,
        ValidIssuer = JwtTokenDefaults.ValidIssuer,
        ClockSkew = TimeSpan.Zero,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtTokenDefaults.Key)),
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true
    };
});


// Add services to the container.
builder.Services.AddApplicationService(builder.Configuration);
builder.Services.AddControllers().AddFluentValidation(v =>

{

    v.ImplicitlyValidateChildProperties = true;

    v.ImplicitlyValidateRootCollectionElements = true;

    v.RegisterValidatorsFromAssemblyContaining<CreateReviewValidator>();

}); ;
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("CorsPolicy");
app.UseHttpsRedirection();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();
app.MapHub<CarHub>("/carhub");
app.Run();
