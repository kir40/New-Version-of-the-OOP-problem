using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Number_3
{
    class Fruits
    {
        private string fName;
        private double fQuantity;
        private double fWholesalePrice;
        private double fRetailPrice;

        //public void fValue()
        //{
        //    fName = Console.ReadLine();
        //    fQuantity = double.Parse(Console.ReadLine());
        //    fWholesalePrice = double.Parse(Console.ReadLine());
        //    fRetailPrice = double.Parse(Console.ReadLine());
        //}
        public Fruits(string fName, double fQuantity)
        {
            this.fName = fName;
            this.fQuantity = fQuantity;
        }
        //public Fruits(string fName, double fQuantity, double fWholesalePrice, double fRetailPrice)
        //{
        //    this.fName = fName;
        //    this.fQuantity = fQuantity;
        //    this.fWholesalePrice = fWholesalePrice;
        //    this.fRetailPrice = fRetailPrice;
        //}
    }
}
