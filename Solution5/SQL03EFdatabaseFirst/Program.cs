﻿// See https://aka.ms/new-console-template for more information
using Microsoft.IdentityModel.Tokens;
using SQL03EFdatabaseFirst.Models;
using System;

Console.WriteLine("Hello, World!");


VolleyballDatabaseContext db = new VolleyballDatabaseContext();

// reading 
Person[] people = db.Persons.ToArray();

foreach (Person person in people)
    Console.WriteLine(person.FirstName + " " + person.LastName);

// ORM - map database into objects in our c# app 

// 1) EntityFramework 
// 2) LINQ-To-SQL - (obsolate) 
// 3) Hibnernate 

// creating 

//Person newPerson = new Person()
//{
//    FirstName = "Joe",
//    LastName = "Oli"
//};

//db.Persons.Add(newPerson);
//db.SaveChanges();


// update 

//Person toBeEdited = db.Persons.FirstOrDefault(x => x.Id == 8);
////Console.WriteLine(toBeEdited.FirstName);
//toBeEdited.FirstName = "editedName";
//db.SaveChanges();


// delete

using (var db2 = new VolleyballDatabaseContext())
{
    Person toBeDeleted = db.Persons.FirstOrDefault(x => x.Id == 8);
    db2.Persons.Remove(toBeDeleted);
    db2.SaveChanges();
}


