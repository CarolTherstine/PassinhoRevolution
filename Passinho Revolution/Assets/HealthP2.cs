using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor.SceneManagement;

public class HealthP2 : MonoBehaviour
{
    [SerializeField]
    private string levelToload;
    public Slider healthbar;
    [SerializeField] //para tornar a variavel privada "publica" para o gamedesigner
    private float MaxHealth;
    [SerializeField]
    private float CurrentHealth;
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
    }
    public void Damage(float dmgvalue)
    {
        CurrentHealth -= dmgvalue;
        healthbar.value = calculatehealt();
        if (CurrentHealth <= 0)
        {
            EditorSceneManager.LoadScene(levelToload);
        }
    }
    float calculatehealt()
    {
        return CurrentHealth / MaxHealth;
    }
}
