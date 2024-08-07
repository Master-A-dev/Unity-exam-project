using System.Collections;
using System.Collections.Generic;
using System.IO;
using TMPro;
using UnityEngine;
using UnityEngine.Timeline;
using UnityEngine.UI;

public class UIHUD : MonoBehaviour
{
    public TextMeshProUGUI hp;
    public TextMeshProUGUI sta;
    public Image img;
    public inex i;
    public int charIndex;
    public GameObject pausePop;
    bool paused = false;
    // Start is called before the first frame update
    void Start()
    {
        string charIndexPath = "Assets/charIndex.json";
        StreamReader ir = new StreamReader(charIndexPath);
        string iTemp = ir.ReadToEnd();
        ir.Close();
        i = JsonUtility.FromJson<inex>(iTemp);
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject.Find("hp").GetComponent<TextMeshProUGUI>().text = ""+charSheet.player.hp;

        if (Input.GetKeyDown("escape")) 
            if(paused != false)
            {
                pausePop.SetActive(false);
                paused = false;
                GameObject.Find(charSheet.player.role.ToString() + "(Clone)").GetComponent<Player_Controller>().moveSpeed = 3.5f;
            }
            else if(paused != true)
            {
                pausePop.SetActive(true);
                paused = true;
                GameObject.Find(charSheet.player.role.ToString() + "(Clone)").GetComponent<Player_Controller>().moveSpeed = 0f;
            }
            

        


        

    }
}
