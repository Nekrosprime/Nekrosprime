using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // public = syns i unity
    // int = heltal 
    // genji = namnet 
    public int genji;

    //float = decimaltal med 7 precision 
    public float hanzo;

    //double = decimaltal med 15 precision 
    public double bush;

    public string minecraft;
    //sring minecraft;

    /*
     * mnkfngkldmnfmdmfv
     * fgkssgsldnfs
     * dfsdnfsndk
     */

    //bool = något som är true/false  (ja/nej) 
    public bool john;

    //char = ett tecken
    public char dennis;
    // Use this for initialization
    void Start()
    {
        //PrintText();
        //calculate(); 
        Debug.Log("hej" + "då!" + john + " " + minecraft);
        Debug.Log(string.Format("hej då! {0} {1}", john, minecraft));
    } 

    void PrintText()
    {
        Debug.Log(minecraft);
        Debug.Log(genji + hanzo);

        //Debug.LogError(
        //     Mathf.Sqrt(548743) +
        //     Mathf.Sqrt(548743));


    }
    void Calculate()
    {
        Debug.Log(5 + 5);
        Debug.Log(9 / 2);
    }
    // Update is called once per frame
    void Update()
    {


    }
}

