using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;


namespace ProgrammingPractise
{
public class productPrice
{

    /*
     * Complete the 'findLowestPrice' function below.
     *
     * The function is expected to return an INTEGER.
     * The function accepts following parameters:
     *  1. 2D_STRING_ARRAY products
     *  2. 2D_STRING_ARRAY discounts
     */

    public int findLowestPrice(List<List<string>> products, List<List<string>> discounts)
    {
        int finalPrice=0; int productPrice=0;
        foreach(var product in products)
        {
            for(int i = 1;i<product.Count;i++)
            {
                int tempProductPrice = getPrice(Convert.ToInt32(product[0]),product[1],discounts);
                if(tempProductPrice < productPrice || productPrice == 0)
                productPrice = tempProductPrice;
            }
            finalPrice = finalPrice + productPrice;
        }
        return finalPrice;
    }
    public int getPrice(int price,string discount, List<List<string>> discounts)
    {
        int calculatedPrice =0;
        var selectedDiscounts = discounts.Where(x=> x[0].Equals(discount,StringComparison.InvariantCultureIgnoreCase)).FirstOrDefault();
       switch(selectedDiscounts?[1])
       {
        case "0":
        calculatedPrice = Convert.ToInt32(selectedDiscounts?[2]);
        break;
        case "1":
        var percent = (price*Convert.ToDouble(selectedDiscounts?[2]))/100;
        calculatedPrice = price - Convert.ToInt32(percent); 
        break;
        case "2":
        calculatedPrice = price - Convert.ToInt32(selectedDiscounts?[2]);
        break;
        case "EMPTY":
        break;
       }
       return calculatedPrice;
    }
}
}

