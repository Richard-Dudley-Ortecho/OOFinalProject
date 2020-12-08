using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollMaking : MonoBehaviour
{
    public GameObject lettuceObj, breadObj, meatObj;
    public Transform plate;

    List<GameObject> ingredientsLive = new List<GameObject>(); 

    public void addLettuce(){
        Debug.Log("Lettuce");
        Vector3 position = plate.position;
        Quaternion rotation = Quaternion.Euler(0f, 0f ,0f);
        ingredientsLive.Add( Instantiate(lettuceObj, position, rotation, plate));
    }

    public void addIngredient(int key){
        switch (key){
            case 1:
                Debug.Log("Lettuce");
                ingredientsLive.Add( Instantiate(lettuceObj, new Vector3(0,0,0), Quaternion.Euler(0f, 0f ,0f), plate));
                break;
            case 2:
                //ingredientsLive.Add("Bun");
                break;
            case 3:
                //ingredientsLive.Add("Burger");
                break;
            default:
                Debug.Log("Didn't recognize ingredient " + key);
                break;
        }
    }

    void renderBurger(){
        int numIngred = ingredientsLive.Count;
        for (int i=0; i < numIngred; i++){
            
        }
    }

    void Update(){
        renderBurger();
    }


}
