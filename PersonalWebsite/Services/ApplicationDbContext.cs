using Microsoft.EntityFrameworkCore;
using PersonalWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalWebsite.Services
{
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Project> Projects { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Event>().HasData(
                new
                {
                    Id = 1,
                    Header2 = "East Tennessee State University",
                    Header3 = "Computer Science B.S.",
                    Description = "Currently in the computer science program at ETSU. Minoring with a mathematics minor. Graduating in May 2019.",
                    StartTime = new DateTime(2015, 08, 15),
                    EndTime = new DateTime(2019, 05, 8),
                    EventType = EventType.Education
                },
                new
                {
                    Id = 2,
                    Header2 = "Holston Medical Group",
                    Header3 = "Software Developer Intern",
                    Description = "Primarily responsible to change the website server from an outdated Windows 2003 server to a Windows 2012 Server. Worked with another intern to write SQL code that would transfer the data dynamically, such code included cursor for loops.",
                    StartTime = new DateTime(2016, 06, 01),
                    EndTime = new DateTime(2016, 08, 01),
                    EventType = EventType.Work
                },
                new
                {
                    Id = 3,
                    Header2 = "Nuclear Fuel Services",
                    Header3 = "IT Application Intern",
                    Description = "At NFS, I worked on the software used in the plant. Mostly working with ASP.Net MVC, C#.NET, SQL.",
                    StartTime = new DateTime(2017, 09, 26),
                    EndTime = DateTime.Now,
                    EventType = EventType.Work
                }
            );

            modelBuilder.Entity<Project>().HasData(
                new
                {
                    Id = 1,
                    Name = "Employee Pay Stub Calculator",
                    //HardwareRequired = new List<string>()
                    //{

                    //},
                    //KnowledgeRequired = new List<string>()
                    //{

                    //},
                    Description = "",
                    BreifDescription = "I foresaw an easier way to process employee pay checks at the small business I work at. Instead of calculating the tax by hand, I created a program that allows one to input the name, amount of hours worked, and the pay rate for an employee. Then the program will display a window with the employee's name, gross pay, social security tax, medicare tax, federal withhold tax and net pay. The program will then ask if the user would like to process another employee.",
                    URL = "https://github.com/feathersct"
                },
                new Project()
                {
                    Id = 2,
                    Name = "Text Analysis",
                    //HardwareRequired = new List<string>()
                    //{

                    //},
                    //KnowledgeRequired = new List<string>()
                    //{

                    //},
                    Description = "",
                    BreifDescription = "This program will split a text file into paragraphs, sentences, words, and tokens. It will then display those values to you. You can also flip through each paragraph or sentence and see the average word count, sentence count, etc.",
                    URL = "https://github.com/feathersct/Text-Analysis"
                },
                new
                {
                    Id = 3,
                    Name = "Light Switch Project",
                    //HardwareRequired = new List<string>()
                    //{
                    //    "Raspberry Pi",
                    //    "Servo Motor",
                    //    "3D Printed Mounts"
                    //},
                    //KnowledgeRequired = new List<string>()
                    //{
                    //    "HTML/CSS/JS",
                    //    "Apache Server and PHP",
                    //    "Python"
                    //},
                    Description = "This project started as an idea that if I was laying in my bed and didn't want to get up and turn the lights off that I can turn them off through my phone. First, in order to control the light switch I would have a raspberry pi hooked up to a servo motor and with some 3D parts the lights would be flicked on or off. In order to control the raspberry pi with my phone, I needed to install an Apache server so it can host the website I would make for the actual remote to flick the light on and off. After installing Apache the next step is to make the website. I used HTML/CSS/JS as the front end and used PHP as the back end. The front end would have buttons labeled \"on\" and \"off\". When pressed the button would activate the php file sending its title in return would call a Python script to turn the light on or off.",
                    BreifDescription = "This project started as an idea to control my lights without messing with the wires or replacing the light switch. This idea would primarily be for my college dorm room or apartment. This projects brain is a raspberry pi 3 with an Apache server in order to be located on the network. Also, the webpage was implemented with HTML, CSS, JavaScript, which would communicate to a PHP file which would access the Python script to control the servo motor and turn the light switch ON or OFF."
                },
                new
                {
                    Id = 4,
                    Name = "Old Website",
                    //HardwareRequired = new List<string>()
                    //{

                    //},
                    //KnowledgeRequired = new List<string>()
                    //{

                    //},
                    Description = "",
                    BreifDescription = "This was my first portfolio website I built in 2016. It's a simple one-pager like this one. Since then, I think my web development and design skills have expanded immensely.",
                    URL = "https://feathersct.github.io/Clayton-Feathers/Index3.html"
                }

            );
        }
    }
}
