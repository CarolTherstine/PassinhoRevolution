using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEditor.SceneManagement;

public class HealthP1 : MonoBehaviour
{
    [SerializeField]
    private string levelToload; //Para trocar de cena
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
        CurrentHealth -= dmgvalue; //Decrescento da var da minha vida atual o dano que tomei
        healthbar.value = calculatehealt(); //calculo o dano tomado para jgoar para a barra
        if (CurrentHealth <= 0) //se o personagem tiver sua vida menor que 
        {
            EditorSceneManager.LoadScene(levelToload); //mudo a cena para a cena de victoria do player oposto
        }
    }
    float calculatehealt()
    {
        return CurrentHealth / MaxHealth;
    }
}
