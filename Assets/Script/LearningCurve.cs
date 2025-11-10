using UnityEngine;
using UnityEngine.UIElements;

public class LearningCurve : MonoBehaviour
{
    public bool WeaponEquipped = true;
    public string WeaponType = "Claymore";

    public int CurrentErgo = 32;
    public bool BlueButterfly = true;

    private int CurrentAge = 30;
    public int AddedAge = 1;

    public float Birthday = 3.9f;
    public string FirstName = "Tia";
    public bool IsAuthor = true;
    public string LastName = "Hu";
    public string FullName = "Tia " + "Hu";


    // Single - line comment - Chapter 2 task

    /* Multi-line comment
        chapter 2 task */

    // Start is called before the first frame update
    void Start()
    {
        ComputeAge();
        Debug.Log($"A string can have variables like {FirstName} inserted. directly!");
        Debug.Log($"{FirstName} {LastName}");
        Debug.LogFormat("My name is " + FullName);

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

        if(WeaponEquipped)
        {
            if(WeaponType == "Claymore")
            {
                Debug.Log("Force conquers.");
            }
            if(WeaponType != "Claymore")
            {
                Debug.Log("Come back another day.");

            }
        }
        if (!WeaponEquipped)
        {
            Debug.Log("Not today.");
        }

        Character hero = new Character();
        Debug.LogFormat("Hero: {0} - {1} EXP", hero.Name, hero.Exp);
        hero.PrintStatsInfo();

        Character heroine = new Character("Penelope");
        Debug.LogFormat("Hero: {0} - {1} EXP", heroine.Name, heroine.Exp);
        heroine.PrintStatsInfo();

        Weapon huntingBow = new Weapon("Hunting Bow", 50);
        huntingBow.PrintWeaponStats();

        Weapon warBow = new Weapon("War Bow", 100);
        warBow.PrintWeaponStats();

        Paladin knight = new Paladin("Sir Sterling", huntingBow);
        knight.PrintStatsInfo();

        CamTransform = this.GetComponent<Transform>();
        Debug.Log(CamTransform.localPosition);
        DirectionLight = GameObject.Find("Directional Light");
        LightTransform = DirectionLight.GetComponent<Transform>();
        Debug.Log(LightTransform.localPosition);

    }

    /// <summary>
    /// Chapter 2 task - summary comment
    /// computes a modified age integer
    /// </summary>
    void ComputeAge()
    {
        Debug.Log(CurrentAge + Birthday);
    }

    public int GenerateCharacter(string name, int level)
    {
        Debug.LogFormat("Character: {0} - Level: {1}", name, level);

        return level += 5;
    }

    public void Thievery()
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

    public Transform CamTransform;
    public GameObject DirectionLight;
    public Transform LightTransform;

}
