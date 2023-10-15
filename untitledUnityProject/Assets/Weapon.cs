using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private AudioClip _clip;

    public GameObject bulletPreFab;
    public Transform firePoint;
    public float fireForce = 20f;

    public void Fire()
    {
        SoundManager.Instance.PlaySound(_clip);
        GameObject bullet = Instantiate(bulletPreFab, firePoint.position,firePoint .rotation);
        bullet.GetComponent<Rigidbody2D>().AddForce(firePoint.up * fireForce, ForceMode2D.Impulse);
    }

}
