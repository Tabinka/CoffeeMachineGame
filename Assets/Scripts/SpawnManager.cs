using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public List<GameObject> ingredients;
    private string ingredientName;
    // Start is called before the first frame update
    void Start()
    {
        for(int x = 0; x < ingredients.Count; x++)
        {
            Instantiate(ingredients[x], ingredients[x].transform.position, ingredients[x].transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RespawnIngredient()
    {
        for (int y = 0; y < ingredients.Count; y++)
        {
            ingredientName = ingredients[y].name + "(Clone)";
            Debug.Log(ingredientName);
            Debug.Log(GameObject.Find(ingredientName));
            if (!GameObject.Find(ingredientName))
            {
                Debug.Log(ingredientName + " ingredient not found");
                Instantiate(ingredients[y], ingredients[y].transform.position, ingredients[y].transform.rotation);
                break;
            }
        }
            
    }
}
