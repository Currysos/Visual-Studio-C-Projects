using System;
using System.Collections.Generic;
using System.Text;

namespace Market
{
    public class Costumer
    {
        private string CostumerName = "name";
        private List<Product> Products = new List<Product>();

        public void SetName(string _Name) => CostumerName = _Name;

        public void AddProduct(string _ProductName, int _ProductCost)
        {
            Product CurrentProduct = new Product();

            CurrentProduct.SetName(_ProductName);
            CurrentProduct.SetCost(_ProductCost);

            Products.Add(CurrentProduct);

            Console.WriteLine("Product added");
            return;
        }

        public string GetName()
        {
            return CostumerName;
        }

        public List<Product> GetProducts()
        {
            return Products;
        }

        public void PrintProducts()
        {
            for (int i = 0; i < Products.Count; i++)
            {
                Console.WriteLine(":: Name: " + Products[i].GetName());
                Console.WriteLine("   Cost: " + Products[i].GetCost());
                Console.WriteLine("---------");
            }
            return;
        }
    }

    public class Product
    {
        private string ProductName;
        private int ProductCost;

        public void SetName(string _Name) => ProductName = _Name;

        public void SetCost(int _Cost) => ProductCost = _Cost;

        public string GetName()
        {
            return ProductName;
        }

        public int GetCost()
        {
            return ProductCost;
        }
    }
}