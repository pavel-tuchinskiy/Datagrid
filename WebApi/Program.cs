using DataAccess.Configuration;
using DataAccess.Data.Seed;
using Domain.DTOs;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using WebApi.Configuration;
using WebApi.Middlewares;
using WebApi.Models;

var builder = WebApplication.CreateBuilder(args);

var configuration = builder.Configuration;

builder.Services.ConfigureSqlConnection(configuration);
builder.Services.ConfigureCORS();
builder.Services.ConfigureDAServices();
builder.Services.AddControllers()
    .ConfigureApiBehaviorOptions(options =>
    {
        options.InvalidModelStateResponseFactory = context =>
        {
            var messages = context.ModelState.Values
                .Where(x => x.ValidationState == ModelValidationState.Invalid)
                .SelectMany(x => x.Errors)
                .Select(x => x.ErrorMessage)
                .ToList();

            string message = String.Empty;

            messages.ForEach(x =>
            {
                message += x + "\n";
            });

            var response = new ReturnHttpResult(400, exception: new ResponseExceptionDTO(message, nameof(WebApi), nameof(ErrorCodes.Err400)));

            return new BadRequestObjectResult(response);
        };
    });
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    await app.SeedDbData(configuration);
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("GridCors");

app.UseHttpsRedirection();

app.UseAuthorization();

app.UseMiddleware<ErrorHandlingMiddleware>();

app.MapControllers();

app.Run();
