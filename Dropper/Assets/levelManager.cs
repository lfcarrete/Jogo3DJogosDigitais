using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelManager : MonoBehaviour
{
    public string scenename;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void gotoLevel(){

        SceneManager.LoadScene(scenename);
    }

    public void gotoMenu(){

        SceneManager.LoadScene("Menu");
    }
}
