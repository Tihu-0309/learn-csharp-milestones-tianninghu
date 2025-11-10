using UnityEngine;
using System.Collections.Generic;

public class ChapterThreeAndFour : MonoBehaviour
{

    public bool WeaponEquipped = true;
    public string WeaponType = "Claymore";

    public int CurrentErgo = 32;
    public bool BlueButterfly = true;

    public string CharacterAction = "Attack";

     // Start is called before the first frame update
    void Start()
    {
        int characterLevel = 23;
        GenerateCharacter("Pino", characterLevel);
        int nextSkillLevel = GenerateCharacter("Pino", characterLevel);
        Debug.Log(nextSkillLevel);
        Debug.Log(GenerateCharacter("Penelope", characterLevel));

        if (BlueButterfly)
        {
            Debug.Log("Wake up, clever one");
        }
        else
        {
            Debug.Log("The time has not come.");
        }


        Thievery();

        if (WeaponEquipped)
        {
            if (WeaponType == "Claymore")
            {
                Debug.Log("Force conquers.");
            }
            if (WeaponType != "Claymore")
            {
                Debug.Log("Come back another day.");

            }
        }

        if (!WeaponEquipped)
        {
            Debug.Log("Not today.");
        }

        int GenerateCharacter(string name, int level)
        {
            Debug.LogFormat("Character: {0} - Level: {1}", name, level);

            return level += 5;
        }

        PrintCharacterAction();

        Debug.Log(Array[0,1]);

        List<string> NPC = new List<string>() 
        { 
            "Sophia",
            "Gemini",
            "Eugenie",
            "Venigni"
        };

        Debug.LogFormat("Hotel Residents: {0}", NPC.Count);

        Dictionary<string, int> ItemInventory = new
        Dictionary<string, int>()
        {
            {"Battery", 3 },
            {"Poles", 4 },
            {"Grenade", 9 }
        };

        foreach(KeyValuePair<string, int> kvp in ItemInventory)
        {
            Debug.LogFormat("Item: {0} - {1}g", kvp.Key, kvp.Value);
        }

        Debug.LogFormat("Items: {0}", ItemInventory.Count);
        
        int listLength = NPC.Count;

        for (int i = 0; i < listLength; i++)
        {
            Debug.LogFormat("Index: {0} - {1}", i, NPC[i]);
            if(NPC[i] == "Sophia")
            {
                Debug.Log("I am so happy you are here.");
            }
        }

        foreach(string nPC in NPC)
        {
            Debug.LogFormat("{0} - Here!", nPC);
        }

    }

    void Thievery()
    {
        if (CurrentErgo > 50)
        {
            Debug.Log("You're rolling in it!");
        }
        else if (CurrentErgo < 50)
        {
            Debug.Log("Not much there to steal...");
        }
        else
        {
            Debug.Log("Looks like your purse is in the sweet spot.");
        }
    }

    public void PrintCharacterAction()
    {
        switch(CharacterAction)
        {
            case "Heal":
                Debug.Log("Potion sent.");
                break;
            default:
                Debug.Log("Shields up.");
                break;
            case "Attack":
                Debug.Log("To arms!");
                break;
        }
    }

    int[,] Array = new int[2,3]
    {
        {1,3,9,},
        {2,4,6,}
    };

}
