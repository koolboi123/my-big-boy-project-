using UnityEngine;

[CreateAssetMenu(fileName = "Weaponstats", menuName = "Scriptable Objects/Weaponstats")]
public class Weaponstats : ScriptableObject
{
    [SerializeField] private Projectile projectilePrefab;
    [SerializeField] private float timeBetweenShots;
    [SerializeField] private int numOfProjectiles;
    [SerializeField] private float spread;
    [SerializeField]private bool isFullyAutomatic;
    public float Spread => spread;
    public Projectile ProjectilePrefab => projectilePrefab;
    public float TimeBetweenShots => timeBetweenShots;
    public int NumOfProjectiles => numOfProjectiles;
    public bool IsFullyAutomatic => isFullyAutomatic;
   
}
