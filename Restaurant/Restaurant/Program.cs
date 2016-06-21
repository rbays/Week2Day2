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
            public static void cookMeal(Meal meal)
            {
                Console.WriteLine("The meal {0} has been cooked.", meal.name);
            }
        }
        public class Order
        {
            public void takeOrder(Meal meal)
            {
                Console.WriteLine("The meal {0} has been ordered.", meal.name);
            }
        }
        public class Accounts
        {
            public decimal balance = 0;
            public void updateBalance(Meal meal)
            {
                this.balance += (meal.price - meal.cost);
            }
            public void profitToday()
            {
                Console.WriteLine("Tonight the restaurant has made £{0}", this.balance.ToString());
            }
        }
        static void Main(string[] args)
        {
            Accounts account = new Accounts();
            //add some meals data
            Meal steak = new Meal();
            steak.addMeal("steak", 20.00M, 5.00M);
            Meal fajitas = new Meal();
            fajitas.addMeal("fajitas", 12.00M, 2.00M);
            Meal pumpkinRisotto = new Meal();
            pumpkinRisotto.addMeal("pumpkinRisotto", 10.00M, 1.00M);
            Order order1 = new Order();
            order1.takeOrder(steak);
            Meal.cookMeal(steak);
            account.updateBalance(steak);

            Order order2 = new Order();
            order2.takeOrder(pumpkinRisotto);
            Meal.cookMeal(pumpkinRisotto);
            account.updateBalance(pumpkinRisotto);
            account.profitToday();
        }
    }
}