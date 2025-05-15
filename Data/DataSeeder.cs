using Server.Data;
using Server.Models;

namespace Server.Data
{
    public static class DataSeeder
    {
        public static async Task SeedSampleDataAsync(ApplicationDbContext context)
        {
            if (!context.Jobs.Any())
            {
                var jobs = new List<Job>
                {
                    new Job { Title = "Software Engineer", Domain = "IT", Description = "Develop web applications", Location = "New York", Salary = 90000 },
                    new Job { Title = "Data Analyst", Domain = "Analytics", Description = "Analyze data trends", Location = "Missuori", Salary = 87000 - 10000 },
                    new Job { Title = "Mechanical Engineer", Domain = "Engineering", Description = "Design mechanical systems", Location = "Austin", Salary = 97000 - 120000 },
                    new Job { Title = "Graphic Designer", Domain = "Design", Description = "Create digital assets and branding", Location = "Michigan", Salary = 92000 - 126000  }
                };

                context.Jobs.AddRange(jobs);
                await context.SaveChangesAsync();
            }
        }
    }
}