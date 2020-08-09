using System;
using System.Collections.Generic;

namespace FifthOOP.Models 
{
class Buffet
{
    public List<IConsumable> Menu;
     
    
    public Buffet()
    {
        Menu = new List<IConsumable>()
        {
            new Food("food1", 500, false, true),
            new Food("food2", 600, true, false),
            new Food("food3", 720, false, true),
            new Food("food4", 530, true, false),
            new Food("food5", 540, false, true),
            new Drink("drink1", 200),
            new Drink("drink2", 300),
            new Drink("drink3", 400),
            new Drink("drink4", 300),
            new Drink("drink5", 200),
        };
    }
     
    public IConsumable Serve()
    {
        Random rand = new Random();
        int randFood = rand.Next(0,7);
        return Menu[randFood];
    }
}

}