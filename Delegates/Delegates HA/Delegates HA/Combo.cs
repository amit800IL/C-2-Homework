using System;
using System.Collections.Generic;
using System.Windows.Controls;

class Combo
{
    ComboBox comboBox;

    public ComboBox ComboBox { get => comboBox; set => comboBox = value; }

   

    Dictionary<int, Func<int, int, int>> keyValuePairs = new Dictionary<int, Func<int, int, int>>();

    List<Func<int, int, int>> funcs = new List<Func<int, int, int>>()
    {
      
        

    };


    public void UsingComboBox()
    {
        

    }
}



