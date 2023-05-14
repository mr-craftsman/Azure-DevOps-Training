using SQL04codeFirst;




using (var db = new AppDBcontext())
{
    Coach newCoach = new Coach()
    {
        Name = "Alain Robet",
        DateOfEmployee = new DateTime(2000, 12, 20)
    };
}
