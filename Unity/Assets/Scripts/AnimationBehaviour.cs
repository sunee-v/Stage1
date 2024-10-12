using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;
using UnityEngine.UI;

public class AnimationBehaviour : MonoBehaviour
{
    [SerializeField] private AnimationClip clip;
    [SerializeField] private Button playButton;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AnimationClip>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playButton.IsActive())
        {
            PlayStartAnimation();
        }
    }

    private void PlayStartAnimation()
    {
        GetComponent<Animator>().Play("StartAnimation");
    }
}
