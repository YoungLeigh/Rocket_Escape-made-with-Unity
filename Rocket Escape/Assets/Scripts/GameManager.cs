using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Text levelText;
    // Start is called before the first frame update
    void Start()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex+1;
        levelText.text = "Level: " + currentSceneIndex;
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
}
