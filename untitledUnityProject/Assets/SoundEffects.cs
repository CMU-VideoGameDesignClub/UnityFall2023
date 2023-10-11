using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    public AudioSource snd;
    public AudioClip bullet_hit, bullet_shot;

    public void BulletHit()
    {
        snd.clip = bullet_hit;
        snd.Play();
    }

    public void BulletShot()
    {
        snd.clip = bullet_shot;
        snd.Play();
    }
}
