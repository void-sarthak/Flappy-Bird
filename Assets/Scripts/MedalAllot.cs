using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedalAllot : MonoBehaviour
{
    public GameObject bronze;
    public GameObject silver;
    public GameObject gold;

    private void Awake()
    {
        int score = GameManager.score;
        if(score < 6)
            bronze.SetActive(true);
        else if(score < 10)
            silver.SetActive(true);
        else
            gold.SetActive(true);
            
    }
}
