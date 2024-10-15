using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class ImpGUI : MonoBehaviour
{
    public string labelText = "Player Stats";

    public void OnGUI()
    {
        GUI.Box(new Rect(10, 20, 1450, 700), "Start");

        if (GUI.Button(new Rect(20, 100, 150, 150), "Player 1"))
        {
            print("1");
            labelText = "Name: Isaiah \n\rAttack: 500\n\rDefense: 20\n\rSpeed: 30\n\rLuck: 15";
        }
        if (GUI.Button(new Rect(20, 260, 150, 150), "Player 2"))
        {
            print("1");
            labelText = "Name: Mikel \n\rAttack: 455\n\rDefense: 15\n\rSpeed: 35\n\rLuck: 15";
        }
        if (GUI.Button(new Rect(20, 420, 150, 150), "Player 3"))
        {
            print("1");
            labelText = "Name: Jah-Rek \n\rAttack: 450\n\rDefense: 20\n\rSpeed: 25\n\rLuck: 10";
        }

        GUI.Label(new Rect(800, 300, 300, 300), labelText);
    }
}