using DataAccess.Abstracts;
using Entities;

namespace DataAccess.Concretes
{
    public class InstructorDal : IInstructorDal
    {
        List<Instructor> _instructors;

        public InstructorDal()
        {
            _instructors = new List<Instructor>()
            {
                new Instructor()
                {
                    Id = 1,
                    FirstName = "Engin",
                    LastName = "Demiroğ",
                    Image = "iamgeurl",
                    Description = "Yazılım geliştirmeye lisede \"yazılım\" bölümünde okurken başladım.\r\n\r\nÜniversite hayatıma ÖSS 2003 Türkiye derecesiyle başladım. Sırasıyla Başkent ve ODTÜ'de Yönetim Bilişim Sistemleri (Lisans-Burslu) ve Tıp Bilişimi(Yüksek Lisans) okudum. Profesyonel iş hayatıma ise henüz üniversite birinci sınıftayken başladım.\r\n\r\nAğırlıklı olarak Savunma Sanayisi, Bankacılık sektörlerine kurumsal yazılım geliştirme süreçleri konusunda danışmanlık veriyorum.\r\n\r\nMicrosoft Certified Trainer (MCT) ,PMP ve ITIL sertifikalarına sahibim.\r\n\r\n\"Engin Demiroğ\" YouTube kanalımda ücretsiz eğitim videoları ve içerikleri paylaşmaktayım.\r\n\r\nDanışmanlık yaptığım kurumların bazıları : Merkez Bankası,TAI, Birleşmiş Milletler,NATO,İş Bankası, Akbank, Halkbank, Vakıfbank, Yapı Kredi Bankası, Ziraat Bankası, Emniyet, Başbakanlık, Cumhurbaşkanlığı, Hazine Müsteşarlığı, Maliye Bakanlığı, Tarım Bakanlığı, Tübitak.\r\n\r\nDanışmanlık veya eğitim verdiğim kurum sayısı son 10 yılda 300'ü geçmiştir.\r\n\r\nDevFramework ismiyle geliştirdiğim altyapı projem birçok kurum ve firmada yazılım geliştirme altyapısı olarak kullanılmaktadır."
                },
                new Instructor()
                {
                    Id = 2,
                    FirstName = "Halit Enes",
                    LastName = "Kalaycı",
                    Image = "iamgeurl",
                    Description = "Description description description description description description description description description description description description description description description description description description description description description description description description description description description description description description description description description description description description description description description description description description description description description description description description description description description description description description description description description description description description description description"
                }
            };
        }

        public void Add(Instructor entity)
        {
            _instructors.Add(entity);
        }

        public void Delete(int id)
        {
            var instructor = _instructors.FirstOrDefault(i => i.Id == id);
            if (instructor != null)
            {
                _instructors.Remove(instructor);
            }
            else
            {
                Console.WriteLine($"Instructor with id {id} not found");
            }
        }

        public List<Instructor> GetAll()
        {
            return _instructors;
        }

        public Instructor GetById(int id)
        {
            return _instructors.FirstOrDefault(i => i.Id == id);
        }

        public void Update(Instructor entity)
        {
            var instructor = _instructors.FirstOrDefault(i => i.Id == entity.Id);
            if (instructor != null)
            {
                instructor.FirstName = entity.FirstName;
                instructor.LastName = entity.LastName;
                instructor.Image = entity.Image;
                instructor.Description = entity.Description;
            }
            else
            {
                Console.WriteLine($"Instructor with id {entity.Id} not found");
            }
        }
    }
}