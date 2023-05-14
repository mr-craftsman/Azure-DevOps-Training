using SQL02Repos;


PersonsRepo personsRepository = new PersonsRepo();

Person[] people = personsRepository.GetPersons();



foreach (var p in people)
{
    Console.WriteLine(p.FirstName + " " + p.LastName);
}


personsRepository.TestingMethod(1,2,3);
personsRepository.TestingMethod2(new int[3] { 1, 2, 3 });
personsRepository.TestingMethod3(new int[3] { 1, 2, 3 });