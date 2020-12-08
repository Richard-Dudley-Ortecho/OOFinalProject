using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumpMainMenu : MonoBehaviour
{

    public string kitchenScene;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadKitchen(){
        SceneManager.LoadScene(kitchenScene);
    }
}
