using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecWeapon : MonoBehaviour
{
    [SerializeField] private AudioClip _clip;

    public GameObject bulletPreFab;
    public Transform firePoint;
    public float fireForce = 15f;
    public float numberShots = 3;

    public void Fire()
    {
        SoundManager.Instance.PlaySound(_clip);
        GameObject bullet = Instantiate(bulletPreFab, firePoint.position, firePoint.rotation);

    }
}
