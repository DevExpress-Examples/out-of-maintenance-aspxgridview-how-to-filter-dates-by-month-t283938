using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;


public static class NumberMonthConverter {
    static private List<Pair> Months = new List<Pair>() {
        new Pair("January", 1), 
        new Pair("Feburary", 2),
        new Pair("March", 3),
        new Pair("April", 4),
        new Pair("May", 5),
        new Pair("June", 6),
        new Pair("July", 7),
        new Pair("August", 8),
        new Pair("September", 9),
        new Pair("October", 10),
        new Pair("November", 11),
        new Pair("December", 12) 
    };
    public static string GetTitleOfMonth(int numberOfMonth) {
        for (int i = 0; i < Months.Count; i++)
            if (numberOfMonth == Convert.ToInt32(Months[i].Second))
                return Months[i].First.ToString();
        return string.Empty;
    }
}