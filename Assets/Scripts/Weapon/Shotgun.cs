using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : Weapon
{
    [SerializeField] private int _amountOfBulletsPerShot;
    [SerializeField] private float _shotSpread;

    public override void Fire(Transform shootPoint)
    {
        Vector3 randomAngle;
        for (int i = 0; i < _amountOfBulletsPerShot; i++)
        {
            randomAngle = new Vector3(0, 0, Random.Range(-_shotSpread, _shotSpread));
            Instantiate(Bullet, shootPoint.position, Quaternion.Euler(randomAngle));
        }
    }
}
