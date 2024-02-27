using DataAccess.Abstracts;
using Entities;

namespace DataAccess.Concretes
{
    public class CourseDal : ICourseDal
    {
        List<Course> _courses;

        public CourseDal()
        {
            _courses = new List<Course>()
            {
                new Course()
                {
                    Id = 1,
                    Name = "Senior Yazılım Geliştirici Yetiştirme Kampı",
                    Description = ".NET 6 üzerinde, clean architecture, CQRS, event güdümlü geliştirme, birim testleri, code first geliştirme, docker ve çok daha fazlasını içeren 2 aylık ileri bir kamp sizi bekliyor. Yine ücretsiz.",
                    Image = "imageurl",
                    Price = 0,
                    CategoryId = 1,
                    InstructorId = 1
                },
                new Course()
                {
                    Id = 2,
                    Name = "(2022) Yazılım Geliştirici Yetiştirme Kampı (JAVA)",
                    Description = "Adayların bir çoğu öğrenme döngüsü dediğim bir çıkmazın içinde.\r\n\r\nSürekli aynı konuları öğrenip daldan dala atlıyor.\r\n\r\nBu sorunun temelini programlamayı gerçek hayatla ilişkilendirememek olarak görüyorum.\r\n\r\nProgramlama teknolojilerinin hepsi aynı temele dayanır. Kampta bunu öğreneceksiniz.",
                    Image = "imageurl",
                    Price = 0,
                    CategoryId = 1,
                    InstructorId = 1
                },
                new Course()
                {
                    Id = 3,
                    Name = "(2023) Yazılım Geliştirici Yetiştirme Kampı (Python & Selenium)",
                    Description = "Adayların bir çoğu öğrenme döngüsü dediğim bir çıkmazın içinde.\r\n\r\nSürekli aynı konuları öğrenip daldan dala atlıyor.\r\n\r\nBu sorunun temelini programlamayı gerçek hayatla ilişkilendirememek olarak görüyorum.\r\n\r\nProgramlama teknolojilerinin hepsi aynı temele dayanır. Kampta bunu öğreneceksiniz.",
                    Image = "imageurl",
                    Price = 0,
                    CategoryId = 1,
                    InstructorId = 2
                },
            };
        }

        public void Add(Course entity)
        {
            _courses.Add(entity);
        }

        public void Delete(int id)
        {
            var course = _courses.FirstOrDefault(c => c.Id == id);
            if (course != null)
            {
                _courses.Remove(course);
            }
            else
            {
                Console.WriteLine($"Course with id {id} not found");
            }
        }

        public List<Course> GetAll()
        {
            return _courses;
        }

        public Course GetById(int id)
        {
            return _courses.FirstOrDefault(c => c.Id == id);
        }

        public void Update(Course entity)
        {
            var course = _courses.FirstOrDefault(c => c.Id == entity.Id);
            if (course != null)
            {
                course.Name = entity.Name;
            }
            else
            {
                Console.WriteLine($"Course with id {entity.Id} not found");
            }
        }
    }
}