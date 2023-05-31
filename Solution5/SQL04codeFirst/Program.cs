using SQL04codeFirst;




using (var db = new AppDBcontext())
{
    Coach newCoach = new Coach()
    {
        Name = "Alain Robet",
        DateOfEmployee = new DateTime(2000, 12, 20),
        ExperienceDescription = "Very experienced",
        Heigth = 180.34,
    };
    db.Add(newCoach);
    db.SaveChanges();
}
