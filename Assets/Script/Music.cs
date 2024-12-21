using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    public AudioSource Mid;
    public AudioSource Vocal;
    // Start is called before the first frame update
    void Awake()
    {
        MusicControl();
    }
    IEnumerator MusicControl()
    {
        Mid.Play();
        yield return new WaitForSeconds(0.38f);
        Vocal.Play();
    }
}
