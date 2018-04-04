using System.Collections;
using System.Collections.Generic;
using UnityEngine; 
//CODIGO COMENTADO, IGUAL AO ARROW_SCRIPT2 SO QUE COM COMENTARIOS
public class arrow_script : MonoBehaviour
{
    [SerializeField]
    private KeyCode key; //Qual tecla vamos usar para essa seta, cima/baixo/esquerda/direita
    SpriteRenderer obj; //para trocar a cor
    Color old; //Para guarda a cor para ao click trocar para formar uma forma de feedback
    bool colidiu = false; //Indica se um objeto esta colidindo ou não
    HealthP1 healt; //para pegar a vida do player
    [SerializeField]
    private bool createMode;  //Para iniciar ou nao o modo de criação
    [SerializeField]
    private GameObject passo;  //Para poder criar a musica no modo de criação
    GameObject passo2; //para colisao
    // Use this for initialization
    private void Awake()
    {
        obj = GetComponent<SpriteRenderer>(); //guardo a sprite q vou mudar a cor
        old = obj.color; //pego a cor do objeto
    }
    void Start()
    {
       healt =  FindObjectOfType<HealthP1>(); //para lodear função de outro script
    }
    // Update is called once per frame
    void Update()
    {
        if (createMode && Input.GetKeyDown(key)){ //Para quando no modo criação gerar a teclas
            Instantiate(passo, transform.position, Quaternion.identity);
        }


        else { //fora do modo de criação excutamos normalmente
        if (Input.GetKeyDown(key) && colidiu) //se eles estao colidindo e eu aperto a tecla
        {
            Destroy(passo2); //Destruo a seta que vier, que foi definida la em cima, isso somente se tiver colidindo == true
            healt.Damage(0.5f); //dano que inflige no inimigo qndo acerta a tecla
        }
        if (Input.GetKeyDown(key)){ //Sempre que eu apertar tal tecla mudamos a cor
            obj.color = new Color(0, 0, 0); //para a nova cor
        } 
        else if (Input.GetKeyUp(key)) //quando soltamos a tecla
        { 
            obj.color = old; //ela volta a sua cor original
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
