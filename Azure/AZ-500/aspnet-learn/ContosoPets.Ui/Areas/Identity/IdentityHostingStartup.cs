using Microsoft.Data.SqlClient;

public void Configure(IWebHostBuilder builder)
{
    builder.ConfigureServices((context, services) => {
        var connBuilder = new SqlConnectionStringBuilder(
            context.Configuration.GetConnectionString("ContosoPetsAuthConnection"))
        {
            UserID = context.Configuration["DbUsername"],
            Password = context.Configuration["DbPassword"]
        };

        services.AddDbContext<ContosoPetsAuth>(options =>
            options.UseSqlServer(connBuilder.ConnectionString));

        services.AddDefaultIdentity<IdentityUser>()
            .AddDefaultUI()
            .AddEntityFrameworkStores<ContosoPetsAuth>();
    });
}