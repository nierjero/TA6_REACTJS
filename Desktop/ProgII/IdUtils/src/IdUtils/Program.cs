﻿using System;
using System.Linq;
using PosterObjectsClassesMessages;

namespace Ucu.Poo.Persons
{

  class Program 
    { 
        static void Main(string[] args) 
        { 
            Person john = new Person("John Doe", "1.234.567-8"); 
            Person jane = new Person("Jane Doe", "8.765.432-1"); 
            john.IntroduceYourself(); 
            jane.IntroduceYourself(); 
        } 
    } 
}