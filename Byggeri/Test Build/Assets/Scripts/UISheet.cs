using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using TMPro;
using UnityEngine.UI;

public class UISheet : MonoBehaviour
{
    public TextMeshProUGUI hp;
    public TextMeshProUGUI sta;
    public TextMeshProUGUI bio;
    public TextMeshProUGUI role;
    public int charIndex;
    public inex i;
    public Image img;
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

        string path = "Assets/" + i.index[charIndex] + ".json";
        StreamReader r = new StreamReader(path);
        string temp = r.ReadToEnd();
        r.Close();
        charater player = JsonUtility.FromJson<charater>(temp);
        charSheet.player = player;

        hp.text = "Hp : " + player.hp;
        sta.text = "Sta : " + player.sta;
        bio.text = "Biography : " + player.bio;
        role.text = "Role : " + player.role;
        img.sprite = (Sprite)Resources.Load(i.index[charIndex], typeof(Sprite));
    }

    public void nextChar()
    {
        if (charIndex < i.index.Length - 1)
        {
            charIndex++;
        }
        else
        {
            charIndex = 0;
        }
    }
    public void prevChar()
    {
        if (charIndex > 0)
        {
            charIndex--;
        }
        else
        {
            charIndex = i.index.Length - 1;
        }
    }
}
