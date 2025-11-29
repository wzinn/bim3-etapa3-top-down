using UnityEngine;

public class CriardorDeInimigos : MonoBehaviour
{
   
    public GameObject[] inimigos; 
    public Transform[] posicaoDosInimigos;
    
    public float tempoDoNovoInimigo = 10; //segundos
    
    private float cronometroInimigo = 0;
    
    
    
    void Start()
    {
        
    }

    
    void Update()
    {
        cronometroInimigo += Time.deltaTime;

        if (cronometroInimigo >= tempoDoNovoInimigo)
        {
            Transform ponto = posicaoDosInimigos[Random.Range(0, inimigos.Length)];
           
            GameObject inimigo = Instantiate(inimigos[Random.Range(0, inimigos.Length)],
                new Vector3(ponto.position.x, ponto.position.y, ponto.position.z),
                ponto.rotation) as GameObject;
            
            cronometroInimigo = 0;
        }
    }
}