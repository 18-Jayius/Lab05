using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TimerScript : MonoBehaviour
{
    public float timer = 60;
    public Text timertxt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer = Mathf.Round(timer * 100f) / 100f;
        timer = timer - Time.deltaTime;
        timertxt.text = "Timer : " + timer;

        if(timer <= 0)
        {
            SceneManager.LoadScene("GameLose");
        }
    }
}
