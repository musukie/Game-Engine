using UnityEngine;

// ������Ʈ�� �ƴϱ� ������ MonoBehaviour�� ��ӹ��� ������ Unity �۾����� �־��� �� ����.
public class Character : MonoBehaviour
{
    // Ability�� ���������� �̷��� ����� ��
    public Ability ability;

    public float speed = 15.0f;
    void Start()
    {
        Debug.Log(ability.strength);
        Debug.Log(ability.intelligence);
        Debug.Log(ability.dexterity);
        Debug.Log(ability.wisdom);
    }
}