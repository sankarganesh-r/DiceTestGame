using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public TMP_Text resultText;
    public Button rollDiceButton;
    public Dice dice1, dice2;
    int total;

    // Start is called before the first frame update
    void Start()
    {
        rollDiceButton.onClick.RemoveAllListeners();
        rollDiceButton.onClick.AddListener(()=>{
            RollDice();
        });
    }

    void RollDice(){

        int die1= Random.Range(1,7);
        dice1.AnimationTrigger(die1, Result);
        int die2=Random.Range(1,7);
        dice2.AnimationTrigger(die2, Result);
        total = die1 + die2;
        Debug.Log("Total "+total);
    }

    void Result(){

        if(total==1 || total == 7)
            resultText.text = "Your Total is "+total + "\nYou Win";
        else if(total==2 || total ==3 || total == 12)
            resultText.text = "Your Total is "+total + "\nYou Lose";
        else 
            resultText.text = "Your Total is "+total + "\nRoll Again";
    }
}
