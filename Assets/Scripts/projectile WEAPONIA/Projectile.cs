using UnityEngine;
using UnityEngine.UIElements;

public class Projectile : MonoBehaviour
{
    private Rigidbody2D rb2d;
   
    void Awake()
    {
      rb2d = GetComponent<Rigidbody2D>();  
    }

    public void BlazeStick(Vector2 pos,Vector2 dir)
    {
     transform.position = pos;
     rb2d.linearVelocity = dir;
    }

}
