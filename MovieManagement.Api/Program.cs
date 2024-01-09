using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using MovieManagement.Application.GlobalErrors;
using MovieManagement.Application.Filter;
using MovieManagement.Application.Middleware;
using MovieManagement.Application.Service;
using MovieManagement.Domain.Repository;
using MovieManagement.Domain.UnitOfWork;
using MovieManagement.Infrastructure.Context;
using MovieManagement.Infrastructure.Repository;
using MovieManagement.Infrastructure.UnitOfWork;

var builder = WebApplication.CreateBuilder(args);

{
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    //builder.Services.AddControllers(options =>options.Filters.Add<ErrorHandlingFilterAttribute>());
    builder.Services.AddControllers();
    builder.Services.AddSingleton<ProblemDetailsFactory, GlobalProblemDetailsFactory>();
    builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

    builder.Services.AddScoped<IActorService, ActorService>();

    builder.Services.AddDbContext<MovieManagementDbContext>(options
        => options.UseSqlServer(builder.Configuration.GetConnectionString("MovieConnection")));
}

var app = builder.Build();

{
    app.UseHttpsRedirection();
    app.MapControllers();
    app.UseExceptionHandler("/error/details");
    app.Run();

    //app.UseMiddleware<ErrorHandlingMiddleware>();
}




