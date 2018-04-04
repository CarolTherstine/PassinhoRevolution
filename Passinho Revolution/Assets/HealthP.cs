using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthP : MonoBehaviour
{
    public Slider healthbar;
    [SerializeField] //para tornar a variavel privada "publica" para o gamedesigner
    private float MaxHealth;
    [SerializeField]
    private float CurrentHealth;
    [SerializeField]
    private int player;
    // Use this for initialization
    void Start()
    {
        MaxHealth = 100f;
        CurrentHealth = MaxHealth;
        healthbar.value = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
            Damage(6);
    }
    public void Damage(float dmgvalue)
    {
        CurrentHealth -= dmgvalue;
        healthbar.value = calculatehealt();
        if (CurrentHealth <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        Debug.Log("You Died");
    }
    float calculatehealt()
    {
        return CurrentHealth / MaxHealth;
    }
}
