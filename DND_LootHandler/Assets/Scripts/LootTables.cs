using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;

public class LootTables : MonoBehaviour
{
    
    StreamReader table_File;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void File_Selection(string table)
    {
        string p1 = "Assets\\item_Tables\\Table_";
        string p2 = table.ToUpper();
        string p3 = ".csv";

        table_File = new StreamReader(Path.Combine(p1, p2, p3));
        table_File.ReadLine();
    }

    private void Tozenize_Table()
    {
        while(!table_File.EndOfStream) 
        {

        }
    }
}
