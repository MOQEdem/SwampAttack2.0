using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : Weapon
{
    [SerializeField] private int _bulletsInOneShot;

    public override void Shoot(Transform shootPoint)
    {
        for (int i = 0; i < _bulletsInOneShot; i++)
        {
            Vector3 temporaryShootPoint = new Vector3(shootPoint.position.x + Random.Range(-0.5f, 0.5f), shootPoint.position.y + Random.Range(-0.5f, 0.5f), shootPoint.position.z);
            Instantiate(Bullet, temporaryShootPoint, Quaternion.identity);
        }
    }
}
