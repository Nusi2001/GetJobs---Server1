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
                    new Job { Title = "Software Engineer", Domain = "IT", Description = "Develop software applications.", Location = "New York", Salary = 120000 },
                    new Job { Title = "Data Analyst", Domain = "Analytics", Description = "Analyze complex data sets.", Location = "San Francisco", Salary = 95000 },
                    new Job { Title = "Marketing Specialist", Domain = "Marketing", Description = "Create marketing campaigns.", Location = "Remote", Salary = 85000 },
                    new Job { Title = "QA Tester", Domain = "Quality", Description = "Test and validate software.", Location = "Chicago", Salary = 90000 },
                    new Job { Title = "DevOps Engineer", Domain = "Infrastructure", Description = "Manage deployment pipelines.", Location = "Austin", Salary = 110000 },
                    new Job { Title = "UX Designer", Domain = "Design", Description = "Design user interfaces.", Location = "Seattle", Salary = 88000 },
                    new Job { Title = "Project Manager", Domain = "Management", Description = "Oversee software development projects.", Location = "Boston", Salary = 100000 },
                    new Job { Title = "Technical Writer", Domain = "Documentation", Description = "Write and edit technical documents.", Location = "Denver", Salary = 87000 },
                    new Job { Title = "Frontend Developer", Domain = "Web", Description = "Develop UI components.", Location = "Los Angeles", Salary = 96000 },
                    new Job { Title = "Backend Developer", Domain = "Web", Description = "Build and maintain APIs.", Location = "Dallas", Salary = 105000 },
                    new Job { Title = "Mobile Developer", Domain = "Mobile", Description = "Develop mobile applications.", Location = "San Diego", Salary = 98000 },
                    new Job { Title = "Cloud Engineer", Domain = "Cloud", Description = "Manage cloud infrastructure.", Location = "Phoenix", Salary = 112000 },
                    new Job { Title = "AI Researcher", Domain = "AI", Description = "Research and implement AI models.", Location = "Palo Alto", Salary = 135000 },
                    new Job { Title = "Security Analyst", Domain = "Security", Description = "Ensure cybersecurity and compliance.", Location = "Washington D.C.", Salary = 102000 }
                };

                context.Jobs.AddRange(jobs);
                await context.SaveChangesAsync();
            }
        }
    }
}