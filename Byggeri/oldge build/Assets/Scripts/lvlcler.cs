using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;


public class lvlcler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        BoxCollider2D bc;
        bc = gameObject.AddComponent<BoxCollider2D>();
        bc.isTrigger = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        gameStart.sceneIndex++;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
