var builder = WebApplication.CreateBuilder();

builder.Services.AddServiceModelServices();
builder.Services.AddServiceModelMetadata();
builder.Services.AddSingleton<IServiceBehavior, UseRequestHeadersForMetadataAddressBehavior>();

var app = builder.Build();

app.UseServiceModel(serviceBuilder =>
{
    serviceBuilder.AddService<TaxCalculator.TaxCalculator>();
    serviceBuilder.AddServiceEndpoint<TaxCalculator.TaxCalculator, ITaxCalculator>(
        new BasicHttpBinding(BasicHttpSecurityMode.Transport),
        "/TaxCalculator.svc"
    );
    var serviceMetadataBehavior = app.Services.GetRequiredService<ServiceMetadataBehavior>();
    serviceMetadataBehavior.HttpsGetEnabled = true;
});

app.Run();