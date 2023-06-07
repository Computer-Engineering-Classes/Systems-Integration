using WcfService;

var builder = WebApplication.CreateBuilder();

builder.Services.AddServiceModelServices();
builder.Services.AddServiceModelMetadata();
builder.Services.AddSingleton<IServiceBehavior, UseRequestHeadersForMetadataAddressBehavior>();

var app = builder.Build();

app.UseServiceModel(serviceBuilder =>
{
    serviceBuilder.AddService<FrequenciaWS70633>();
    serviceBuilder.AddServiceEndpoint<FrequenciaWS70633, IFrequenciaWS70633>(
        new BasicHttpBinding(BasicHttpSecurityMode.Transport),
        "/FrequenciaWS70633.svc"
    );
    var serviceMetadataBehavior = app.Services.GetRequiredService<ServiceMetadataBehavior>();
    serviceMetadataBehavior.HttpsGetEnabled = true;
});

app.Run();