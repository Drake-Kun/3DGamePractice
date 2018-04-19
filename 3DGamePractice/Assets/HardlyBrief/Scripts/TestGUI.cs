﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGUI : MonoBehaviour {

    private BaseCharacterClass class1 = new BaseMageClass();
    private BaseCharacterClass class2 = new BaseWarriorClass();

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnGUI()
    {
        GUILayout.Label(class1.CharacterClassName);
        GUILayout.Label(class1.CharacterClassDescription);
        //GUILayout.Label(class1.Intellect.ToString); // Intellect is an int, not a string. We can convert it to a string using: .ToString()
        GUILayout.Label(class2.CharacterClassName);
        GUILayout.Label(class2.CharacterClassDescription);
        //GUILayout.Label(class2.Strength.ToString); // Strength is an int, not a string. We can convert it to a string using: .ToString() 
    }
}
