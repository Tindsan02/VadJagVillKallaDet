using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Annuetttest : MonoBehaviour {

    public bool ifbool;
    public int value;

	// Use this for initialization
	void Start ()
    {
       if (ifbool == true)
        {
            print("Ja");
        }
        else
        {
            print("Nej");
        }
	}
	
	// Update is called once per frame
	void Update ()
    {

        // != inte lika  med
        // == lika med
        // > större än
        // < mindre än
        // >= större eller lika med
        // <= mindre eller lika med
        // && och
        // || eller

        if (Input.GetKeyDown(KeyCode.E))
        {
            value = Random.Range(0, 10);
            print(" Du E");
        }

        /* if (value == 5)
        {
            print("Hejsan");
        }
        else if (value == 4)
        {
            print("Mada mada");
        }
        else if (value == 3)
        {
            print("lol");
        }
        else
        {
            print("tough luch");
        } */
    }
}
