using UnityEngine;

public class Weponia2 : Weponia
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private Transform firePoint;
   
    
       
    protected override void Shoot()
    {
        Projectile p = Instantiate(weaponstats.ProjectilePrefab);
        p.BlazeStick(firePoint.position, firePoint.forward);
        Destroy(p.gameObject, 3);
    }
}
