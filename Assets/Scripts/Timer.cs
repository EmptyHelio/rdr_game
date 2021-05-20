using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float timeStart;
    public float currentTime = 0;
    public Text timerText;
    public Text bestTime;

    bool TimerRunner = true;
    public bool lose = false;
    
    // Start is called before the first frame update

    private void Awake()
    {
        

        if (PlayerPrefs.HasKey("SaveTime"))
        {
            currentTime = PlayerPrefs.GetFloat("SaveTime");
            bestTime.text = "Best time: " + currentTime.ToString("0.00", System.Globalization.CultureInfo.GetCultureInfo("en-US"));

        }
    }

    void Start()
    {
        timerText.text = timeStart.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (TimerRunner) 
        { 
            timerText.text = timeStart.ToString("0.00", System.Globalization.CultureInfo.GetCultureInfo("en-US"));
            timeStart -= Time.deltaTime;
        }
        if(timeStart < 0)
        {
            GameObject go = GameObject.Find("hand_w_aim_1");
            
            Gun change = go.GetComponent<Gun>();
            change.totalBullet = 0;
            BestTime();
            bestTime.text = "Best time: " + currentTime.ToString("0.00", System.Globalization.CultureInfo.GetCultureInfo("en-US"));

            TimerRunner = false;
            lose = true;
            Debug.Log("You Lose");
        }

        if (GameObject.FindGameObjectsWithTag("Bandit").Length == 0)
        {
            BestTime();
            bestTime.text = "Best time: " + currentTime.ToString("0.00", System.Globalization.CultureInfo.GetCultureInfo("en-US"));
            TimerRunner = false;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentTime = 0.0f;
        }
    }

    public void BestTime()
    {
        if(currentTime < timeStart)
        {
            currentTime = timeStart;

            PlayerPrefs.SetFloat("SaveTime", currentTime);
        }
    }
}
