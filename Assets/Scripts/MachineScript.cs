using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineScript : MonoBehaviour
{
    public SpawnManager spawnManager;
    public Drink drinkScript;
    // Start is called before the first frame update
    void Start()
    {
        spawnManager = GameObject.Find("SpawnManager").GetComponent<SpawnManager>();
        drinkScript = GameObject.FindGameObjectWithTag("Drink").GetComponent<Drink>();
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        drinkScript.CheckIngredients(other.gameObject);
        Destroy(other.gameObject);
        spawnManager.RespawnIngredient();

        Debug.Log(drinkScript.ingredientCount);

        if (drinkScript.ingredientCount == drinkScript.allIngredients.Count)
        {
            drinkScript.ingredientCount = 0;
            Destroy(GameObject.FindGameObjectWithTag("Drink"));
            spawnManager.RespawnMenu();
        }
    }
}
