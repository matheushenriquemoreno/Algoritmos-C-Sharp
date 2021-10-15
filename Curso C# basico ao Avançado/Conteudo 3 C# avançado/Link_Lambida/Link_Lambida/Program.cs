using System;
using System.Collections.Generic;
using System.Linq;
using Link_Lambida.Entities;

namespace Link_Lambida
{
    class Program
    {
        static void Print<T>(string message, IEnumerable<T> objpassarparametro)
        {
            Console.WriteLine(message);
            foreach (T itens in objpassarparametro)
            {
                Console.WriteLine(itens);
            }
            Console.WriteLine();
        }

        static void Main(string[] args)
        {

            Category c1 = new Category() { Id = 1, Name = "Tools", Tier = 2 };
            Category c2 = new Category() { Id = 2, Name = "Computers", Tier = 1 };
            Category c3 = new Category() { Id = 3, Name = "Eletronics", Tier = 1 };

            List<Product> listProdutos = new List<Product>()
            {
                new Product() {Id = 1, Name = "Computer", Price = 1100.00, Category = c2},
                new Product() { Id = 2, Name = "Hammer", Price = 90.0, Category = c1},
                new Product() {Id = 3, Name = " TV", Price = 1700.00, Category = c3},
                new Product() {Id = 4, Name = "Notebook", Price = 1300.00, Category = c2},
                new Product() {Id = 5, Name = "Saw", Price = 80.0, Category = c1},
                new Product() {Id = 6, Name = "Tablet", Price = 700.0, Category = c2},
                new Product() {Id = 7, Name = "Camera", Price = 700.0, Category = c3},
                new Product() {Id = 8, Name = "Printer", Price = 350.0, Category = c3},
                new Product() {Id = 9, Name = "MacBokk", Price = 1800.00, Category = c2},
                new Product() {Id = 10, Name = "Sound Bar", Price = 700.0, Category = c3},
                new Product() {Id = 11, Name = "Level", Price = 70.0, Category = c1},
                new Product() {Id = 11, Name = "key", Price = 35.0, Category = c1},
                new Product() {Id = 11, Name = "Notebook Gamer", Price = 4200.00, Category = c2},
                new Product() {Id = 11, Name = "Galazy s10", Price = 1950.00, Category = c3},
                new Product() {Id = 11, Name = "Kit sala completa", Price = 12880.00, Category = c3},
            };


            // video parte 1

            //var r1 = listProdutos.Where(p => p.Price < 900 && p.Category.Tier == 1); // pega os produtos menores que 900 do tier 1 

           
            var r1 = // aula de sintaxe similar ao SQL
                from p in listProdutos
                where p.Category.Tier == 1 && p.Price < 900
                select p;
            Print("TIER 1 AND PRICE < 900:", r1);



            //var r2 = listProdutos.Where(p => p.Category.Name == "Tools").Select(p => p.Name); // pega os produtos da categoria tools e mostra so o name 

            var r2 =
                from p in listProdutos
                where p.Category.Name == "Tools"
                select p.Name;

            Print("NAMES OF PRODUCTS FROM TOOLS", r2);

            //var r3 = listProdutos.Where(p => p.Name[0] == 'C').Select(p => new { p.Name, p.Price, CategoryName = p.Category.Name });

            var r3 =
                from p in listProdutos
                where p.Name[0] == 'C'
                select new
                {
                    p.Name,
                    p.Price,
                    CategoryName = p.Category.Name
                };

            Print("NAMES STARTED WITH 'C' AND ANONYMOUS OBJECT", r3);

            //var r4 = listProdutos.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);

            var r4 =
                from p in listProdutos
                where p.Category.Tier == 1
                orderby p.Name
                orderby p.Price
                select p;

            Print("TIER 1 ORDER BY PRICE THEN BY NAME", r4);

            //var r5 = r4.Skip(2).Take(4);

            var r5 =
                (from p in r4
                 select p).Skip(2).Take(4);

            Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", r5);

            var r6 = listProdutos.FirstOrDefault();
            Console.WriteLine("First or Default test 1:  " + r6 );

            var r7 = listProdutos.Where(p => p.Price > 3000.00).FirstOrDefault();
            Console.WriteLine("Firt or Default test 2: " + r7);
            Console.WriteLine();

            var r8 = listProdutos.Where(p => p.Id == 3).SingleOrDefault(); // utilizado pra consulta em banco de dados onde pode retornar 1 ou nenhum elemento
            Console.WriteLine("Single or Default test 1: " + r8);

            var r9 = listProdutos.Where(p => p.Id == 30).SingleOrDefault();
            Console.WriteLine("Single or Default test 2: " + r9);

            // video parte 2

            var r10 = listProdutos.Max(p => p.Price);
            Console.WriteLine("Max price: " + r10.ToString("F2"));

            var r11 = listProdutos.Min(p => p.Price);
            Console.WriteLine("Min price: " + r11.ToString("F2"));

            var r12 = listProdutos.Where(p => p.Category.Id == 2).Sum(p => p.Price);
            Console.WriteLine("Category 2 Sum prices: " + r12.ToString("F2"));

            var r13 = listProdutos.Where(p => p.Category.Id == 2).Average(p => p.Price);
            Console.WriteLine("Category 2 average prices: " + r13.ToString("F2"));

            var r14 = listProdutos.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
            Console.WriteLine("Category 5 average prices exepptions: " + r14);


            var r15 = listProdutos.Where(p => p.Category.Id == 2).Select(p => p.Price).Aggregate((x,y) => x+y);
            Console.WriteLine("Category 2 aggregate sum: " + r15);

            var r16 = listProdutos.Where(p => p.Category.Id == 5).Select(p => p.Price).Aggregate(0.0,(x, y) => x + y);
            Console.WriteLine("Category 5 aggregate sum exepptions:  " + r16);

            Console.WriteLine();
            var r17 = listProdutos.GroupBy(p => p.Category);
            foreach(IGrouping<Category, Product> group in r17)
            {
                Console.WriteLine("Category " + group.Key.Name + ":");
                foreach(Product p in group)
                {
                    Console.WriteLine(p);
                }
                Console.WriteLine();
            }

        }
    }
}
