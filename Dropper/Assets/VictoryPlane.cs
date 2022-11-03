using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class VictoryPlane : MonoBehaviour
{
    public string scenename;
    public AudioSource audioSource;
    public AudioClip clip;
    public float deltaDeath;

    // Start is called before the first frame update
    void Start()
    {
       audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        audioSource.PlayOneShot(clip);
        Invoke("changeScene", clip.length - deltaDeath);
    }
    void changeScene() {
        SceneManager.LoadScene(scenename);
    }
}
