﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update
    public void PauseAudio()
    {
        this.gameObject.GetComponent<AudioSource>().Stop();
    }
}
