

// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.ComponentModel.Design;
using WondeApiServices.IServices;
using WondeApiServices.Services;

    class Program
    {
        async static Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            var data0 = await host.Services.GetService<ISchoolService>().GetAll("82d1a6bd415d77309cc7fb7520ded1eabc9c0682", WondeApiModel.schoolStatus.All);
        var data1 = await host.Services.GetService<ISchoolService>().Get("82d1a6bd415d77309cc7fb7520ded1eabc9c0682", "A285616087");

        var data2 = await host.Services.GetService<IClasessService>().GetAll("82d1a6bd415d77309cc7fb7520ded1eabc9c0682", "A285616087");
        var data3 = await host.Services.GetService<IClasessService>().Get("82d1a6bd415d77309cc7fb7520ded1eabc9c0682", "A285616087", "A1981704444");
        
        var data4 = await host.Services.GetService<IEmployesService>().GetAll("82d1a6bd415d77309cc7fb7520ded1eabc9c0682", "A285616087");
        var data5 = await host.Services.GetService<IEmployesService>().Get("82d1a6bd415d77309cc7fb7520ded1eabc9c0682", "A285616087", "A1646377361");
        
        var data6 = await host.Services.GetService<ILessonService>().GetAll("82d1a6bd415d77309cc7fb7520ded1eabc9c0682", "A285616087");
        var data7 = await host.Services.GetService<ILessonService>().Get("82d1a6bd415d77309cc7fb7520ded1eabc9c0682", "A285616087", "A1248205189");

        var data8 = await host.Services.GetService<IPeriodService>().GetAll("82d1a6bd415d77309cc7fb7520ded1eabc9c0682", "A285616087");
        var data9 = await host.Services.GetService<IPeriodService>().Get("82d1a6bd415d77309cc7fb7520ded1eabc9c0682", "A285616087", "A1256735466");

        var data10 = await host.Services.GetService<IRoomService>().GetAll("82d1a6bd415d77309cc7fb7520ded1eabc9c0682", "A285616087");
        var data11 = await host.Services.GetService<IRoomService>().Get("82d1a6bd415d77309cc7fb7520ded1eabc9c0682", "A285616087", "A1319636951");

        var data12 = await host.Services.GetService<IStudentService>().GetAll("82d1a6bd415d77309cc7fb7520ded1eabc9c0682", "A285616087");
        var data13 = await host.Services.GetService<IStudentService>().Get("82d1a6bd415d77309cc7fb7520ded1eabc9c0682", "A285616087", "A896409457");


        Console.Read();
        }



        static IHostBuilder CreateHostBuilder(string[] args)
        {
            var hostBuilder = Host.CreateDefaultBuilder(args)
                .ConfigureAppConfiguration((context, builder) =>
                {
                    builder.SetBasePath(Directory.GetCurrentDirectory());
                })
                .ConfigureServices((context, services) =>
                {
                    //add your service registrations
                    services.AddSingleton<ISchoolService, SchoolService>();
                    services.AddSingleton<IClasessService, ClasessService>();
                    services.AddSingleton<IEmployesService, EmployesService>();
                    services.AddSingleton<ILessonService, LessonService>();
                    services.AddSingleton<IPeriodService, PeriodService>();
                    services.AddSingleton<IRoomService, RoomService>();
                    services.AddSingleton<IStudentService, StudentService>();
                });

            return hostBuilder;
        }
    }


