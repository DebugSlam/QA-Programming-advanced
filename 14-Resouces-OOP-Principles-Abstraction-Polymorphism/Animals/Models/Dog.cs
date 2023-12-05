﻿using System.Xml.Linq;
using Animals.Models;

internal class Dog : Animal
{

    public Dog(string name, string favoriteFood) : base(name, favoriteFood)
    {
    }

    public override string ExplainSelf()
    {
        return base.ExplainSelf() + "\nBORK";
    }
}