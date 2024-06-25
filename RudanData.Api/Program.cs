using RudanData.Entities;
using RudanData.InMemoryRepository;
using System.Text.Json.Serialization;

namespace RudanData.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateSlimBuilder(args);

            builder.Services.ConfigureHttpJsonOptions(options =>
            {
                options.SerializerOptions.TypeInfoResolverChain.Insert(0, AppJsonSerializerContext.Default);
            });

            builder.Services.AddCors(options =>
            {
                options.AddPolicy("AllowAll", policy =>
                {
                    policy.AllowAnyHeader()
                        .AllowAnyMethod()
                        .SetIsOriginAllowed(_ => true)
                        .AllowCredentials();
                });
            });

            var app = builder.Build();

            app.UseCors("AllowAll");

            var readingsApi = app.MapGroup("/readings");
            readingsApi.MapGet("/", () => ReadingRepository.GetDataSeries());

            app.Run();
        }
    }

    [JsonSerializable(typeof(List<ReadingDTO>))]
    internal partial class AppJsonSerializerContext : JsonSerializerContext
    {

    }
}
