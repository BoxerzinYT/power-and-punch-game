using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    [SerializeField] float life;
    [SerializeField] float maxLife;
    public float Life { get { return life; } set 
    { 
        if(life < maxLife)
        {
            life = value;
            if(life >= maxLife) { life = value; } 
        }
    }}
    public float MaxLife { get { return maxLife; } set { maxLife = value; }}

    public void Start()
    {
        life = maxLife;
    }

    public bool isLifeBelowZero()
    {
        return life <= 0;
    }
}
