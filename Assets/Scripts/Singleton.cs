using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Singleton : MonoBehaviour
{

    [SerializeField] int playerScore;
    [SerializeField] Text scoreDisplay;


    private void Awake()
    {
        playerScore = 1;
        int gameStatusCount = FindObjectsOfType<Singleton>().Length;

        if (gameStatusCount>1)
        {
            Destroy(gameObject);
        }
        else
        {

            DontDestroyOnLoad(gameObject);
        }

    }

    // Start is called before the first frame update
    void Start()
    {
        scoreDisplay.text = playerScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
