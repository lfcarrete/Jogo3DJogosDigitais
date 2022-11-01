using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pillar : MonoBehaviour
{
    public Object player;
    private string _currentScene;
    // Start is called before the first frame update
    void Start()
    {
        _currentScene = SceneManager.GetActiveScene().name;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player"){
            Destroy(player);
            SceneManager.LoadScene(_currentScene);
        }
    }
}
