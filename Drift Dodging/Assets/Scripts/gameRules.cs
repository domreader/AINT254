using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gameRules : MonoBehaviour {

    public Text Lives;
    public Text Timer;
    public Collider Post;
    private int life;
    private float timer = 0.00f;
    

    // Use this for initialization
    void Start () {

        life = 3;

	}

    void endGame()
    {

        SceneManager.LoadScene("Lose Screen");

    }


    // Update is called once per frame

    private void OnTrigger(Collider Post)
    {
        life = (life -= 1);

        Lives.text = "Lives remaining : " + life;

    }

    void Update () {

        Lives.text = "Lives remaining : " + life;

        timer += Time.deltaTime;
        Timer.text = "  " + timer;

        if (timer > 30.00f)
        {
            endGame();
        }

    }
}
