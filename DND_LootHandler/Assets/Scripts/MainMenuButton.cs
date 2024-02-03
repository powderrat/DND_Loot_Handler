using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.UIElements;
using System;
using Unity.VisualScripting;
using Unity.UI;
using TMPro;

public class MainMenuButton : MonoBehaviour
{
    public TMP_Dropdown level_Drop, loot_Drop;
    public TMP_InputField roll_Text;
    public TMP_Text indivi_Text;
    public GameObject indivi_Menu;
    public GemHandler gem_Handler;
    public GrouLoot groop_Loot;
    private int roll;
    private bool over;


    void Start()
    {
        //roll = int.Parse(roll_Text.text);
        //Level_Check();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Level_Check()
    {   //value is from dropdown on main menu
        roll = int.Parse(roll_Text.text);
        if (loot_Drop.value == 0)
        {
            Indi_Loot(level_Drop.value);
        }

        else if(loot_Drop.value == 1)
        {   // hoard loot uses the CSV sheets
            this.gameObject.SetActive(false);
            groop_Loot.Hoard_Loot(level_Drop.value, roll);
        }

       
    }

    private void Indi_Loot(int level)
    {
        //Gold Handler
        this.gameObject.SetActive(false);
        indivi_Menu.SetActive(true);
        if (level == 0)
        {
            if (roll <= 30)
            {
                indivi_Text.text = "Roll 5 d6 Copper Pieces";

            }
            else if (roll <= 60)
            {
                indivi_Text.text = "Roll 4 d6 Silver Pieces";
            }

            else if (roll <= 70)
            {
                indivi_Text.text = "Roll 3 d6 Electrum Pieces";
            }

            else if (roll <= 95)
            {
                indivi_Text.text = "Roll 3 d6 Gold Pieces";
            }

            else
            {
                indivi_Text.text = "Roll 1 d6  Platinum Pieces";
            }


        }

        else if (level == 1)
        {
            if (roll <= 30)
            {
                indivi_Text.text = "Roll 4 d6 Copper Pieces x 100 and 1 d6 x 10 Electrum Pieces";

            }
            else if (roll <= 60)
            {
                indivi_Text.text = "Roll 6 d6 Silver Pieces x 10 and 2 d6 x 10 Gold Pieces";
            }

            else if (roll <= 70)
            {
                indivi_Text.text = "Roll 3 d6 Electrum Pieces x 10 and 2 2 d6 x 10 Gold Pieces";
            }

            else if (roll <= 95)
            {
                indivi_Text.text = "Roll 4 d6 Gold Pieces x 10";
            }

            else
            {
                indivi_Text.text = "Roll 2 d6 x 10 Gold Pieces and 3 d6  Platinum Pieces";
            }
        }

        else if (level == 2)
        {
            if (roll <= 20)
            {
                indivi_Text.text = "Roll 4 d6 Silver Pieces x 100 and 1 d6 x 100 Gold Pieces";

            }

            else if (roll <= 35)
            {
                indivi_Text.text = "Roll 1 d6 Electrum Pieces x 100 and 1 d6 x 100 Gold Pieces";

            }

            else if (roll <= 75)
            {
                indivi_Text.text = "Roll 2 d6 Gold Pieces x 100 and 1 d6 x 10 Platinum Pieces";

            }
            else
            {
                indivi_Text.text = "Roll 2 d6 Gold Pieces x 100 and 2 d6 x 10 Platinum Pieces";
            }
        }

        else if (level == 3)
        {
            if (roll <= 15)
            {
                indivi_Text.text = "Roll 2 d6 Electrum Pieces x 1000 and 8 d6 x 100 Gold Pieces";

            }

            else if (roll <= 55)
            {
                indivi_Text.text = "Roll 1 d6 Gold Pieces x 1000 and 1 d6 x 100 Platinum Pieces";

            }
            else
            {
                indivi_Text.text = "Roll 1 d6 Gold Pieces x 1000 and 2 d6 x 100 Platinum Pieces";
            }
        }

    }

   





}
