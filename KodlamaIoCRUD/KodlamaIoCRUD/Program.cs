using Business.Concretes;
using DataAccess.Concretes;
using Entities;

CourseManager _courseManager = new CourseManager(new CourseDal());
CategoryManager _categoryManager = new CategoryManager(new CategoryDal());
InstructorManager _instructorManager = new InstructorManager(new InstructorDal());

Console.WriteLine("Kurslarla ilgili bir iþlem yapmak için 1'e,\nKategorilerle ilgili bir iþlem yapmak için 2'e,\nEðitmenlerle ilgili bir iþlem yapmak için 3'e basýnýz");
int operation = Convert.ToInt32(Console.ReadLine());

// Course
if (operation == 1)
{
    Console.WriteLine("1 - Listele\n2 - Id'ye göre listele\n3 - Ekle\n4 - Güncelle\n5 - Sil");
    int courseOperation = Convert.ToInt32(Console.ReadLine());
    // Get all
    if (courseOperation == 1)
    {
        var courses = _courseManager.GetAll();
        foreach (var course in courses)
        {
            Console.WriteLine(course.Name);
        }
    }
    // Get by id
    else if (courseOperation == 2)
    {
        Console.WriteLine("Görüntülemek istediðiniz kursun Id'sini giriniz");
        int courseId = Convert.ToInt32(Console.ReadLine());

        var course = _courseManager.GetById(courseId);
        Console.WriteLine(course.Name);
    }
    // Add
    else if (courseOperation == 3)
    {
        Console.WriteLine("Kurs Id'sini giriniz");
        int courseId = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Kurs adýný giriniz");
        string courseName = Console.ReadLine();

        Console.WriteLine("Kurs açýklamasýný giriniz");
        string courseDesription = Console.ReadLine();

        Console.WriteLine("Kurs resim yolunu giriniz");
        string courseImage = Console.ReadLine();

        Console.WriteLine("Kurs fiyatýný giriniz");
        double coursePrice = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Kurs kategori Id'sini giriniz");
        int courseCategoryId = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Kurs eðitmen Id'sini giriniz");
        int courseInstructorId = Convert.ToInt32(Console.ReadLine());

        Course newCourse = new Course
        {
            Id = courseId,
            Name = courseName,
            Description = courseDesription,
            Image = courseImage,
            Price = coursePrice,
            CategoryId = courseCategoryId,
            InstructorId = courseInstructorId
        };

        _courseManager.Add(newCourse);
    }
    // Update
    else if (courseOperation == 4)
    {
        Console.WriteLine("Güncellemek istediðiniz kursun Id'sini giriniz");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Yeni deðerleri giriniz");

        Console.WriteLine("Kurs Id'sini giriniz");
        int courseId = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Kurs adýný giriniz");
        string courseName = Console.ReadLine();

        Console.WriteLine("Kurs açýklamasýný giriniz");
        string courseDesription = Console.ReadLine();

        Console.WriteLine("Kurs resim yolunu giriniz");
        string courseImage = Console.ReadLine();

        Console.WriteLine("Kurs fiyatýný giriniz");
        double coursePrice = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Kurs kategori Id'sini giriniz");
        int courseCategoryId = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Kurs eðitmen Id'sini giriniz");
        int courseInstructorId = Convert.ToInt32(Console.ReadLine());

        Course updatedCourse = new Course
        {
            Id = courseId,
            Name = courseName,
            Description = courseDesription,
            Image = courseImage,
            Price = coursePrice,
            CategoryId = courseCategoryId,
            InstructorId = courseInstructorId
        };

        _courseManager.Update(updatedCourse);
    }
    // Delete
    else if (courseOperation == 5)
    {
        Console.WriteLine("Silmek istediðiniz kursun Id'sini giriniz");
        int id = Convert.ToInt32(Console.ReadLine());

        _courseManager.Delete(id);
    }
    else
    {
        Console.WriteLine("Geçersiz bir deðer girdiniz");
    }
}
// Category
else if (operation == 2)
{
    Console.WriteLine("1 - Listele\n2 - Id'ye göre listele\n3 - Ekle\n4 - Güncelle\n5 - Sil");
    int categoryOperation = Convert.ToInt32(Console.ReadLine());
    // Get all
    if (categoryOperation == 1)
    {
        var categories = _categoryManager.GetAll();
        foreach (var category in categories)
        {
            Console.WriteLine(category.Name);
        }
    }
    // Get by id
    else if (categoryOperation == 2)
    {
        Console.WriteLine("Görüntülemek istediðiniz kategorinin Id'sini giriniz");
        int categoryId = Convert.ToInt32(Console.ReadLine());

        var category = _categoryManager.GetById(categoryId);
        Console.WriteLine(category.Name);
    }
    // Add
    else if (categoryOperation == 3)
    {
        Console.WriteLine("Kategori Id'sini giriniz");
        int categoryId = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Kategori adýný giriniz");
        string categoryName = Console.ReadLine();

        Category newCategory = new Category
        {
            Id = categoryId,
            Name = categoryName
        };

        _categoryManager.Add(newCategory);
    }
    // Update
    else if (categoryOperation == 4)
    {
        Console.WriteLine("Güncellemek istediðiniz kategorinin Id'sini giriniz");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Yeni deðerleri giriniz");

        Console.WriteLine("Kategori Id'sini giriniz");
        int categoryId = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Kategori adýný giriniz");
        string categoryName = Console.ReadLine();

        Category updatedCategory = new Category
        {
            Id = categoryId,
            Name = categoryName
        };

        _categoryManager.Update(updatedCategory);
    }
    // Delete
    else if (categoryOperation == 5)
    {
        Console.WriteLine("Silmek istediðiniz kategorinin Id'sini giriniz");
        int id = Convert.ToInt32(Console.ReadLine());

        _categoryManager.Delete(id);
    }
    else
    {
        Console.WriteLine("Geçersiz bir deðer girdiniz");
    }
}
//Instructor
else if (operation == 3)
{
    Console.WriteLine("1 - Listele\n2 - Id'ye göre listele\n3 - Ekle\n4 - Güncelle\n5 - Sil");
    int instructorOperation = Convert.ToInt32(Console.ReadLine());
    // Get all
    if (instructorOperation == 1)
    {
        var instructors = _instructorManager.GetAll();
        foreach (var instructor in instructors)
        {
            Console.WriteLine(instructor.FirstName + " " + instructor.LastName);
        }
    }
    // Get by id
    else if (instructorOperation == 2)
    {
        Console.WriteLine("Görüntülemek istediðiniz eðitmenin Id'sini giriniz");
        int instructorId = Convert.ToInt32(Console.ReadLine());

        var instructor = _instructorManager.GetById(instructorId);
        Console.WriteLine(instructor.FirstName + " " + instructor.LastName);
    }
    // Add
    else if (instructorOperation == 3)
    {
        Console.WriteLine("Eðitmenin Id'sini giriniz");
        int instructorId = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Eðitmen adýný giriniz");
        string instructorFirstName = Console.ReadLine();

        Console.WriteLine("Eðitmen soyadýný giriniz");
        string instructorLastName = Console.ReadLine();

        Console.WriteLine("Eðitmen resim yolunu giriniz");
        string instructorImage = Console.ReadLine();

        Console.WriteLine("Eðitmen açýklamasýný giriniz");
        string instructorDescription = Console.ReadLine();

        Instructor newInstructor = new Instructor
        {
            Id = instructorId,
            FirstName = instructorFirstName,
            LastName = instructorLastName,
            Image = instructorImage,
            Description = instructorDescription
        };

        _instructorManager.Add(newInstructor);
    }
    // Update
    else if (instructorOperation == 4)
    {
        Console.WriteLine("Güncellemek istediðiniz eðitmenin Id'sini giriniz");
        int id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Yeni deðerleri giriniz");

        Console.WriteLine("Eðitmenin Id'sini giriniz");
        int instructorId = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Eðitmen adýný giriniz");
        string instructorFirstName = Console.ReadLine();

        Console.WriteLine("Eðitmen soyadýný giriniz");
        string instructorLastName = Console.ReadLine();

        Console.WriteLine("Eðitmen resim yolunu giriniz");
        string instructorImage = Console.ReadLine();

        Console.WriteLine("Eðitmen açýklamasýný giriniz");
        string instructorDescription = Console.ReadLine();

        Instructor newInstructor = new Instructor
        {
            Id = instructorId,
            FirstName = instructorFirstName,
            LastName = instructorLastName,
            Image = instructorImage,
            Description = instructorDescription
        };

        _instructorManager.Update(newInstructor);
    }
    // Delete
    else if (instructorOperation == 5)
    {
        Console.WriteLine("Silmek istediðiniz eðitmenin Id'sini giriniz");
        int id = Convert.ToInt32(Console.ReadLine());

        _instructorManager.Delete(id);
    }
    else
    {
        Console.WriteLine("Geçersiz bir deðer girdiniz");
    }
}
else
{
    Console.WriteLine("Geçersiz bir deðer girdiniz");
}