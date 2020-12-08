using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Inventory : MonoBehaviour
{
    // number of rolls available for the day
    int[] rollInventory = new int[2];

    //total number of rolls sold (quarterly)
    int[] rollSales = new int[2];

    public Inventory()
    {
        rollInventory[0] = 10;
        rollInventory[1] = 10;
        Debug.Log("Inventory Created");
    }

    public int[] getRollCount()
    {
        return rollInventory;
    }

    // Check roll inventory at the end of the day
    public bool isEmpty(int index)
    {
        if (rollInventory[index] == 0)
        {
            return true;
        }
        return false;
    }

    // Make sure there are enough rolls for customer's order
    public bool isAvailable(int index, int quantity)
    {
        if(quantity < rollInventory[index])
        {
            return false;
        }
        return true;
    }

    public void restock()
    {
        if (isEmpty(0))
            rollInventory[0] = 10;
        if (isEmpty(1))
            rollInventory[1] = 10;
    }

    public void update(int index)
    {
        rollInventory[index] = rollInventory[index] - 1;
        rollSales[index] = rollSales[index] + 1;
    }


}