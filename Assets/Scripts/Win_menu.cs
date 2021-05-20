using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win_menu : MonoBehaviour
{
    public GameObject WinMenuUI;
    
    void Update()
    {
        GameObject go = GameObject.Find("hand_w_aim_1");
        Gun winner = go.GetComponent<Gun>();
        
        if (winner.win == true)
        {
            StartCoroutine(waiteForWinLose());
            Win();
        }
    }

    void Win()
    {
        WinMenuUI.SetActive(true);
    }

    IEnumerator waiteForWinLose()
    { 
        yield return new WaitForSeconds(1.5f);
    }
}
