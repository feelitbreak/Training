namespace RazorSyntaxSecondTry.Pages
{
    using Microsoft.AspNetCore.Mvc.RazorPages;

    public class PizzaModel : PageModel
    {
        public double Total { get; set; }

        public string Customer { get; set; }

        public string Order { get; set; }

        public bool ExtraCheese { get; set; }

        public double PizzaTotal(string pizzaType)
        {
            Dictionary<string, double> pizzaCost = new ()
            {
                { "Cheese", 10 },
                { "Pepperoni", 11 },
                { "Vegetarian", 12 },
            };

            return pizzaCost[pizzaType];
        }

        public void OnGet()
        {
            Customer = "Alexey";
            Order = "Cheese";
            ExtraCheese = false;
            Total = PizzaTotal("Cheese");
        }
    }
}
