using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Ingame : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (charSheet.player.hp < 1)
        {
            SceneManager.LoadScene(5);
            gameStart.sceneIndex = 5;
        }
    }
}
