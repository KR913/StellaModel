using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio_ctrl : MonoBehaviour
{
    AudioSource _audio;
    // Start is called before the first frame update
    void Start()
    {
        _audio = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void Play()
    {
        _audio.Play();
    }
}
