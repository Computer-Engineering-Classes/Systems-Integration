var builder = WebApplication.CreateBuilder();

builder.Services.AddServiceModelServices();
builder.Services.AddServiceModelMetadata();
builder.Services.AddSingleton<IServiceBehavior, UseRequestHeadersForMetadataAddressBehavior>();

var app = builder.Build();

app.UseServiceModel(serviceBuilder =>
{
    serviceBuilder.AddService<CurrencyConverter.CurrencyConverter>();
    serviceBuilder.AddServiceEndpoint<CurrencyConverter.CurrencyConverter, ICurrencyConverter>(
        new BasicHttpBinding(BasicHttpSecurityMode.Transport),
        "/CurrencyConverter.svc"
    );
    var serviceMetadataBehavior = app.Services.GetRequiredService<ServiceMetadataBehavior>();
    serviceMetadataBehavior.HttpsGetEnabled = true;
});

app.Run();