using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Drink : MonoBehaviour
{
    public List<GameObject> allIngredients;
    public GameManager gameManager;
    private string ingredientName;
    public int ingredientCount;
    public float m_prepareTime = 30.0f;
    public TMP_Text timerText;
    private string drinkNameDefault = "Default Drink";
    public string drinkName
    {
        get { return drinkNameDefault; }
        set { 
                if (value == "")
                {
                    Debug.LogError("You can't set no name.");
                }
                else
                {
                    drinkNameDefault = value;
                }
             }
    }
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public virtual void MakeDrink()
    {
        m_prepareTime -= Time.deltaTime;
        timerText.text = (m_prepareTime).ToString();

        if (m_prepareTime <= 0.0)
        {
            gameManager.gameOver = true;
        }
    }

    public void CheckIngredients(GameObject ingredient)
    {
        bool foundIngredient = false;
        for (int i = 0; i < allIngredients.Count; i++)
        {
            ingredientName = allIngredients[i].name + "(Clone)";
            if (ingredient.name == ingredientName)
            {
                foundIngredient = true;
                break;
            }
        }

        if (foundIngredient)
        {
            ingredientCount += 1;
        }
    }
}
