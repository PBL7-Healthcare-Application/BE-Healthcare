using BE_Healthcare.Models;
using BE_Healthcare.Data;
using BE_Healthcare.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using BE_Healthcare.Models.EmailModel;
using Microsoft.OpenApi.Models;

using FirebaseAdmin;
using Google.Apis.Auth.OAuth2;
var builder = WebApplication.CreateBuilder(args);


var configuration = builder.Configuration;
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo
    {
        Title = "API",
        Version = "v1"
    });
    // To Enable authorization using Swagger (JWT)
    c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
    {
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey,
        Scheme = "Bearer",
        BearerFormat = "JWT",
        In = ParameterLocation.Header,
        Description = "Enter 'Bearer' [space] and then your valid token in the text input below.\r\n\r\nExample: \"Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9\"",
    });
    c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            Array.Empty<string>()
        }
    });
});

var connectionString = configuration.GetConnectionString("Default");
var serverVersion = new MySqlServerVersion(new Version(8, 0, 34));
builder.Services.AddDbContext<MyDbContext>(option => option
    .UseMySql(connectionString, serverVersion)
    .LogTo(Console.WriteLine, LogLevel.Information)
    .EnableSensitiveDataLogging(true)
    .EnableDetailedErrors()
);

//Add Email Configs
var emailConfig = configuration.GetSection("EmailConfiguration").Get<EmailConfiguration>();
builder.Services.AddSingleton(emailConfig);

builder.Services.AddScoped<IEmailService, EmailService>();
builder.Services.AddScoped<IAuthRepository, AuthRepository>();
builder.Services.AddScoped<IDoctorRepository, DoctorRepository>();
builder.Services.AddScoped<IMedicalSpecialtyRepository, MedicalSpecialtyRepository>();
builder.Services.AddScoped<IProfileRepository, ProfileRepository>();
builder.Services.AddScoped<IAppointmentRepository, AppointmentRepository>();
builder.Services.AddScoped<ICertificateRepository, CertificateRepository>();
builder.Services.AddScoped<ITrainingProcessRepository, TrainingProcessRepository>();
builder.Services.AddScoped<IWorkingProcessRepository, WorkingProcessRepository>();
builder.Services.AddScoped<IPartnerRepository, PartnerRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<ICalendarRepository,  CalendarRepository>();
builder.Services.AddScoped<INotificationRepository, NotificationRepository>();
builder.Services.AddScoped<IRatingRepository, RatingRepository>();



builder.Services.Configure<AppSetting>(configuration.GetSection("AppSettings"));

var secretKey = configuration["AppSettings:SecretKey"];
var secretKeyBytes = Encoding.UTF8.GetBytes(secretKey);

builder.Services.AddAuthentication
    (JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(opt =>
    {
        opt.TokenValidationParameters = new TokenValidationParameters
        {

            //tu cap token
            ValidateIssuer = false,
            ValidateAudience = false,

            //ky vao token
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(secretKeyBytes),

            ClockSkew = TimeSpan.Zero
        };
    });
//builder.WebHost.UseUrls("http://10.0.11.20:7061");
//builder.Services.AddAuthentication
//    (JwtBearerDefaults.AuthenticationScheme).AddJwtBearer(options => 
//    { 
//        options.TokenValidationParameters = new TokenValidationParameters 
//        { 
//            ValidateIssuer = true, 
//            ValidIssuer = "IdentityServerIssuer", 
//            ValidateAudience = true, 
//            ValidAudience = "IdentityServerClient", 
//            ValidateLifetime = true, 
//            IssuerSigningKey = new SymmetricSecurityKey(secretKeyBytes), 
//            ValidateIssuerSigningKey = true, 
//        }; 
//    }); 
builder.Services.AddAuthorization();

builder.Services.AddSignalR();

//var pathToFirebaseConfig = Path.Combine(Directory.GetCurrentDirectory(), "healthcare-2d0e4-firebase-adminsdk-20q4k-d55b92ccba.json");

//var defaultApp = FirebaseApp.Create(new AppOptions()
//{
//    Credential = GoogleCredential.FromFile(pathToFirebaseConfig),
//});



builder.Services.Configure<AppSetting>(configuration.GetSection("FirebaseConfig"));

//var serverKey = configuration["FirebaseConfig:server_key"];
var projectId = configuration["FirebaseConfig:project_id"];

builder.Services.AddSingleton(new FirestoreService(projectId));

var app = builder.Build();

//app.UseCors(opt =>
//{
//    opt.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin();
//});
app.UseCors(builder => builder
    .WithOrigins("http://localhost:5173") // replace with your React app's address
    .AllowAnyHeader()
    .AllowAnyMethod()
    .AllowCredentials());


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapControllers();

app.UseRouting();
app.UseAuthorization();

app.UseDefaultFiles();
app.UseStaticFiles();

app.Run();
