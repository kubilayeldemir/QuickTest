using DataAccess.Utilities;
using System.Net.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using DataAccess.Interfaces;
using System.Threading.Tasks;
using DataAccess.Models;
using System.Collections.Generic;
using DataAccess.Repositories;
using QuickTest.SeleniumDriver.SeleniumEngine;

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
            .AddSingleton<ITestRunner,TestRunner>()
            .BuildServiceProvider();

            //var cls = ActivatorUtilities.CreateInstance<Client>(serviceProvider);
            //var data = await cls.GetAsync<List<Testcase>>("testcase");

            //var repo = ActivatorUtilities.CreateInstance<TestcaseRepository>(serviceProvider);
            //var data = await repo.GetAllTestcases();

            var tr = ActivatorUtilities.CreateInstance<TestRunner>(serviceProvider);
            Console.WriteLine(await tr.RunTestAsync());

            //var httpClient = new HttpClient();
            //var cl = new Client(httpClient);
            //var data = await cl.GetAsync<List<Testcase>>("testcase");
            Console.WriteLine("end");

            //var URL = $"http://localhost:8080/api/testcase";
            //var response = await httpClient.GetAsync(URL);
            //var content = response.Content;
            //var data = await content.ReadAsAsync<List<Testcase>>();
            //Console.WriteLine(data);

        }
    }
}
