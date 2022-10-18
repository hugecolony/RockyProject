using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using RockyProject.Data.Repository;
using RockyProject.Data.Repository.IRepository;
using RockyProject.Utility;
using RockyProject.Data;
using RockyProject.Data.Initializer;

var builder = WebApplication.CreateBuilder(args);
        //email

        builder.Services.AddTransient<IEmailSender, EmailSender>();
        // Add services to the container.
        builder.Services.AddControllersWithViews();
        builder.Services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
            options.EnableSensitiveDataLogging();
                    

        });
        builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
        builder.Services.AddScoped<IProductRepository, ProductRepository>();
        builder.Services.AddScoped<IInquiryDetailRepository, InquiryDetailRepository>();
        builder.Services.AddScoped<IInquiryHeaderRepository, InquiryHeaderRepository>();
        builder.Services.AddScoped<IApplicationTypeRepository, ApplicationTypeRepository>();
        builder.Services.AddScoped<IApplicationUserRepository, ApplicationUserRepository>();
        builder.Services.AddScoped<IOrderDetailRepository, OrderDetailRepository>();
        builder.Services.AddScoped<IOrderHeaderRepository, OrderHeaderRepository>();
        //builder.Services.AddScoped<IDbInitializer, DBInitializer>();
        builder.Services.AddAuthentication().AddFacebook(Options =>
        {
            Options.AppId = "1161419181465802";
            Options.AppSecret = "bf223187e7190b3634e8ecbaec678ef2";
        });
        builder.Services.AddIdentity<IdentityUser, IdentityRole>().AddDefaultTokenProviders().AddDefaultUI().AddEntityFrameworkStores<ApplicationDbContext>();
        //sessions
        builder.Services.AddSession(Options =>
        {
            Options.IdleTimeout = TimeSpan.FromMinutes(10);
            Options.Cookie.HttpOnly = true;
            Options.Cookie.IsEssential = true;

        });
        builder.Services.AddHttpContextAccessor();
        var app = builder.Build();
        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {   //pipelines
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }
        //middlewares

        app.UseHttpsRedirection();
        app.UseStaticFiles();
        app.UseRouting();
        app.UseAuthentication();
        app.UseAuthorization();
        app.UseSession();
        app.MapRazorPages();
        app.MapControllerRoute(

            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    
