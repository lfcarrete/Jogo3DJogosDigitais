using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pillar : MonoBehaviour
{
    public Object player;
    private string _currentScene;
    public AudioSource audioSource;
    public AudioClip clip;
    public float deltaDeath;
    // Start is called before the first frame update
    void Start()
    {
        _currentScene = SceneManager.GetActiveScene().name;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player"){
            audioSource.PlayOneShot(clip);
            
            Invoke("changeScene", clip.length - deltaDeath);
        }
    }
    void changeScene(){
        Destroy(player);
        SceneManager.LoadScene(_currentScene);
    }
}
