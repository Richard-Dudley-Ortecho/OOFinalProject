using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollMaking : MonoBehaviour
{
    public GameObject lettuceObj, breadObj, meatObj;
    public GameObject plate;

    List<GameObject> ingredientsLive = new List<GameObject>(); 
    int ingredientCount = 0;
    float spacing = 0.15f;

    List<GameObject> getIngredientsList(){return ingredientsLive;}
    int getIngredientCount(){ return ingredientsLive.Count;}

    public void addLettuce(){
        Debug.Log("Lettuce");
        Vector3 position = plate.transform.position;
        position.y = position.y + spacing * getIngredientCount();
        Quaternion rotation = Quaternion.Euler(0f, 0f ,0f);
        ingredientsLive.Add( Instantiate(lettuceObj, position, rotation, plate.transform));
    }

    public void addBread(){
        Debug.Log("Bread");
        Vector3 position = plate.transform.position;
        position.y = position.y + (spacing * getIngredientCount());
        Quaternion rotation = Quaternion.Euler(90f, 0f ,0f);
        ingredientsLive.Add( Instantiate(breadObj, position, rotation, plate.transform));
    }

    public void addMeat(){
        Debug.Log("Meat");
        Vector3 position = plate.transform.position;
        position.y = position.y + (spacing * getIngredientCount());
        Quaternion rotation = Quaternion.Euler(0f, 0f ,0f);
        ingredientsLive.Add( Instantiate(meatObj, position, rotation, plate.transform));
    }

    public void clearIngredients(){
        int numIngred = ingredientsLive.Count;
        for (int i=0; i < numIngred; i++){
            Destroy(ingredientsLive[i]);
        }
        ingredientsLive.Clear();
    }

}
