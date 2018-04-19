using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasePlayer {

    private string playerName;
    private int playerLevel;
    private BaseCharacterClass playerClass;

    private int stamina;
    private int endurance;
    private int strength;
    private int intellect;
    private int overpower;
    private int speed;
    private int mastery;
    private int charisma;

    private int gold; // In-game currency

    private int currentXP;
    private int requiredXP;
    private int statPointsToAllocate;

    //public string PlayerName
    //  get{return playerName;}
    //      //set{playerName = value;}

    public string PlayerName { get; set; }
    public int CurrentXP { get; set; }
    public int RequiredXP { get; set; }
    public int StatPointsToAllocate { get; set; }

    public int PlayerLevel
    {
        get { return playerLevel; }
        set { playerLevel = value}
    }

    public BaseCharacterClass PlayerClass
    {
        get { return playerClass; }
        set { playerClass = value; }
    }

    public int Stamina
    {
        get { return stamina; }
        set { stamina = value}
    }

    public int Endurance
    {
        get { return endurance; }
        set { endurance = value}
    }

    public int Strength
    {
        get { return strength; }
        set { strength = value}
    }

    public int Intellect
    {
        get { return intellect; }
        set { intellect = value}
    }
}
