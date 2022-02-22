// See https://aka.ms/new-console-template for more information

using BindPropertyExceptionSample;

using Microsoft.Extensions.Configuration;

var config = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json")
    .Build();

var testConfig = new Configuration();
config.GetSection("TestConfig").Bind(testConfig);

Console.WriteLine($"Filtered config values: {string.Join(", ", testConfig.FilteredConfigValues)}");
