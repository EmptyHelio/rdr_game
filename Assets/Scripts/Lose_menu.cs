using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Lose_menu : MonoBehaviour
{
    public GameObject LoseMenuUI;

    
    // Update is called once per frame
    void Update()
    {
        GameObject go = GameObject.Find("Time");
        Timer loser = go.GetComponent<Timer>();
        
        if(loser.lose == true)
        {
            StartCoroutine(waiteForWinLose());
            Lose();
        }
    }

    void Lose()
    {
        LoseMenuUI.SetActive(true);
        
    }



    IEnumerator waiteForWinLose()
    {
        yield return new WaitForSeconds(1.5f);
    }
}
