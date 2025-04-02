using UnityEngine;

public class BolaController : MonoBehaviour
{
    public float velocidadeInicialDaBola = 4f;

    void Start()
    {
        GetComponent<Rigidbody2D>().linearVelocity = Vector2.up * velocidadeInicialDaBola;
    }

    void OnCollisionEnter2D(Collision2D colisao)
    {
        if (colisao.gameObject.CompareTag("Bloco") || colisao.gameObject.CompareTag("Barra"))
        {
            if (colisao.gameObject.CompareTag("Bloco"))
            {
                Destroy(colisao.gameObject);
                VerificarSeTodosOsBlocosForamDestruidos();
            }
            GetComponent<Rigidbody2D>().linearVelocity = Vector2.Reflect(GetComponent<Rigidbody2D>().linearVelocity, colisao.contacts[0].normal).normalized * velocidadeInicialDaBola;
        }
    }

    void VerificarSeTodosOsBlocosForamDestruidos()
    {
        if (GameObject.FindGameObjectsWithTag("Bloco").Length == 0)
        {
            GameObject.Find("GerenciadorBlocos").GetComponent<GerenciadorBlocos>().GerarBlocos();
        }
    }
}