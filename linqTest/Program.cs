using System;
using System.Collections.Generic;
using System.Linq;
namespace linqTest
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> stringList = new[] { "bc", "sd", "ac", "sdf", "ewr" };
            IEnumerable<string> stringListResult = Task10(stringList);

            stringList = new[] { "du", "the", "ace", "run", "cut" };
            stringListResult = Task10(stringList);
            
            stringList = new[] { "ab", "attribute", "cheese", "swim", "cut" };
            stringListResult = Task10(stringList);
            
            stringList = new[] { "star", "galaxy", "quasar", "planet", "asteroid", "satellite", "comet" };
            stringListResult = Task10(stringList);

            stringList = new[] { "YELLOW", "GREEN", "YIELD" };
            stringListResult = Task9(stringList);

            IEnumerable<Supplier> supplierList = new[]
            {
                            new Supplier(1,2000,"adress 1"),
                            new Supplier(2,1961,"adress 2"),
                            new Supplier(3,1984,"adress 3"),
                            new Supplier(4,1997,"adress 4"),
                            new Supplier(5,1990,"adress 5"),
                        };

            IEnumerable<SupplierDiscount> supplierDiscountList = new[]
                        {
                            new SupplierDiscount{Discount = 5.0, ShopName = "shop1", SupplierId = 1},
                            new SupplierDiscount{Discount = 1.0, ShopName = "shop2", SupplierId = 1},
                            new SupplierDiscount{Discount = 2.0, ShopName = "shop3", SupplierId = 1},
                            new SupplierDiscount{Discount = 4.0, ShopName = "shop4", SupplierId = 1},
                            new SupplierDiscount{Discount = 6.0, ShopName = "shop6", SupplierId = 1},
                            new SupplierDiscount{Discount = 34.0, ShopName = "shop2", SupplierId = 2},
                            new SupplierDiscount{Discount = 10.0, ShopName = "shop5", SupplierId = 2},
                            new SupplierDiscount{Discount = 7.0, ShopName = "shop5", SupplierId = 3},
                            new SupplierDiscount{Discount = 9.0, ShopName = "shop3", SupplierId = 3},
                            new SupplierDiscount{Discount = 32.0, ShopName = "shop5", SupplierId = 3},
                            new SupplierDiscount{Discount = 7.2, ShopName = "shop4", SupplierId = 4},
                            new SupplierDiscount{Discount = 34.0, ShopName = "shop2", SupplierId = 4},
                            new SupplierDiscount{Discount = 6.0, ShopName = "shop3", SupplierId = 4},
                            new SupplierDiscount{Discount = 7.0, ShopName = "shop5", SupplierId = 4},
                            new SupplierDiscount{Discount = 1.5, ShopName = "shop6", SupplierId = 5}
                        };
            Task14(supplierList, supplierDiscountList);


            IEnumerable<Good> goodList = new[]
            {
                            new Good { Id = 1, Country = "Ukraine", Category = "Food" },
                            new Good { Id = 2, Country = "Ukraine", Category = "Food" },
                            new Good { Id = 3, Country = "Ukraine", Category = "Food" },
                            new Good { Id = 4, Country = "Ukraine", Category = "Food" },
                            new Good { Id = 5, Country = "Germany", Category = "Food" },
                            new Good { Id = 6, Country = "Germany", Category = "Food" },
                            new Good { Id = 7, Country = "Germany", Category = "Food" },
                            new Good { Id = 8, Country = "Germany", Category = "Food" },
                            new Good { Id = 9, Country = "Greece", Category = "Food" },
                            new Good { Id = 10, Country = "Greece", Category = "Food" },
                            new Good { Id = 11, Country = "Greece", Category = "Food" },
                            new Good { Id = 12, Country = "Italy", Category = "Food" },
                            new Good { Id = 13, Country = "Italy", Category = "Food" },
                            new Good { Id = 14, Country = "Italy", Category = "Food" },
                            new Good { Id = 15, Country = "Slovenia", Category = "Food" }

            };

            IEnumerable<StorePrice> storePriceList = new[]
            {
                     new StorePrice { GoodId = 1, Price = 1.25M, Shop = "shop1" },
                    new StorePrice { GoodId = 3, Price = 2.25M, Shop = "shop1" },
                    new StorePrice { GoodId = 5, Price = 4.25M, Shop = "shop1" },
                    new StorePrice { GoodId = 7, Price = 9.25M, Shop = "shop1" },
                    new StorePrice { GoodId = 9, Price = 11.25M, Shop = "shop1" },
                    new StorePrice { GoodId = 11, Price = 12.25M, Shop = "shop1" },
                    new StorePrice { GoodId = 13, Price = 13.25M, Shop = "shop1" },
                    new StorePrice { GoodId = 14, Price = 14.25M, Shop = "shop1" },
                    new StorePrice { GoodId = 5, Price = 11.25M, Shop = "shop2" },
                    new StorePrice { GoodId = 4, Price = 16.25M, Shop = "shop2" },
                    new StorePrice { GoodId = 3, Price = 18.25M, Shop = "shop2" },
                    new StorePrice { GoodId = 2, Price = 11.25M, Shop = "shop2" },
                    new StorePrice { GoodId = 1, Price = 1.50M, Shop = "shop2" },
                    new StorePrice { GoodId = 3, Price = 4.25M, Shop = "shop3" },
                    new StorePrice { GoodId = 7, Price = 3.25M, Shop = "shop3" },
                    new StorePrice { GoodId = 10, Price = 13.25M, Shop = "shop3" },
                    new StorePrice { GoodId = 14, Price = 14.25M, Shop = "shop3" },
                    new StorePrice { GoodId = 3, Price = 11.25M, Shop = "shop4" },
                    new StorePrice { GoodId = 2, Price = 14.25M, Shop = "shop4" },
                    new StorePrice { GoodId = 12, Price = 2.25M, Shop = "shop4" },
                    new StorePrice { GoodId = 6, Price = 5.25M, Shop = "shop4" },
                    new StorePrice { GoodId = 8, Price = 6.25M, Shop = "shop4" },
                    new StorePrice { GoodId = 10, Price = 11.25M, Shop = "shop4" },
                    new StorePrice { GoodId = 4, Price = 15.25M, Shop = "shop5" },
                    new StorePrice { GoodId = 7, Price = 18.25M, Shop = "shop5" },
                    new StorePrice { GoodId = 8, Price = 13.25M, Shop = "shop5" },
                    new StorePrice { GoodId = 12, Price = 14.25M, Shop = "shop5" },
                    new StorePrice { GoodId = 1, Price = 3.25M, Shop = "shop6" },
                    new StorePrice { GoodId = 3, Price = 2.25M, Shop = "shop6" },
                    new StorePrice { GoodId = 1, Price = 1.20M, Shop = "shop7" }
            };

            Task15(goodList, storePriceList);

        }




        public static IEnumerable<string> Task10(IEnumerable<string> stringList)
        {
            IEnumerable<string> s = stringList.OrderBy(x => x).GroupBy(x => x.Length).Select(x=>x.Select(y=>y.Substring(y.Length - 1, 1).ToUpper())).Select(x => string.Join("", x.ToArray()));

            //IEnumerable<string> s1 = stringList.OrderBy(x => x).GroupBy(x => x.Length).Select(y=>(key: y.Key, letter: y.Select)))

            return s;
        }

        public static IEnumerable<string> Task9(IEnumerable<string> stringList)
        {
            var s = stringList.GroupBy(x => x.First());
            var s2 = s.Select(y => (sum: y.Sum(z => z.Length), letter: y.Key));
            //.OrderByDescending(a => a.sum).ThenBy(b => b.letter).Select(y => $"{y.sum}-{y.letter}");
            IEnumerable<string> s1 = stringList.GroupBy(x => x.First()).Select(y => (sum: y.Sum(z => z.Length), letter: y.Key)).OrderByDescending(a => a.sum).ThenBy(b => b.letter).Select(y => $"{y.sum}-{y.letter}");
            return s1;
        }

        public static void Task14(IEnumerable<Supplier> supplierList,
                IEnumerable<SupplierDiscount> supplierDiscountList)
        {
            var s =  supplierList.Join(supplierDiscountList, supp => supp.Id, dis => dis.SupplierId,

                        (supp, dis) => new       //  resultSelector
                        {
                            Suppliers = supp.Id,
                            Customers = new Supplier(supp.Id, supp.YearOfBirth, supp.Adress),
                            ShopName = dis.ShopName,
                            Discounts = dis.Discount
                        }).OrderBy(x=>x.Suppliers).GroupBy(x=>x.ShopName).
                        Select(x=>x.Select(y=>y).OrderByDescending(c=>c.Discounts).ThenBy(c=>c.Suppliers).First()).
                        Select(u=> new MaxDiscountOwner(u.ShopName, u.Discounts, u.Customers) ).OrderBy(x=>x.ShopName);


        }
        public static void Task15(IEnumerable<Good> goodList, IEnumerable<StorePrice> storePriceList)
        {
            var s = goodList.GroupJoin(storePriceList, goods => goods.Id, stores => stores.GoodId,
                                    (goods, st) => new
                                    {
                                        goodId = goods.Id,
                                        country = goods.Country,
                                        price = st.DefaultIfEmpty(new StorePrice()).Select(x => x.Price).Min(),
                                        shops = st.DefaultIfEmpty(new StorePrice()).Select(x => x.Shop)
                                    })
                .OrderBy(x => x.country).
            GroupBy(x => x.country).
            Select(x=> new { country = x.Key, price = x.Select(y=>y.price).Min(), shops = x.Select(y=>y.shops)})
            ;
            var s1 = goodList.GroupJoin(storePriceList, goods => goods.Id, stores => stores.GoodId,
                                    (goods, st) => new
                                    {
                                        goodId = goods.Id,
                                        country = goods.Country,
                                        price = st.DefaultIfEmpty(new StorePrice()).Select(x => x.Price).Min(),
                                        shops = st.DefaultIfEmpty(new StorePrice()).Select(x => x.Shop)
                                    })
                .OrderBy(x => x.country).
            GroupBy(x => x.country).
            Select(x => new { country = x.Key, price = x.Select(y => y.price).Min(), shops = x.Select(y => y.shops) })
            ;
            var query = (from goods in goodList
                         join shop in storePriceList on goods.Id equals shop.GoodId into gj
                         from subshop in gj.DefaultIfEmpty()
                         select new { goods.Country, price = subshop?.Price ?? 0, shop = subshop?.Shop ?? String.Empty })
                        .OrderBy(x => x.Country)
                        .GroupBy(x => x.Country)
                        .Select(x => new  { country = x.Key, price = x.Select(y => y.price).Min(), shop = x.Select(y => y.shop).Distinct().Where(z=>z.Length>0).Count() });
        }

        class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
        }

        class Pet
        {
            public string Name { get; set; }
            public Person Owner { get; set; }
        }

        public static void LeftOuterJoinExample()
        {
            Person magnus = new Person { FirstName = "Magnus", LastName = "Hedlund" };
            Person terry = new Person { FirstName = "Terry", LastName = "Adams" };
            Person charlotte = new Person { FirstName = "Charlotte", LastName = "Weiss" };
            Person arlene = new Person { FirstName = "Arlene", LastName = "Huff" };

            Pet barley = new Pet { Name = "Barley", Owner = terry };
            Pet boots = new Pet { Name = "Boots", Owner = terry };
            Pet whiskers = new Pet { Name = "Whiskers", Owner = charlotte };
            Pet bluemoon = new Pet { Name = "Blue Moon", Owner = terry };
            Pet daisy = new Pet { Name = "Daisy", Owner = magnus };

            // Create two lists.
            List<Person> people = new List<Person> { magnus, terry, charlotte, arlene };
            List<Pet> pets = new List<Pet> { barley, boots, whiskers, bluemoon, daisy };

            var query = from person in people
                        join pet in pets on person equals pet.Owner into gj
                        from subpet in gj.DefaultIfEmpty()
                        select new { person.FirstName, PetName = subpet?.Name ?? String.Empty };

            foreach (var v in query)
            {
                Console.WriteLine($"{v.FirstName + ":",-15}{v.PetName}");
            }
        }


        public class Supplier
        {
            public int Id { get; set; }
            public int YearOfBirth { get; set; }
            public string Adress { get; set; }

            public Supplier(int id, int year, string adr)
            {
                Id = id; YearOfBirth = year; Adress = adr;
            }
        }

        public class SupplierDiscount
        {
            public int SupplierId { get; set; }
            public string ShopName { get; set; }
            public double Discount { get; set; }
        }
        public class MaxDiscountOwner
        {
            public string ShopName { get; set; }
            public Supplier Owner { get; set; }
            public double Discount { get; set; }

            public MaxDiscountOwner(string name, double discount, Supplier supplier)
            {

                ShopName = name; Discount = discount; Owner = supplier;
            
            }
        }

        public class StorePrice
        {
            public int GoodId { get; set; }
            public string Shop { get; set; }
            public decimal Price { get; set; }


        }

        public class Good
        {
            public int Id { get; set; }
            public string Category { get; set; }
            public string Country { get; set; }
        }


    }
}
