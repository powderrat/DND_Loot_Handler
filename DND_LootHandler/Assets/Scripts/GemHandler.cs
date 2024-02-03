using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
//Fully functional!

public class GemHandler : MonoBehaviour
{
    public List<string> gems;
    public List<string> final_Gems;
    public List<string> files_Data;




    void Start()
    {
        Copy_File();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    // based on the value on the table
    public List<string> Generate_Gems(int amount_Of_Gems,string gem_Value)
    {
        final_Gems.Clear();
        gems.Clear();
        string temp = null;
        string[] s;
      
        //s = files_Data.Split(',');
     
        foreach (string s2 in s)
        {
            
            if (s2 == gem_Value)
            {
                gems.Add(temp);
                 
            }
            temp = s2;
        }
        
        while(amount_Of_Gems > 0) 
        {
            final_Gems.Add(gems[Random.Range(0, gems.Count)]);
            amount_Of_Gems--;
        }
       
        return final_Gems;
    }

    private void Copy_File()
    {
        StreamReader gem_File = new StreamReader("Assets\\item_Tables\\Table_Gemstones.csv");
        gem_File.ReadLine();
        while (!gem_File.EndOfStream)
        {
            
              files_Data.Add(gem_File.ReadLine());
             

            Debug.Log(files_Data);
        }

        gem_File.Close();
    }




   
}
