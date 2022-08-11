using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Store_Boxes
{



    class Item
    {
        public Item()
        { 
        }
        public Item(string name,decimal price)
        {
            this.Name = name;
            this.Price = price; 
        }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    class Box
    {
        public Box()
        {
            Item = new Item(); 
        }
        public string SerialNumber { get; set; }
        public Item Item { get; set; }
        public int ItemQuantity { get; set; }
        public decimal priceForTheBox { get; set; }

    }


    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            List<Box> Boxes = new List<Box>();

            while (command!="end")
            {
                //"{Serial Number} {Item Name} {Item Quantity} {itemPrice}"
                string[] splitItemParameters = command.Split(' ',StringSplitOptions.RemoveEmptyEntries);

                string serialNumber = splitItemParameters[0];
                string itemName  = splitItemParameters[1];  
                int itemQuantity = int.Parse(splitItemParameters[2]);
                decimal itemPrice = decimal.Parse(splitItemParameters[3]);

                decimal priceForTheBox = itemPrice * itemQuantity;
                Item newItem = new Item(itemName, itemPrice);
                
                Box newBox = new Box();
                newBox.SerialNumber = serialNumber;
                newBox.Item = newItem;
                newBox.ItemQuantity=itemQuantity;
                newBox.priceForTheBox = newItem.Price * newBox.ItemQuantity;

                Boxes.Add(newBox);

                command = Console.ReadLine();
            }

            List<Box> orderedBoxes = Boxes.OrderByDescending(x=> x.priceForTheBox).ToList();

            foreach (Box box in orderedBoxes)
            {
                //{ boxSerialNumber}
                //-- { boxItemName} – ${ boxItemPrice}: { boxItemQuantity}
                //-- ${ boxPrice}

                Console.WriteLine($"{box.SerialNumber}");
                Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:f2}: {box.ItemQuantity}");
                Console.WriteLine($"-- ${box.priceForTheBox:f2}");
            }

        }
    }
}
