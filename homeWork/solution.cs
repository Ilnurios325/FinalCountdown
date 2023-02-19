void ShowArray(string[] array){
     for (int i = 0; i < array.Length; i++)
      {
        Console.WriteLine(array[i]+"");
      }
      Console.WriteLine();
    }
     string[] finalArray = {"hello", "2222", "world", "555"};
   
    string[] emptyArray = new string [4];
    
    for (int i=0; i<finalArray.Length; i++)
    {
      if(finalArray[i].Length <=3)
      {
        
        Console.WriteLine(finalArray[i]+", ");
      }
      
      if(finalArray[0].Length > 3 && finalArray[1].Length > 3 && finalArray[2].Length > 3 && finalArray[3].Length > 3)
      
        Console.Write($"/ no results /"); 
      
    }
     
    ShowArray(emptyArray);

