using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    public bool ifbool;
    public int warframe;

    // Use this for initialization
    void Start()
    {
        if (ifbool == true)
        {
            print("ja");
        }
        else
        {
            print("nej");
        }

        if (warframe == 5)
        {
            print("mada mada");
        }
        else if (warframe == 4)
        {
            print("i need healing");
        }
        else if (warframe == 3)
        {
            print("you need healing xD kys");
        }
    }

    // Update is called once per frame
    void Update()
    {
        //!= inte lika med 
        //== lika med 
        // > större än
        // < mindre än 
        // >= större eller lika med 
        // <= mindre eller lika med 
        // && och (shift 6) 
        // || eller (altgr <)
        Random.Range(10, 20);
        if (Input.GetKeyDown(KeyCode.W))
        {
            print("Du W"); 
        }
    }
}
