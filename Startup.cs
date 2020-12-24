using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using UsersDbContext.Entities;

namespace API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // services.AddDbContext<UserDbContext>(optionsAction=>
            // {
            //     optionsAction.UseMySql("<connection_string>");
            // }
            // );
            //连接 mysql 数据库，添加数据库上下文
            services.AddDbContext<UserDbContext>(config => config.UseMySql(Configuration.GetConnectionString("DefaultConnection")));

            services.AddControllers();
                        // 注册Swagger服务
            services.AddSwaggerGen (c => {
                // 添加文档信息
                c.SwaggerDoc ("v1",
                    new Microsoft.OpenApi.Models.OpenApiInfo {              
                        Title = "智慧电厂.NET",
                        Version = "v1",
                        Description = "Haitong Automatic Control",
                        // TermsOfService = new Uri("https://example.com/terms"),
                        // Contact = new OpenApiContact
                        // {
                        //     Name = "Shayne Boyer",
                        //     Email = string.Empty,
                        //     Url = new Uri("https://twitter.com/spboyer"),
                        // },
                        // License = new OpenApiLicense
                        // {
                        //     Name = "Use under LICX",
                        //     Url = new Uri("https://example.com/license"),
                        // }
                    });
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            // app.UseHttpsRedirection ();
            // 启用Swagger中间件
            app.UseSwagger ();
            // 配置SwaggerUI
            app.UseSwaggerUI (c => {
                c.SwaggerEndpoint ("/swagger/v1/swagger.json", "WebApiDemo");
                c.RoutePrefix = string.Empty;
            });

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            
        }
    }
}
