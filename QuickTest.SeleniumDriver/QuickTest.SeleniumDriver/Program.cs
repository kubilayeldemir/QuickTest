using DataAccess.Utilities;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using DataAccess.Interfaces;
using System.Threading.Tasks;
using DataAccess.Repositories;
using QuickTest.SeleniumDriver.SeleniumEngine;
using QuickTest.SeleniumDriver.SeleniumEngine.Interfaces;
using System.Threading;

namespace QuickTest.SeleniumDriver
{
    class Program
    {
        static async Task Main(string[] args)
        {
            //Dependency Injection
            var serviceProvider = new ServiceCollection()
            .AddTransient<IClient, Client>()
            .AddSingleton<HttpClient>()
            .AddScoped<ITestcaseRepository,TestcaseRepository>()
            .AddScoped<ITestReportRepository, TestReportRepository>()
            .AddSingleton<ITestRunner,TestRunner>()
            .AddScoped<ITestSchedular,TestSchedular>()
            .AddScoped<ITestPoolRepository,TestPoolRepository>()
            .BuildServiceProvider();
            
            var testSchedular = ActivatorUtilities.CreateInstance<TestSchedular>(serviceProvider);
            while (true)
            {
                await testSchedular.GetAndRunATestAsync();
                Thread.Sleep(1000 * 10);
            }

            Console.WriteLine("end");
        }
    }
}
