using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeControl
{
    public class Product // класс Товар
    {
        public string name;
        public int price;
        public string portion; // порция или какой-то другой атрибут
        public List<Material> materialsForProduct;

        public int posCount = 1;
        public int amountPrice = 0;

        public Product(string name, string portion, int price, 
            double coffee = 0, double milk = 0, int sugar = 0, int cream = 0, double chokolate = 0,  
            double syropCaramel1 = 0, double syropCocount1 = 0, 
            int cups = 1, int covers = 1, double spoon = 1)
        {

            this.name = name;
            this.price = price;

            this.materialsForProduct = new List<Material>();
            Material Milk = new Material();
            Milk = Milk.createMaterial("Молоко", milk, Material.Units.Л.ToString());
            Material Coffee = new Material();
            Coffee = Coffee.createMaterial("Кофе", coffee, Material.Units.Кг.ToString());
            Material Chocolate = new Material();
            Chocolate = Chocolate.createMaterial("Шоколад", chokolate, Material.Units.Кг.ToString());
            Material Cream = new Material();
            Cream = Cream.createMaterial("Сливки", cream, Material.Units.Л.ToString());
            Material SyropCaramel1 = new Material();
            SyropCaramel1 = SyropCaramel1.createMaterial("Сироп: карамель", syropCaramel1, Material.Units.Л.ToString(), null, "Сиропы");
            Material SyropCocount1 = new Material();
            SyropCocount1 = SyropCocount1.createMaterial("Сироп: кокос", syropCocount1, Material.Units.Л.ToString(), null, "Сиропы");
            Material Sugar = new Material();
            Sugar = Sugar.createMaterial("Сахар", sugar, Material.Units.Кг.ToString());

            if (portion != null)
            {
                this.name = this.name + " " + portion;
                this.portion = portion;
                Material Cup = new Material();
                Cup = Cup.createMaterial("Стакан", 1, Material.Units.Шт.ToString(), portion, "Стаканы");
                Material Cover = null;
                if (portion == "0.3")
                {
                    Cover = new Material();
                    Cover = Cover.createMaterial("Крышка", 1, Material.Units.Шт.ToString(), "70мм", "Крышки");
                }
                else if (portion == "0.4")
                {
                    Cover = new Material();
                    Cover = Cover.createMaterial("Крышка", 1, Material.Units.Шт.ToString(), "80мм", "Крышки");
                }
                else if (portion == "0.5")
                {
                    Cover = new Material();
                    Cover = Cover.createMaterial("Крышка", 1, Material.Units.Шт.ToString(), "90мм", "Крышки");
                }
                else
                {
                    Cover = new Material();
                    Cover = Cover.createMaterial("Крышка", 0, Material.Units.Шт.ToString(), "70мм", "Крышки");
                }

                Material Spoon = new Material();
                Spoon = Spoon.createMaterial("Ложки", spoon, Material.Units.Шт.ToString());

                this.materialsForProduct.Add(Cup);
                this.materialsForProduct.Add(Cover);
                this.materialsForProduct.Add(Spoon);
            }            

            this.materialsForProduct.Add(Coffee);
            this.materialsForProduct.Add(Chocolate);
            this.materialsForProduct.Add(Milk);
            this.materialsForProduct.Add(Cream);
            this.materialsForProduct.Add(Sugar);
            this.materialsForProduct.Add(SyropCaramel1);
            this.materialsForProduct.Add(SyropCocount1);            
        }
        
    }
}
