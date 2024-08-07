using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class JWriter : MonoBehaviour
{

    public character player;
    // Start is called before the first frame update
    void Start()
    {
        player.bio = "The necromancer is weak on his own but he summons an unstoppable army as long as something dead is nearby";
        player.hp = 100;
        player.sta = 50;
        player.role = character.Role.Necromancer;

        string json = JsonUtility.ToJson(player);
        Debug.Log(json);
        string path = "Assets/necromancer.json";
        StreamWriter t = new StreamWriter(path, false);
        t.Write(json);
        t.Close();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
