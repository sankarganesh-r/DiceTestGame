using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Image diceImage1;
    public Image diceImage2;
    public Sprite[] diceSprites;

    public TMP_Text resultText;
    public Button rollDiceButton;

    // Start is called before the first frame update
    void Start()
    {
        rollDiceButton.onClick.RemoveAllListeners();
        rollDiceButton.onClick.AddListener(()=>{
            RollDice();
            //resultText.text="Rolling";
        });
    }


    void RollDice(){

        int die1= Random.Range(1,7);
        int die2=Random.Range(1,7);
        int total = die1+die2;

        Debug.Log("Total "+total);

        if(total==1 || total == 7)
            resultText.text = "Your Total is "+total + "\nYou Win";
        else if(total==2 || total ==3 || total == 12)
            resultText.text = "Your Total is "+total + "\nYou Lose";
        else 
            resultText.text = "Your Total is "+total + "\nRoll Again";

    }

    // Update is called once per frame
    void Update()
    {

        
    }
}
