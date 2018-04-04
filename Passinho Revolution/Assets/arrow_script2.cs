using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow_script2 : MonoBehaviour
{
    public KeyCode key; //Qual tecla vamos usar para essa seta, cima/baixo/esquerda/direita
    SpriteRenderer obj;
    Color old;
    bool colidiu = false;
    HealthP2 healt;
    public bool createMode;
    public GameObject passo;
    GameObject passo2;
    // Use this for initialization
    private void Awake()
    {
        obj = GetComponent<SpriteRenderer>();
        old = obj.color;
    }
    void Start()
    {
        healt = FindObjectOfType<HealthP2>();
    }
    // Update is called once per frame
    void Update()
    {
        if (createMode && Input.GetKeyDown(key))
        {
            Instantiate(passo, transform.position, Quaternion.identity);
        }


        else
        {
            if (Input.GetKeyDown(key) && colidiu) //se eles estao colidindo e eu aperto a tecla
            {
                Destroy(passo2);
                healt.Damage(0.5f);
            }
            if (Input.GetKeyDown(key))
            {
                obj.color = new Color(0, 0, 0);
            }
            else if (Input.GetKeyUp(key))
            {
                obj.color = old;
            }
        }
    }
    void OnTriggerEnter2D(Collider2D trig) //Para que quando a seta venha se eles coliderem vamos "destruir" ela, visto que o collider dela eh trigger
    {
        colidiu = true; //para dizer que ele esta colidindo
        passo2 = trig.gameObject; //definindo que passo eh o objeto que triggerou
    }
    void OnTriggerExit2D(Collider2D trig) //ao sair do trigger
    {
        colidiu = false; //para que quando o objeto saia ele nao possa mais ser destruido mesmo clicando, pq ele n esta colidindo
    }
}
