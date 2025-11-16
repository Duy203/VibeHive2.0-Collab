using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using EventManagement.API.services;
using VibeHive.Common;
using VibeHive.Core.Interface;

var builder = WebApplication.CreateBuilder(args);

// JWT CONFIG
var jwtSettings = new JwtSetting
{
    Key = "THIS_IS_A_SECRET_KEY_CHANGE_IT",
    Issuer = "EventAPI",
    Audience = "EventAPIUsers"
};
builder.Services.AddSingleton(jwtSettings);

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
.AddJwtBearer(options =>
{
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = jwtSettings.Issuer,
        ValidAudience = jwtSettings.Audience,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.Key))
    };
});

// SERVICES
builder.Services.AddSingleton<IAuthService, AuthService>();
builder.Services.AddSingleton<IEventService, EventService>();
builder.Services.AddSingleton<ITicketService, TicketService>();

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();