using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cappucino : Drink
{
    // Start is called before the first frame update
    void Start()
    {
        drinkName = "Cappucino";
    }

    // Update is called once per frame
    void Update()
    {
        MakeDrink();
    }
}
