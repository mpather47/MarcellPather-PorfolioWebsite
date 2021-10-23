using MPPorfolioWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MPPorfolioWebsite.Data
{
    public static class MockData
    {
        public static List<Technologies> Technologies()
        {
            var technologies = new List<Technologies>()
            {
                new Technologies()
                {
                    Icon = "fab fa-js-square fa-2x",
                    Name = "JavaScript",
                    Description = "Scalable and dynamic web applications, web and mobile solutions with interactive user interfaces"
                },
                new Technologies()
                {
                    Icon = "fab fa-java fa-2x",
                    Name = "Java",
                    Description = "Object Oreinted Programming, Domain Driven Design, Test Driven Design, Springboot Intergrated Applications,REST API's"
                },
                new Technologies()
                {
                    Icon = "iconfinder_page_white_csharp_36274.png",
                    Name = "C#",
                    Description = "Object Oriented Programming, Game Development in C# framework such as Unity"
                },
                new Technologies()
                {
                    Icon = "fab fa-python fa-2x",
                    Name = "Python",
                    Description = "Machine learning prediction modules and AI chatbot development, Automation using selenium"
                },
                new Technologies()
                {
                    Icon = "iconfinder_scala_4691541.png",
                    Name = "Scala",
                    Description = "Functional Programming, Object Oriented Programming, Lambda Expression"
                },
                new Technologies()
                {
                    Icon = "fab fa-html5 fa-2x",
                    Name = "HTML & CSS",
                    Description = "Static multi-page websites. Convert your PSD designs to HTML format"
                },
                new Technologies()
                {
                    Icon = "fab fa-react fa-2x",
                    Name = "REACT",
                    Description = "Large scalable web applications, modular interface designs, improved website performance"
                },
                new Technologies()
                {
                    Icon = "fab fa-angular",
                    Name = "Angular",
                    Description = "Large scalable web applications, modular interface designs, improved website performance"
                }
            };

            return technologies;
        }

        public static List<Testimonials> Testimonials()
        {
            var testimonials = new List<Testimonials>()
            {
                new Testimonials()
                {
                    Name = "Rachel Klein",
                    Testimonial = "Marcell is diligent towards his work performance and always understands what is expected of him. I would recommend Marcel to any work place, and believe he will perform well and always give his best.",
                    JobDescription = "Developer at Full Stack",
                    ProfilePhoto = "rachel.jpg"
                },
                new Testimonials()
                {
                    Name = "Sherwin Adams",
                    Testimonial = "I have worked with Marcell since 2017. He has always showed passion in his work. He has shown a lot of dedication throughout the years and always strives to be the best. If I were a business owner, Marcell would be the first person I hire",
                    JobDescription = "Student at CPUT",
                    ProfilePhoto = "sherwin.jpg"
                },
                new Testimonials()
                {
                    Name = "Bradley van der Westerhuizen",
                    Testimonial = "Marcell is an absolute pleasure to work with on projects. He adds a critical and analytical mind to every team environment. He has a strong sense of work ethics and always proves himself capable in various situations. He has performed nothing less than excellent on every task he was assigned when collaborating in a team. He has good communication skills and his team work is of the finest quality.",
                    JobDescription = "Software Developer at DMC",
                    ProfilePhoto = "pp.jpg"
                },
                new Testimonials()
                {
                    Name = "Cameron Mostert",
                    Testimonial = "Marcell is a great team worker and a brilliant team leader. I had the pleasure of working with him on a management system project for our third year, and got to experience first hand his inquisitive mind, quick thinking and great team building skills. He understands well what is expected of him and always does his best to look out for his peers and make sure no one gets left behind. He has shown himself to be a natural programmer and I am sure any team would do nothing but prosper with him on board.",
                    JobDescription = "Student at CPUT",
                    ProfilePhoto = "Cameron.jpeg"
                },
                new Testimonials()
                {
                    Name = "Chris Claude",
                    Testimonial = "Marcel is a passionate software developer. We have worked together on a few projects. He has knowledge of agile methodologies. He is well versed in JVM languages such as Java and Scala. I have seen how he can effectively handle tight deadlines and deliver quality work. He is a good developer to have on one's team as he not only possesses technical abilities but also communication abilities and even more.",
                    JobDescription = "Software Developer at Exigent Group Limited",
                    ProfilePhoto = "claude.jpg"
                },
                new Testimonials()
                {
                    Name = "Chad Stevens",
                    Testimonial = "Marcell brings a lot of good qualities to the team and shows how capable and dependable he is. His enthusiasm in IT shows as he goes above and beyond in delivering what was needed for assignments. He’s involvement in the team is always beneficial since he tries to view things in the quickest yet best solution to obtaining the projected outcome.  Furthermore, his willingness to learn and apply newly acquire skills to better the assignments brought a new level of competitiveness and dedication to the team to succeed.",
                    JobDescription = "Software Developer at DMC",
                    ProfilePhoto = "Chad.jpg"
                }
            };

            return testimonials;
        }


    }
}
