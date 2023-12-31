﻿using System;
namespace FarmOOPHierarchy.Animal.Mammal.Feline;

public abstract class Feline : Mammal
{
    public string Breed { get; set; }

    public Feline(string name, string weight, string livingRegion, string breed) : base(name, weight, livingRegion)
    {
        this.Breed = breed;
    }

    public override string ToString()
    {
        return $"{this.GetType().Name}[{this.Name}, {this.Breed}, {this.Weight}, " +
            $"{this.LivingRegion}, {this.FoodEaten}]";
    }
}

