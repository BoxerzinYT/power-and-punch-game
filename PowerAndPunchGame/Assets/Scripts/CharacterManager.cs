using UnityEngine.InputSystem;
using UnityEngine;

[RequireComponent(typeof(HealthSystem))]
[RequireComponent(typeof(Move))]
public class CharacterManager : MonoBehaviour
{
    [SerializeField] Move myMove;
    [SerializeField] HealthSystem myHealth;
    [SerializeField] Character myChar_so;

    //Set the variables from the scripts to the variables from the scriptable
    public void Start()
    {
        myMove.Speed = myChar_so.speed;
        myHealth.Life = myChar_so.life;
    }

    //Basic character attack
    public void OnBasicAttack(InputValue value)
    {
        
    }

    //Passive character attack

    public void OnPassiveAttack(InputValue value)
    {
        
    }
}
