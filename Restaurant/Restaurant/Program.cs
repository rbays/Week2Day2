using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RestaurantEncapsulationExercise
{
    class Program
    {
        public class Meal
        {
            public string name;
            public decimal price;
            public decimal cost;
            public void addMeal(string name, decimal price, decimal cost)
            {
                this.name = name;
                this.price = price;
                this.cost = cost;
            }
            public static decimal cookMeal(Meal meal, decimal balance)
            {
                Console.WriteLine("The meal {0} has been cooked.", meal.name);
                balance = balance + meal.price;
                balance = balance - meal.cost;
                return balance;
            }
            public void takeOrder()
            {
                Console.WriteLine("The meal {0} has been ordered.", this.name);
            }
        }
       
        static void Main(string[] args)
        {
            decimal balance = 0;
            //add some meals data
            Meal steak = new Meal();
            steak.addMeal("steak", 20.00M, 5.00M);
            Meal fajitas = new Meal();
            fajitas.addMeal("fajitas", 12.00M, 2.00M);
            Meal pumpkinRisotto = new Meal();
            pumpkinRisotto.addMeal("pumpkinRisotto", 10.00M, 1.00M);
            steak.takeOrder();
            balance = Meal.cookMeal(steak, balance);
            pumpkinRisotto.takeOrder();
            balance = Meal.cookMeal(pumpkinRisotto, balance);
            Console.WriteLine("Tonight in the restaurant, we made £{0:N2}.", balance);
        }
    }
}