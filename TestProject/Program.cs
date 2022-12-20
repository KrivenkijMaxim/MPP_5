using System.Threading.Tasks;

namespace TestProject
{
    class Program
    {
        public static async Task Main()
        {
            await new Pipeline().Generate(2,
                @"D:\3course\СПП\Lab4\MPP_4\GeneratedTests",
                @"D:\3course\СПП\Lab4\MPP_4\TestProject\TestClass.cs",
                @"D:\3course\СПП\Lab4\MPP_4\TestProject\AnotherTestClass.cs"); 
        }
    }
}