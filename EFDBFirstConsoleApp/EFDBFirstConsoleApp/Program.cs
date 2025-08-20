using EFDBFirstConsoleApp.Models;
using EFDBFirstConsoleApp.Services;

namespace EFDBFirstConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BykeStoresContext context = new BykeStoresContext();
            StaffService ss = new StaffService(context);
            ss.DisplayStaff();
        }
    }
}
