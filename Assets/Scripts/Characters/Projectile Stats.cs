using UnityEngine;

[CreateAssetMenu(fileName = "ProjectileStats", menuName = "Scriptable Objects/ProjectileStats")]
public class ProjectileStats : ScriptableObject
{
 [SerializeField] private float speed;
   [SerializeField] private int type;
   [SerializeField]private float damage;
   [SerializeField]private float knockback;
   [SerializeField]private float explosion_radius;
   [SerializeField] private bool canExplode;
   [SerializeField] private int numBounces;
   public float Explosion_radius => explosion_radius;
   public float Knockback => knockback;
   public float Damage => damage;
   public float Speed => speed;
   public bool CanExplode => canExplode;
   public int Type => type;
   public int NumBounces => numBounces; 
}
