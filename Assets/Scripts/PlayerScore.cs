using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    // To Do's:
    // Private Variabele voor score type int
    // Private List voor "Coins" type int
    //100% gemaakt door kevin :)
    [SerializeField] private int score;
    [SerializeField] private List<int> Coins;

    void Start()
    {
        // Loop: toon 3x een startbericht met Debug.Log in een loop

        for (int i = 0; i < 3; i++)
        {
            Debug.Log("Start de game");
        }

    }

    void Update()
    {


        if (score >= 50)
        {
            Debug.Log("Jij wint");
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {




            int randomWaarde = Random.Range(10, 20);
            AddCoin(randomWaarde);

        }
    }

    // Functie om een munt toe te voegen
    void AddCoin(int coinValue)
    {

        Coins.Add(coinValue);
        score += coinValue;
        Debug.Log("Coins derbij" + coinValue);
    }
}
