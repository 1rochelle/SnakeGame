using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeGameProject
{
    public enum FoodName { Bacon, CottonCandy, Person, Apple }
    public class Food
    {
        public FoodName FoodType { get; set; }
        public int PointValue { get; set; }
        public char FoodCharacter { get; set; }

        public int GetPointValue(FoodName foodName)
        {
            int pointValueOfFood;
            switch (foodName)
            {
                case FoodName.Apple:
                    pointValueOfFood = 10;
                    return pointValueOfFood;
                case FoodName.CottonCandy:
                    pointValueOfFood = 15;
                    return pointValueOfFood;
                case FoodName.Person:
                    pointValueOfFood = 25;
                    return pointValueOfFood;
                case FoodName.Bacon:
                    pointValueOfFood = 50;
                    return pointValueOfFood;
                default:
                    pointValueOfFood = 10;
                    return pointValueOfFood;
            }
                
        }
        public char GetFoodCharacter(FoodName foodName)
        {
            char characterValueOfFood;
            switch (foodName)
            {
                case FoodName.Apple:
                    characterValueOfFood = '@';
                    return characterValueOfFood;
                case FoodName.CottonCandy:
                    characterValueOfFood = '*';
                    return characterValueOfFood; 
                case FoodName.Person:
                    characterValueOfFood = '¥';
                    return characterValueOfFood;
                case FoodName.Bacon:
                    characterValueOfFood = '~';
                    return characterValueOfFood;
                default:
                    characterValueOfFood = '@';
                    return characterValueOfFood;
            }

        }
        public Food()
        {

        }
        public Food(FoodName foodName)
        {
            FoodType = foodName;
        }

        //public void Bacon { get; set; } // ~ range 91-100
        //public void CottonCandy { get; set; } // * 51-70
        //public void Person { get; set; } //¥ 71-90
        //public void Apple { get; set; } //@ range 1-50

        //public void Peppermint { get; set; } //decimal code 1422
        //public void Banana { get; set; } // (
        //public void Pea { get; set; } // .
        //public void Shrimp { get; set; } //decimal code 1351
        //public void Eel { get; set; } //1705
        //public void Sunshine { get; set; } //1758
        //public void Flower { get; set; } //1780
    }
}
