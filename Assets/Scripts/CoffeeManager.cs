using TMPro;
using System.Collections.Generic;
using UnityEngine;

public class CoffeeGameManager : MonoBehaviour
{
    public List<string> currentInput = new List<string>();
    private List<string> currentRecipe = new List<string>();
    public TMP_Text recipeText;


    void Start()
    {
        SetRandomRecipe();
    }

    void SetRandomRecipe()
    {
        string[] recipes = { "latte", "iced coffee", "mocha", "americano", "vanilla cream brew", "milk brew" };
        int randomIndex = Random.Range(0, recipes.Length);
        SetNewRecipe(recipes[randomIndex]);
    }


    public void OnIngredientClicked(string ingredient)
    {
        currentInput.Add(ingredient.ToLower());
        Debug.Log("Added: " + ingredient);

        if (currentInput.Count == currentRecipe.Count)
        {
            CheckRecipe();
        }
    }

    void CheckRecipe()
    {

        bool correct = true;
        for (int i = 0; i < currentRecipe.Count; i++)
        {
            if (currentInput[i] != currentRecipe[i])
            {
                correct = false;
                break;
            }
        }

        if (correct)
        {
            Debug.Log("?? Doğru kahve hazırlandı!");
            // TODO: müşteri memnuniyeti, animasyon vb.
        }
        else
        {
            Debug.Log("? Tarif yanlış!");
        }

        currentInput.Clear();
    }

    void SetNewRecipe(string coffeeName)
    {
        currentRecipe.Clear();

        switch (coffeeName.ToLower())
        {
            case "latte":
                currentRecipe.AddRange(new List<string> { "coffee", "milk" });
                break;
            case "iced coffee":
                currentRecipe.AddRange(new List<string> { "coffee", "water", "ice" });
                break;
            case "mocha":
                currentRecipe.AddRange(new List<string> { "coffee", "milk", "syrup", "cream" });
                break;
            case "americano":
                currentRecipe.AddRange(new List<string> { "coffee", "water" });
                break;
            case "vanilla cream brew":
                currentRecipe.AddRange(new List<string> { "coffee", "syrup", "cream", "ice" });
                break;
            case "milk brew":
                currentRecipe.AddRange(new List<string> { "milk", "syrup", "ice" });
                break;
            default:
                Debug.LogWarning("Tarif bulunamadı!");
                break;
        }

        Debug.Log("Yeni tarif: " + coffeeName);
        if (recipeText != null)
        {
            recipeText.text = "Sipariş: " + string.Join(" → ", currentRecipe);
        }

    }
}




