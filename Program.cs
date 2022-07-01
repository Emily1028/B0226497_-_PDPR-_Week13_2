using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B0226497_段昱如_PDPR__Week13_2
{
    class Program
    {
        struct Product1
        {
            public string NO, Name;
            public int Price, Amount;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("B0226497_段昱如_PDPR__Week13_2");
            Product1 product1, product2, product3, product4, product5;
            product1.NO = "B0226497_1";
            product1.Name = "段昱如_1";
            product1.Price = 1000;
            product1.Amount = 10;
            product2.NO = "B0226497_2";
            product2.Name = "段昱如_2";
            product2.Price = 2000;
            product2.Amount = 20;
            product3.NO = "B0226497_3";
            product3.Name = "段昱如_3";
            product3.Price = 3000;
            product3.Amount = 30;
            product4.NO = "B0226497_4";
            product4.Name = "段昱如_4";
            product4.Price = 4000;
            product4.Amount = 40;
            product5.NO = "B0226497_5";
            product5.Name = "段昱如_5";
            product5.Price = 5000;
            product5.Amount = 50;
            Console.WriteLine("產品1:" + $"編號:{product1.NO}\t品名:{product1.Name}\t單價:{product1.Price}\t數量:{product1.Amount}\t總價:{product1.Price * product1.Amount}");
            Console.WriteLine("產品2:" + $"編號:{product2.NO}\t品名:{product2.Name}\t單價:{product2.Price}\t數量:{product2.Amount}\t總價:{product2.Price * product2.Amount}");
            Console.WriteLine("產品3:" + $"編號:{product3.NO}\t品名:{product3.Name}\t單價:{product3.Price}\t數量:{product3.Amount}\t總價:{product3.Price * product3.Amount}");
            Console.WriteLine("產品4:" + $"編號:{product4.NO}\t品名:{product4.Name}\t單價:{product4.Price}\t數量:{product4.Amount}\t總價:{product4.Price * product4.Amount}");
            Console.WriteLine("產品5:" + $"編號:{product5.NO}\t品名:{product5.Name}\t單價:{product5.Price}\t數量:{product5.Amount}\t總價:{product5.Price * product5.Amount}");
            Console.WriteLine($"總價值:{product1.Price * product1.Amount+ product2.Price * product2.Amount+ product3.Price * product3.Amount+ product4.Price * product4.Amount+ product5.Price * product5.Amount}");
            Console.ReadLine();
        }
    }
}
