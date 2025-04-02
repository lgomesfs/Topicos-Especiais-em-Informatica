using UnityEngine;

public class GerenciadorBlocos : MonoBehaviour
{
    public GameObject blocoPrefab;
    public int numeroLinhas = 5;
    public int numeroColunas = 10;
    public float espacamentoEntreLinhas = 1.2f;
    public float espacamentoEntreColunas = 1.2f;
    public Vector2 posicaoInicial = new Vector2(0f, 3f);

    void Start()
    {
        GerarBlocos();
    }

    public void GerarBlocos()
    {
        for (int linha = 0; linha < numeroLinhas; linha++)
        {
            for (int coluna = 0; coluna < numeroColunas; coluna++)
            {
                Vector2 posicaoDoBloco = CalcularPosicaoDoBloco(linha, coluna);
                Instantiate(blocoPrefab, posicaoDoBloco, Quaternion.identity);
                Debug.Log("Bloco instanciado na posição: " + posicaoDoBloco);
            }
        }
    }

    Vector2 CalcularPosicaoDoBloco(int linha, int coluna)
    {
        float x = coluna * espacamentoEntreColunas + posicaoInicial.x - (numeroColunas * espacamentoEntreColunas / 2) + (espacamentoEntreColunas / 2);
        float y = linha * espacamentoEntreLinhas + posicaoInicial.y;
        return new Vector2(x, y);
    }
}