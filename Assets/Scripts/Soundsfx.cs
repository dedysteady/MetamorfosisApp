using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soundsfx : MonoBehaviour
{
    public AudioClip moveSliding;
    public AudioClip moveJigsaw;
    public AudioClip victory;
    public AudioClip getReward;
    public AudioClip clickButton;
    public AudioClip rightAnswer;
    public AudioClip wrongAnswer;

    private AudioSource player;

    private void Start()
    {
        player = GetComponent<AudioSource>();
    }

    private void Update()
    {
  
    }

    public void PlaySliding()
    {
        player.PlayOneShot(moveSliding);
    }

    public void PlayJigsaw()
    {
        player.PlayOneShot(moveJigsaw);
    }

    public void PlayVictory()
    {
        player.PlayOneShot(victory);
    }

    public void PlayClick()
    {
        player.PlayOneShot(clickButton);
    }

    public void PlayGetReward()
    {
        player.PlayOneShot(getReward);
    }

    public void PlayRightAnswer()
    {
        player.PlayOneShot(rightAnswer);
    }

    public void PlayWrongAnswer()
    {
        player.PlayOneShot(wrongAnswer);
    }
}