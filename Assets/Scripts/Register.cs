using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Register : MonoBehaviour
{
    public static Register Instance {get; private set;}

    private void Awake(){
        if (Instance != null && Instance != this){
            //check ensures singleton
            Destroy(this.gameObject);
        }else{
            Instance = this;
        }

    }
    
    // Specific inventory object
    private Inventory inventory = new Inventory();

    public TextMeshProUGUI InBankObj;
    public TextMeshProUGUI DailyEarningsObj;
    public TextMeshProUGUI TipJarObj; 
    public int numDays = 5;

    public float totalInBank = 0.0f;
    int currentDay = 0;
    float[] dailyEarnings = new float[60];
    float[] dailyTips = new float[60]; 


     void Start(){
        numDays = Mathf.Min(60, numDays); // 60 day max
    }

    public float updateInBank(){
        float profit = 0.0f;
        int n;
        for (n = 0; n < numDays; n = n+1){
            profit = profit + dailyEarnings[n];
        }
        Debug.Log("QuarterlyProfit:" + profit);
        totalInBank = profit;
        return profit;
    }

    public void addSale(int index) {
        inventory.update(index);
    }

    public float getDailyEarnings(){return dailyEarnings[currentDay];}
    public float getDailyTips(){return dailyTips[currentDay];}

    // Update is called once per frame
    void Update()
    {

        InBankObj.text = "In Bank: $" + updateInBank().ToString();
        DailyEarningsObj.text = "Daily Earnings: $" + getDailyEarnings().ToString();
        TipJarObj.text = "Tip Jar: $" + getDailyTips().ToString();
    }
}