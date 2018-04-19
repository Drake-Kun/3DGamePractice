using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleStateStart {

    private BasePlayer newEnemy = new BasePlayer();
    private StatCalculations statCalculations = new StatCalculations();
    private BaseCharacterClass[] classTypes = new BaseCharacterClass[] { new BaseMageClass(), new BaseWarriorClass() };
    private string[] enemyNames = new string[] { "Deadly Enemy", "Bothersome Pest", "Fierce Foe", "Powerful Plebian"};
    private float staminaModifier = 0.15f; // 15%
    private float enduranceModifier = 0.15f;
    private float intellectModifier = 0.1f; // 10%
    private float strengthModifier = 0.1f;

    public void PrepareBattle()
    {
        // Create Enemy


        //Choose who goes first based on luck
    }

    private void CreateNewEnemy()
    {
        newEnemy.PlayerName = enemyNames[Random.Range (0, enemyNames.Length+1)];
        newEnemy.PlayerLevel = Random.Range(GameInformation.PlayerLevel - 2, GameInformation.PlayerLevel + 2);
        newEnemy.PlayerClass = classTypes[Random.Range(0, classTypes.Length + 1)]; // Randomly choose a class out of the array above
        newEnemy.Stamina = statCalculations.CalculateStat(newEnemy.Stamina, StatCalculations.StatType.STAMINA, newEnemy.PlayerLevel);
        newEnemy.Endurance = statCalculations.CalculateStat(newEnemy.Endurance, StatCalculations.StatType.STAMINA, newEnemy.PlayerLevel);
        newEnemy.Intellect = statCalculations.CalculateStat(newEnemy.Intellect, StatCalculations.StatType.STAMINA, newEnemy.PlayerLevel);
        newEnemy.Strength = statCalculations.CalculateStat(newEnemy.Strength, StatCalculations.StatType.STAMINA, newEnemy.PlayerLevel);
    }
}
