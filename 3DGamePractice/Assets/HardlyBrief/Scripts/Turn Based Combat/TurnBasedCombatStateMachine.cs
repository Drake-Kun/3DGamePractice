using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnBasedCombatStateMachine : MonoBehaviour {

    private bool hasAddedXP = false;
    private BattleStateStart battleStateStartScript = new BattleStateStart();

    public enum BattleStates
    {
        START,
        PLAYERCHOICE,
        PLAYERANIMATE,
        ENEMYCHOICE,
        LOSE,
        WIN
    }

    private BattleStates currentState;

	// Use this for initialization
	void Start () {
        hasAddedXP = false;
        currentState = BattleStates.START;
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(currentState);
        switch (currentState)
        {
            case (BattleStates.START):
                //SETUP BATTLE FUNCTION

                battleStateStartScript.PrepareBattle();
                break;

            case (BattleStates.PLAYERCHOICE):
                break;
            case (BattleStates.ENEMYCHOICE):
                break;
            case (BattleStates.WIN):
                break;
            case (BattleStates.LOSE):
                break;
        }
	}

    private void OnGUI()
    {
        if(GUILayout.Button("NEXT STATE"))
        {
            if (currentState == BattleStates.START)
            {
                currentState = BattleStates.PLAYERCHOICE;
            }

            else if (currentState == BattleStates.PLAYERCHOICE)
            {
                currentState = BattleStates.ENEMYCHOICE;
            }

            else if (currentState == BattleStates.ENEMYCHOICE)
            {
                currentState = BattleStates.WIN;
            }

            else if (currentState == BattleStates.WIN)
            {
                currentState = BattleStates.LOSE;
            }
        }
    }
}
