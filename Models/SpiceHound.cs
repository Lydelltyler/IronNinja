using System;
using System.Collections.Generic;

namespace FifthOOP.Models {

class SpiceHound : Ninja 
{
    public SpiceHound () {
        calorieIntake = 0;
        ConsumptionHistory = new List<IConsumable>();
    }
    public override bool IsFull {
            get {
                if (calorieIntake > 1200) {
                    Console.Write ($"SpicyHound Full! Calorie count: {calorieIntake}. I cannot eat anymore.\n");
                    Console.Write("----------------------------------------------------------------------\n");
                    return true;
                } else {
                    Console.Write ($"SpicyHound only had {calorieIntake} calories so far, I can keep eating\n");
                    return false;
                }
            }
        }
    public override void Consume (IConsumable item){
            calorieIntake += item.Calories;
            if (item.IsSpicy == true) 
            {
                string flavor = "spicy";
                Console.Write("----------------------------------------------------------------------\n");
                Console.Write ($"SpicyHound just consumed a {flavor} {item.Name} with {item.Calories} calories ;)\n");
                
                if (IsFull == false) 
                {
                    ConsumptionHistory.Add (item);
                    Console.WriteLine(item.GetInfo());
                }
            } 

            else if (item.IsSweet == true) 
            {
                string flavor = "sweet";
                Console.Write("----------------------------------------------------------------------\n");
                Console.Write ($"SpicyHound just consumed a {flavor} {item.Name} with {item.Calories} calories ;)\n");
                
                if (IsFull == false) 
                {
                    ConsumptionHistory.Add (item);
                    Console.WriteLine(item.GetInfo());
                    calorieIntake -= 5;
                }
            } 

            else 
            {
                Console.Write ($"Nothing to consume here\n");
            }
        }
}

}