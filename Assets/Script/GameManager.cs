using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public int collCount = 0;
    [SerializeField] private GameObject UiComplete;
    [SerializeField] private GameObject UiLevelComplete;
    [SerializeField] private GameObject player1;
    [SerializeField] private GameObject player2;
    [SerializeField] private Sceneloader sceneloader;
    [SerializeField] private int numberToComplete;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(collCount >= numberToComplete)
        {
            UiComplete.SetActive(false);
            UiLevelComplete.SetActive(true);
            player1.SetActive(false);
            player2.SetActive(false);

        }
    }
}
