using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoaderSimple : MonoBehaviour
{
    public string SceneName;
    void Start()
    {
        
    }

    void Update()
    {
       
    }
    public void SceneChange()
    {
        SceneManager.LoadScene(SceneName);
    }
}
