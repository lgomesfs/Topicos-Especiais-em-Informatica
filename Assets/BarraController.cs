using UnityEngine;

    public class BarraController : MonoBehaviour
    {
        public float velocidade = 10f;

        void Update()
        {
            float movimentoHorizontal = Input.GetAxisRaw("Horizontal");
            Vector2 movimento = new Vector2(movimentoHorizontal, 0f);
            GetComponent<Rigidbody2D>().linearVelocity = movimento * velocidade;
        }
    }