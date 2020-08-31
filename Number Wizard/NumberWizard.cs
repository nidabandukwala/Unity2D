using UnityEngine;
using TMPro;


public class NumberWizard : MonoBehaviour
{
    [SerializeField] int maxguess;
    [SerializeField] int minguess;
    [SerializeField] TextMeshProUGUI guessText;
    int guess;
    // Start is called before the first frame update
    void Start()
    {
        StartGame();

    }

    void StartGame()
    {
        NextGuess();
        
    }

    public void OnPressHigher()
    {
        minguess = guess + 1;
        NextGuess();
    }

    public void OnPressLower()
    {
        maxguess = guess - 1;
        NextGuess();
    }

    // Update is called once per frame
    

    void NextGuess()
    {
        guess = Random.Range(minguess,maxguess + 1);
        guessText.text = guess.ToString();

    }

    


    

    
}

