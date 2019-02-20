using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CarTimer : MonoBehaviour
{

    void Start()
    {

    }

    public float timeLeft = 100;
    public float addedTimeOnCollision = 30f;
    public string tagname = "Jump";

    // Update is called once per frame
    void Update()
    {
        timeLeft -= Time.deltaTime;

        if (timeLeft < 0)
        {
            GameOver();
        }
    }

    void OnGUI()
    {
        GUI.color = Color.black;
        GUI.Label(new Rect(20, 20, 100, 40), "Time Left : " + timeLeft);
    }

    void GameOver()
    {
        // Only specifying the sceneName or sceneBuildIndex will load the Scene with the Single mode
        SceneManager.LoadScene("Car", LoadSceneMode.Single);
    }

    private void OnTriggerExit(Collider col)
    {
        if (col.tag == tagname)
        {
            timeLeft += addedTimeOnCollision;
        }
    }
}
