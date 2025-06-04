using Microsoft.AspNetCore.Mvc;
using static System.Net.Mime.MediaTypeNames;

var builder = WebApplication.CreateBuilder(args);

#region Error Handling

//Start Response Factory for ExceptionHandling at endpoints

builder.Services.AddRazorPages().ConfigureApiBehaviorOptions(options =>
{
    options.InvalidModelStateResponseFactory = context =>
        new BadRequestObjectResult(context.ModelState)
        {
            ContentTypes =
            {
                    // using static System.Net.Mime.MediaTypeNames;
                    Application.Json,
                    Application.Xml
            }
        };
}).AddXmlSerializerFormatters();

//end response factory for ExceptionHandling 

//add custom error handling
builder.Services.AddExceptionHandler
    (options =>
    {
        options.ExceptionHandlingPath = "/Views/Shared/DisplayErrors";
    });//end AddExceptionHandler

// Add services to the container.
builder.Services.AddRazorPages().ConfigureApiBehaviorOptions(options =>
{
    options.InvalidModelStateResponseFactory = context =>
        new BadRequestObjectResult(context.ModelState)
        {
            ContentTypes =
            {
                    // using static System.Net.Mime.MediaTypeNames;
                    Application.Json,
                    Application.Xml
            }
        };
})
    .AddXmlSerializerFormatters(); 

#endregion

var app = builder.Build();

app.UseRouting();

#pragma warning disable ASP0014 

app.UseEndpoints(endpoints =>
{
    endpoints.MapRazorPages();
});

#pragma warning restore ASP0014 

app.MapRazorPages();

app.Run();