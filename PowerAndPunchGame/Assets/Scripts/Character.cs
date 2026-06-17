using UnityEngine;

[CreateAssetMenu(fileName = "new character", menuName = "Characters/new character")]
public class Character : ScriptableObject
{
    public string char_name;
    public Sprite char_icon;

    [Header("Attributes")]
    public float life;
    public float speed;
    public float physicalStrenght;
    public float magicalStrenght;
}
