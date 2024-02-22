using Business.Concrete;
using Entities.Concrete;

Person person1 = new Person();
person1.FirstName = "ÖMER";
person1.LastName = "BİLGEN";
person1.DateOfBirthYear = 2001;
person1.NationalIdentity = 12345678901;

PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);