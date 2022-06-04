using System;
using System.IO;

namespace Project_Number_3
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // Правия инстанция от StereamReader зада прочета съответния файл 
            StreamReader reader = new StreamReader("Clients.txt");

            //Прочитам първия ред от текстовия файл
            string line = reader.ReadLine();

            //Прочитам останалите редове от текстовия файл
            while (line != null)
            {
                Console.WriteLine(line);
                line = reader.ReadLine();
            }
            reader.Close();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("The price for 1kg peppers is: ");
            Console.WriteLine("Wholesale: "+2);
            Console.WriteLine("Retailprice:"+3);

            Console.WriteLine();
            Console.WriteLine("The price for 1kg cucumbers is: ");
            Console.WriteLine("Wholesale: " + 1.5);
            Console.WriteLine("Retailprice:" + 2.5);

            Console.WriteLine();
            Console.WriteLine("The price for 1kg cabbage is: ");
            Console.WriteLine("Wholesale: " +1 );
            Console.WriteLine("Retailprice:" +2 );

            Console.WriteLine();
            Console.WriteLine("The price for 1kg potatoes is: ");
            Console.WriteLine("Wholesale: " + 0.50);
            Console.WriteLine("Retailprice:" + 1);

            Console.WriteLine();
            Console.WriteLine("The price for 1kg toamtoes is: ");
            Console.WriteLine("Wholesale: " +0.80);
            Console.WriteLine("Retailprice:" +2);

            Console.WriteLine();
            Console.WriteLine("The price for 1kg apples is: ");
            Console.WriteLine("Wholesale: " +1 );
            Console.WriteLine("Retailprice:" +3 );

            Console.WriteLine();
            Console.WriteLine("The price for 1kg oranges is: ");
            Console.WriteLine("Wholesale: " +3);
            Console.WriteLine("Retailprice:" +5);

            Console.WriteLine();
            Console.WriteLine("The price for 1kg bananas is: ");
            Console.WriteLine("Wholesale: " +1.80);
            Console.WriteLine("Retailprice:" + 2.20);

            Console.WriteLine();
            Console.WriteLine("The price for 1kg cheries is: ");
            Console.WriteLine("Wholesale: " +15 );
            Console.WriteLine("Retailprice:" + 35);

            Console.WriteLine();
            Console.WriteLine("The price for 1kg plums is: ");
            Console.WriteLine("Wholesale: " +0.50 );
            Console.WriteLine("Retailprice:" + 1);

            Console.WriteLine((20 * 15) + (1 * 2)); 
            //Client 1
            Console.WriteLine();
            Console.WriteLine("Enter a number of product that Client_1 bought");
            int ClientCount_1=int.Parse(Console.ReadLine());
            
            for (int i=0;i < ClientCount_1; i++) 
            { 
                
                Console.WriteLine("Enter the name of product and quantity in kg");
                Fruits Client_1_John = new Fruits(Console.ReadLine(), double.Parse(Console.ReadLine()));
                Console.WriteLine();
            }

            //Client 2
            Console.WriteLine();
            Console.WriteLine("Enter a number of product that Client_2 bought");
            int ClientCount_2 = int.Parse(Console.ReadLine());

            for (int i = 0; i < ClientCount_2; i++)
            {

                Console.WriteLine("Enter the name of product and quantity in kg");
                Fruits Client_2_Carl = new Fruits(Console.ReadLine(), double.Parse(Console.ReadLine()));
                Console.WriteLine();
            }
            

            //Client 3
            Console.WriteLine();
            Console.WriteLine("Enter a number of product that Client_3 bought");
            int ClientCount_3 = int.Parse(Console.ReadLine());

            for (int i = 0; i < ClientCount_3; i++)
            {

                Console.WriteLine("Enter the name of product and quantity in kg");
                Fruits Client_3_Ana = new Fruits(Console.ReadLine(), double.Parse(Console.ReadLine()));
                Console.WriteLine();
            }

            //Client 4
            Console.WriteLine();
            Console.WriteLine("Enter a number of product that Client_4 bought");
            int ClientCount_4 = int.Parse(Console.ReadLine());

            for (int i = 0; i < ClientCount_4; i++)
            {

                Console.WriteLine("Enter the name of product and quantity in kg");
                Fruits Client_4_Mike = new Fruits(Console.ReadLine(), double.Parse(Console.ReadLine()));
                Console.WriteLine();
            }

            //Client 5
            Console.WriteLine();
            Console.WriteLine("Enter a number of product that Client_5 bought");
            int ClientCount_5 = int.Parse(Console.ReadLine());

            for (int i = 0; i < ClientCount_5; i++)
            {

                Console.WriteLine("Enter the name of product and quantity in kg");
                Fruits Client_05_Aj = new Fruits(Console.ReadLine(), double.Parse(Console.ReadLine()));
                Console.WriteLine();
            }

            //Client 6
            Console.WriteLine();
            Console.WriteLine("Enter a number of product that Client_6 bought");
            int ClientCount_6 = int.Parse(Console.ReadLine());

            for (int i = 0; i < ClientCount_6; i++)
            {

                Console.WriteLine("Enter the name of product and quantity in kg");
                Fruits Client_06_Shop_1 = new Fruits(Console.ReadLine(), double.Parse(Console.ReadLine()));
                Console.WriteLine();
            }

            //Client 7
            Console.WriteLine();
            Console.WriteLine("Enter a number of product that Client_7 bought");
            int ClientCount_7 = int.Parse(Console.ReadLine());

            for (int i = 0; i < ClientCount_7; i++)
            {

                Console.WriteLine("Enter the name of product and quantity in kg");
                Fruits Client_07_Shop_2 = new Fruits(Console.ReadLine(), double.Parse(Console.ReadLine()));
                Console.WriteLine();
            }

            //Client 8
            Console.WriteLine();
            Console.WriteLine("Enter a number of product that Client_8 bought");
            int ClientCount_8 = int.Parse(Console.ReadLine());

            for (int i = 0; i < ClientCount_8; i++)
            {

                Console.WriteLine("Enter the name of product and quantity in kg");
                Fruits Client_08_Restutant = new Fruits(Console.ReadLine(), double.Parse(Console.ReadLine()));
                Console.WriteLine();
            }

            //Client 9
            Console.WriteLine();
            Console.WriteLine("Enter a number of product that Client_9 bought");
            int ClientCount_9 = int.Parse(Console.ReadLine());

            for (int i = 0; i < ClientCount_9; i++)
            {

                Console.WriteLine("Enter the name of product and quantity in kg");
                Fruits Client_09_Retail_Customer_1 = new Fruits(Console.ReadLine(), double.Parse(Console.ReadLine()));
                Console.WriteLine();
            }

            //Client 10
            Console.WriteLine();
            Console.WriteLine("Enter a number of product that Client_10 bought");
            int ClientCount_10 = int.Parse(Console.ReadLine());

            for (int i = 0; i < ClientCount_10; i++)
            {

                Console.WriteLine("Enter the name of product and quantity in kg");
                Fruits Client_10_Retail_Customer_2 = new Fruits(Console.ReadLine(), double.Parse(Console.ReadLine()));
                Console.WriteLine();
            }
            // Create a StreamWriter instance
            StreamWriter writer = new StreamWriter("Bills.txt");
            // Ensure the writer will be closed when no longer used
            using (writer)
            {
                writer.WriteLine("Client_01:_John---20kg Cheries and 1kg apples and the total price is "+((20 * 15)+(1*2))+"лв.");
                writer.WriteLine("Client_02: _Carl---30kg Bananas the total price is " + ((30*1.80))+"лв.");
                writer.WriteLine("Client_03:_Ana---40kg Tomatoes and 40kg Cucumbers the total price is " + ((40*0.80)+(40*1.50))+"лв.");
                writer.WriteLine("Client_04:_Mike---20kg Cabbage and 20.500 Potatoes the total price is " + ((20*1)+(20.500*0.5))+"лв");
                writer.WriteLine("Client_05:_AJ---30.300kg Cucumbers,30.500 Tomatoes and 2kg Peppers the total price is " + ((30.300*0.50)+(2*3))+"лв.");
                writer.WriteLine("Client_06: Enterprise_01: Shop_1---50kg Pepers and 60kg Tomatoes the total price is" + ((50*2)+(60*0.80))+"лв.");
                writer.WriteLine("Client_07: Enterprise_02: Shop_2---60kg Cabbage and 70kg Cucumbers the total price is " + ((60*1)+(70*0.80))+"лв.");
                writer.WriteLine("Client_08:Enterprise_03: Resturant 10kg Pepers ,10kg Cucumbers,10kg Tomatoes,10kg Cabbage,10kg Potatoes,20 kg Bananas the total price is " + (((10*2)+(10*1.5)+(10*0.80)+(10*1)+(10*0.50)+(20*1.80)))+"лв.");
                writer.WriteLine("Client_09: Retail_Customer_1---1kg Plums the total price is " + (1*1)+"лв.");
                writer.WriteLine("Client_10: Retail_Customer_2---2kg Oranges the total price is " + (2*5)+"лв.");
            }

        }
    }
}
