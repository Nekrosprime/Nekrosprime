using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Genjimain : MonoBehaviour
{
    public string sentence1;
    public string sentence2;
    public string sentence3;
    public double triangleBase;
    public float angle;
    public float pieces;
    public int number;
    public string username;
    public int radius;
    public int damage; 

    // Use this for initialization
    void Start()
    {
        Uppgift1();
        Uppgift2();
        Uppgift3();
        Uppgift4();
        Uppgift5();
        Uppgift6();
        Uppgift7();
        Uppgift8(); 
    }

    void Uppgift1()
    {
        Debug.Log("uppg1 " + ((963f * 421f) - (175463.0 / 87.0)));
    }

    void Uppgift2()
    {
        Debug.Log("uppg2 " + ((sentence1)));
        Debug.Log("uppg2 " + (sentence2));
        Debug.Log("uppg2 " + (sentence3)); 
    }

    void Uppgift3()
    {
       Debug.Log("uppg3 " + (Mathf.Pow(number, 2)));
       Debug.Log("uppg3 " + (Mathf.Sqrt(number)));
    }

    void Uppgift4()
    {
        Debug.Log("uppg4 " + ((triangleBase * 8)/2) + "m^2"); 
    }

    void Uppgift5()
    {
        Debug.Log("uppg5 " + ((360 / angle)));
        Debug.Log("uppg5 " + ((360f / pieces + 360/angle))); 
    }

    void Uppgift6()
    {
        Debug.Log("uppg6 " + (string.Format(" rockdevil " + username + " deatharena ")));
    }
    
    void Uppgift7()
    {
    Debug.Log("uppg7:" + (4 / 3 * 3.14 * radius));
    }

    void Uppgift8()
    {

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
