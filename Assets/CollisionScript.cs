using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollisionScript : MonoBehaviour
{
    public Text scoretxt;
    public int score;
    public GameObject particlesys;
    private GameObject test;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectsWithTag("Coin").Length == 0)
        {
            SceneManager.LoadScene("GameWin");
        }
    }

    public void OnTriggerEnter (Collider collision)
    {
        if(collision.gameObject.tag == "Coin")
        {
            test = Instantiate(particlesys, transform.position, Quaternion.identity);
            score = score + 10;
            scoretxt.text = "Score : " + score;
            Destroy(collision.gameObject);
            Destroy(test, 2f);

        }
        if (collision.gameObject.tag == "Water")
        {
            SceneManager.LoadScene("GameLose");
        }

    }
}
