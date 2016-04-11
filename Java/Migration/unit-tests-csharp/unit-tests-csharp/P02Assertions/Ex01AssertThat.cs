﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Constraints;

namespace unit_tests_csharp.P02Assertions
{
  class Ex01AssertThat
  {
    [Test]
    public void ShouldBeAdult1()
    {
      //GIVEN
      var person = new Person();
      
      //WHEN
      person.Age = 18;

      //THEN
      Assert.That(person.Age, Is.GreaterThanOrEqualTo(18));
    }

    [Test]
    public void ShouldBeAdultUsingExtensionPoints()
    {
      //GIVEN
      var person = new Person();

      //WHEN
      person.Age = 18; //TODO change to 17

      //THEN
      Assert.That(person, IsAdult());
    }

    private static IResolveConstraint IsAdult()
    {
      return new AdultConstraint();
    }
  }

  public class Person
  {
    public int Age { get; set; }
  }


  public class AdultConstraint : Constraint
  {
    public override bool Matches(object other)
    {
      var age = ((Person)other).Age;
      actual = age;
      return age >= 18;
    }

    public override void WriteDescriptionTo(MessageWriter writer)
    {
      writer.WriteExpectedValue("an adult person at the age of at least 18");
    }
  }

}
