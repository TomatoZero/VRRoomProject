using System;
using UnityEngine;

public class BallAudioController : MonoBehaviour
{
    [SerializeField] private AudioSource _audioSource;

    private void OnCollisionEnter(Collision other)
    {
        _audioSource.PlayOneShot(_audioSource.clip);
    }
}