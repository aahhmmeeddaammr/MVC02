namespace Assignment1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllers();
            var app = builder.Build();
            
            app.MapGet("/", () => "Hello World!");
            app.MapGet("/hamada", () => "Hello Hamada");
            app.MapControllerRoute(
                name: "defult",
                pattern: "{controller=Movie}/{Action=GetMove}/{id:int?}"
               // default:new{ controller = "Move", Action = "GetMovie" }
                ) ;
            app.Run();
        }
    }
}
