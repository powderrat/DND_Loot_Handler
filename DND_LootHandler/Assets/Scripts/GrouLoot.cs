using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class GrouLoot : MonoBehaviour
{
    public TMP_Text magic_Items_Lable; public TMP_Text gemstone_Lable;
    public TMP_Text magic_Items_Text;  public TMP_Text gemstone_Text;
    public GemHandler gem_Handler;     public List<string> gemstones;
    public List<TMP_InputField> input_List; public GameObject Menu_2;
    private string table;

    //sends the roll to the proper loot table
    public void Hoard_Loot(int level, int roll)
    {
        show_All();
        this.gameObject.SetActive(true);
        
        if (level == 0) { Hoard_0(roll); }
    }

    private void Hoard_0(int roll)
    { //rewards loot based on table page 137 DM Guide
        switch (roll)
        {
            case <= 6:
                Hide_Gemstones();
                Hide_Magic_Items();
                break;

            case <= 16:
                Hide_Magic_Items();
                Update_Gemstones(gemstones = gem_Handler.Generate_Gems(Random.Range(2, 12), "10"));
                break;

            case <= 26:
                Hide_Magic_Items();
                Update_Gemstones(gemstones = gem_Handler.Generate_Gems(Random.Range(1, 4), "50"));
                break;

            case <= 36:
                Hide_Magic_Items();
                Update_Gemstones(gemstones = gem_Handler.Generate_Gems(Random.Range(2, 12), "50"));
                break;

            case <= 44:
                Update_Gemstones(gemstones = gem_Handler.Generate_Gems(Random.Range(2, 12), "10"));
                Populate_Roll_Inputs(6);
                table = "A";
                break;

            case <= 52:
                Update_Gemstones(gemstones = gem_Handler.Generate_Gems(Random.Range(1, 4), "50"));
                Populate_Roll_Inputs(6);
                table = "A";
                break;

            case <= 60:
                Update_Gemstones(gemstones = gem_Handler.Generate_Gems(Random.Range(2, 12), "50"));
                Populate_Roll_Inputs(6);
                table = "A";
                break;

            case <= 65:
                Update_Gemstones(gemstones = gem_Handler.Generate_Gems(Random.Range(2, 12), "10"));
                Populate_Roll_Inputs(4);
                table = "B";
                break;

            case <= 70:
                Update_Gemstones(gemstones = gem_Handler.Generate_Gems(Random.Range(1, 4), "50"));
                Populate_Roll_Inputs(4);
                table = "B";
                break;

            case <= 75:
                Update_Gemstones(gemstones = gem_Handler.Generate_Gems(Random.Range(2, 12), "50"));
                Populate_Roll_Inputs(4);
                table = "B";
                break;

            case <= 78:
                Update_Gemstones(gemstones = gem_Handler.Generate_Gems(Random.Range(2, 12), "10"));
                Populate_Roll_Inputs(4);
                table = "C";
                break;

            case <= 80:
                Update_Gemstones(gemstones = gem_Handler.Generate_Gems(Random.Range(1, 4), "50"));
                Populate_Roll_Inputs(4);
                table = "C";
                break;

            case <= 85:
                Update_Gemstones(gemstones = gem_Handler.Generate_Gems(Random.Range(2, 12), "50"));
                Populate_Roll_Inputs(4);
                table = "C";
                break;

            case <= 92:
                Update_Gemstones(gemstones = gem_Handler.Generate_Gems(Random.Range(1, 4), "50"));
                Populate_Roll_Inputs(4);
                table = "F";
                break;

            case <= 97:
                Update_Gemstones(gemstones = gem_Handler.Generate_Gems(Random.Range(2, 12), "50"));
                Populate_Roll_Inputs(4);
                table = "F";
                break;

            case <= 99:
                Update_Gemstones(gemstones = gem_Handler.Generate_Gems(Random.Range(1, 4), "50"));
                Populate_Roll_Inputs(1);
                table = "G";
                break;

            case 100:
                Update_Gemstones(gemstones = gem_Handler.Generate_Gems(Random.Range(2, 12), "50"));
                Populate_Roll_Inputs(1);
                table = "G";
                break;
        }
        
    }

    private void Hoard_5()
    {

    }

    private void Hoard_11()
    {

    }

    private void Hoard_17()
    {

    }

    private void Hide_Magic_Items()
    {
        magic_Items_Lable.gameObject.SetActive(false);
        magic_Items_Text.gameObject.SetActive(false);
        
    }

    private void Hide_Gemstones()
    {
        gemstone_Lable.gameObject.SetActive(false);
        gemstone_Text.gameObject.SetActive(false);
    }

    private void show_All()
    {
        magic_Items_Lable.gameObject.SetActive(true);
        magic_Items_Lable.gameObject.SetActive(true);
  
        gemstone_Lable.gameObject.SetActive(true);
        gemstone_Text.gameObject.SetActive(true);

        for (int i = 0; i < 8; i++)
        {
            input_List[i].gameObject.SetActive(false);
        }
    }


    private void Update_Gemstones(List<string> gems)
    {
        gemstone_Text.text = "";
        foreach (string gem in gems) 
        {
            gemstone_Text.text += (gem + ", ");
        }
    }

    private void Populate_Roll_Inputs(int rolls )
    {
        for(int i = 0; i < Random.Range(1,rolls); i++)
        {
            input_List[i].gameObject.SetActive(true);
        }
    }

   public void Continue_Button()
    {
        this.gameObject.SetActive(false);
        Menu_2.SetActive(true);
        GameObject.Find("GameManager").GetComponent<LootTables>().File_Selection(table);
    }


}
 