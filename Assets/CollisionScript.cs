using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollisionScript : MonoBehaviour
{
    public Text scoretxt;
    public int score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter (Collider collision)
    {
        if(collision.gameObject.tag == "Coin")
        {
            score = score + 10;
            scoretxt.text = "Score : " + score;
            Destroy(collision.gameObject);

        }
        if (collision.gameObject.tag == "Water")
        {
            SceneManager.LoadScene("GameLose");
        }

    }
}
