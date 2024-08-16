using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManager : MonoBehaviour
{
    public static soundManager INSTANCE;
    public AudioSource audio;
    // Start is called before the first frame update
    void Awake()
    {
        if (INSTANCE != null && INSTANCE != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            INSTANCE = this;
        }
        DontDestroyOnLoad(this);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Playsound(AudioClip clip)
    {
        audio.PlayOneShot(clip);
    }
}
