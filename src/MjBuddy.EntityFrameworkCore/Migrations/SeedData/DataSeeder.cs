using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace MjBuddy.EntityFrameworkCore.Migrations.SeedData
{
    public static class DataSeeder
    {
        // TODO: Move this code when seed data is implemented in EF 7

        /// <summary>
        /// This is a workaround for missing seed data functionality in EF 7.0-rc1
        /// More info: https://github.com/aspnet/EntityFramework/issues/629
        /// </summary>
        /// <param name="app">
        /// An instance that provides the mechanisms to get instance of the database context.
        /// </param>
        public static void SeedData(this IApplicationBuilder app)
        {
            var db = app.ApplicationServices.GetService<MjBuddyDbContext>();

            new DefaultTilesCreator(db).Create();

            // TODO: Add seed logic here

            db.SaveChanges();
        }
    }
}
