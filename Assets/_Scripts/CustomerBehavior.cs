using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CustomerBehavior : MonoBehaviour
{
    // Start is called before the first frame update

    public TMP_Text m_SpeechBubble;
    public TMP_Text m_timeRemaining;

    CustomerFactory cf = new CustomerFactory(); 

    public int timeRemaining;
    public int rollType;
    public int startseconds = -1;

    void Start()
    {
        this.GetComponent<Renderer>().enabled = false;
        m_SpeechBubble.text = "";
        m_timeRemaining.text = "";
    }

    public void activateCustomer () {
        this.GetComponent<Renderer>().enabled = true;
        cf.createRandomCustomer(this);
        m_SpeechBubble.text = "Hi, I want " + this.rollType;
        m_timeRemaining.text = "I am here for only " + this.timeRemaining + " more seconds";
    }

    public void updateTimePassed(int timePassed) {
        if (this.GetComponent<Renderer>().enabled == true)
        {
            if (startseconds <= -1) {
                startseconds = timePassed;
            }
            else {
                timeRemaining = timePassed - startseconds;
                if (timeRemaining > 0) {
                    m_timeRemaining.text = "I am here for only " + timeRemaining + " more seconds";
                } else {
                    dissatisfiedOrder();
                }
            }
        }
    }

    void deactivateCustomer() {
        this.GetComponent<Renderer>().enabled = false;
        rollType = 0;
        timeRemaining = 0;
        m_SpeechBubble.text = "";
        m_timeRemaining.text = "";
        startseconds = -1;
    }

    public void OrderStatisfied () {
        m_SpeechBubble.text = "Thank you! I am leaving now.";
        // payOrder();
        // leaveTip();
        //leaveReview();
        deactivateCustomer();
    }

    public void dissatisfiedOrder() {
        m_SpeechBubble.text = "Service is terrible! I am leaving now!";
        //leaveReview();
        deactivateCustomer();
    }

    void Update() 
    {
        
    }
}