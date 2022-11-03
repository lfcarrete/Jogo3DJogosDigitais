using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    public GameObject optionsMenu;
    public GameObject panel;
    private bool _Menu;
    // Start is called before the first frame update
    void Start()
    {
        this._Menu = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            this._Menu = !this._Menu;
            optionsMenu.gameObject.SetActive(this._Menu);
            panel.gameObject.SetActive(this._Menu);
        }

        if(this._Menu){
            if(Input.GetKeyDown(KeyCode.Return)){
                SceneManager.LoadScene("Menu");
            }
        }
    }
}
