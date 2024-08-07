using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

//Klassen indeholder metoder til at starte spillet, gemme spillet, indlæse spillet, gå tilbage til menuen og afslutte spillet.

public class gameStart : MonoBehaviour
{
    public static int sceneIndex = 0;
    private static gameStart _instance;
    public static int curscene;

    //starter spillet
    static gameStart getInstance() { 
        if (_instance == null)
            _instance = new gameStart();
        return _instance; }
    // Start is called before the first frame update
    void Start()
    {
 
    }


    // Update is called once per frame
    void Update()
    {

    }

    //går til næste scene og tilføjer 1 til sceneIndex som holder styr på hvilken scene man er på
    public void AppStart()
    {
        sceneIndex++;
        SceneManager.LoadScene(sceneIndex);

    }

    //afslutter spillet
    public void AppQuit()
    {
        Application.Quit();
    }

    //tilføjer til sceneIndex og går til næste scene som lige er hardcodet her fordi den kun skal bruges en gang
    public void AppChose()
    {
        sceneIndex++;
        SceneManager.LoadScene(2);
    }

    //går tilbage til forrige scene
    public void AppBack()
    {
        sceneIndex--;
        SceneManager.LoadScene(sceneIndex);
    }

    //går tilbage til menuen
    public void AppMenu()
    {
        sceneIndex = 0;
        SceneManager.LoadScene(0);
    }

    //indlæser spillet fra en json fil
    public void LoadGame()
    {

        string path = "Assets/SaveGame.json";
        StreamReader r = new StreamReader(path);
        string temp = r.ReadToEnd();
        r.Close();
        SaveGame loaded;
        loaded = JsonUtility.FromJson<SaveGame>(temp);
        charSheet.player = loaded.player;
        SceneManager.LoadScene(curscene);
        sceneIndex = curscene;


    }

    //gemmer spillet i en json fil
    public void SaveGame()
    {

        SaveGame temp = new SaveGame();
        temp.player = charSheet.player;
        curscene = SceneManager.GetActiveScene().buildIndex;

        string json = JsonUtility.ToJson(temp);
        Debug.Log(json);
        string path = "Assets/SaveGame.json";
        StreamWriter t = new StreamWriter(path, false);
        t.Write(json);
        t.Close();


    }
}
