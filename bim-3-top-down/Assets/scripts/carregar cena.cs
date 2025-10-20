using UnityEngine;
using UnityEngine.SceneManagement;
public class NewMonoBehaviourScript : MonoBehaviour
{
    public string nomeDaCena;

    public void carregar()
    {
        SceneManager.LoadScene(nomeDaCena);
    }
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
}
