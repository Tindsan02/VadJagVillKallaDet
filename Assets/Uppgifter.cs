using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uppgifter : MonoBehaviour

{

    /*
    public int userValue;
    public int value;
    public int tarning1;
    public int tarning2;
    */
    public int drake;
    public int riddare;
    public int drakensEld;
    public int dubbelHPdrake;

	// Use this for initialization
	void Start ()
    {
        
        //value = 10;
        drake = (Random.Range(100, 151));
        riddare = 100;
        dubbelHPdrake = (Random.Range(1, 11));
        
        if(dubbelHPdrake == 5)
        {
            drake = drake * 2;
        }

	}
	
	// Update is called once per frame
	void Update ()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            drake -= Random.Range(5, 26);
            drakensEld = Random.Range(1, 3);

            if (drakensEld == 1)
            {
                print(riddare -= Random.Range(10, 21));
            }

            if(drake <= 0)
            {
                print("Grattis du dödade draken!");
            }

            if(riddare <= 0)
            {
                print("Dom dom dooooooom, du dog...");
            }
            
        }
        
        
        
        /*
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            print(userValue += 2);
        }

        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            print(userValue /= 2);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print(userValue);
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            tarning1 = Random.Range(1, 7);
            value += (tarning1);

            tarning2 = Random.Range(1, 7);
            value -= (tarning2);

            print(value);

            if (value <=0)
            {
                print("Sorry du förlorade...");
            }

            if (value >= 20)
            {
                print("Grattis du vann!");
            }
        }
        */
	}
}
