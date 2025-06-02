using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class Weponia : MonoBehaviour
{
    private bool IsOnCoolDown;
    private bool isShooting; 
    
    [SerializeField] protected Weaponstats weaponstats;
    private Coroutine activelyFiring;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    
    
    
    
    private IEnumerator ShootingTimer()
    {
        while(isShooting)
        {
            if (CanShoot())
            { 
              Shoot(); 
              IsOnCoolDown = true;
            }
            yield return new WaitForSeconds(weaponstats.TimeBetweenShots);
            IsOnCoolDown = false;
            if (!isFullyAutomatic)
            {
                activelyFiring = null;
                yield break;
            }
            
        }  
        activelyFiring = null;
    }
    public void StartShoot()
    {
        isShooting = true;
        if (activelyFiring != null)
        {
            return;
        }

        activelyFiring = StartCoroutine(ShootingTimer());
    }

    public bool CanShoot()
    {
     return !IsOnCoolDown;    
    }

    public void StopShoot()
    {
        isShooting = false;
    }

    protected abstract void Shoot();





}
