using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Number_3
{
     class Vegetables
     {
        private string vName;
        private double vQuantity;
        private double vWholesalePrice;
        private double vRetailPrice;

        //public void vValue() 
        //{
        //   vName= Console.ReadLine();
        //   vQuantity= double.Parse(Console.ReadLine());
        //   vWholesalePrice= double.Parse(Console.ReadLine());  
        //   vRetailPrice= double.Parse(Console.ReadLine());

        //}
        public Vegetables(string vName, double vQuantity)
        {
            this.vName = vName;
            this.vQuantity = vQuantity;
            
        }
        //public Vegetables(string vName, double vQuantity, double vWholesalePrice, double vRetailPrice)
        //{
        //    this.vName = vName;
        //    this.vQuantity = vQuantity;
        //    this.vWholesalePrice = vWholesalePrice;
        //    this.vRetailPrice = vRetailPrice;
        //}
        
     }
}
