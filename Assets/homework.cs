using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class homework : MonoBehaviour
{
    public int userValue = 20;
    public int dice1;
    public int dice2;
    public int poäng = 10;
    public int dragonHP;
    public int dragonDMG;
    public int dragonHitChange;
    public int dragonHit;
    public int playerHP;
    public int playerDMG;
    public int playerHitChange;


    // Use this for initialization
    void Start()
    {
        dragonHP = Random.Range(100, 151);
        playerHP = 100;


    }

    // Update is called once per frame
    void Update()
    {
        Uppgift1();
        Uppgift2();
        Uppgift3();
    }

    void Uppgift1()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            //Gör så att talet adderas med 2 
            print(userValue += 2);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            // Gör så att att talet delas med 2 
            print(userValue /= 2);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            // gör så att numret pritas ut 
            print(userValue);
        }
    }

    void Uppgift2()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {

            //random är 1 till 6 och sätter dice1 till svaret
            dice1 = Random.Range(1, 7);
            // dice 2 minskar poäng från dice1 
            dice2 = Random.Range(1, 7);
            // poäng adderar med dice 1 och minskar mer dice 2 
            poäng = poäng + dice1 - dice2;
            print(poäng);

            if (poäng > 19)
            {
                print("you win");
            }

            if (poäng < 1)
            {
                print("you lose");
            }
        }
    }

    void Uppgift3()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            dragonHitChange = Random.Range(0, 2);
            //if dragonHitChange = 0 
            //     { (print dragonHit - = playerHP)}
        }
    }
}