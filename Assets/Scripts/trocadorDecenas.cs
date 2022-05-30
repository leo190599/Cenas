using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class trocadorDecenas : MonoBehaviour
{
    [SerializeField]
    private string[] CenasACarregar;
    [SerializeField]
    private string[] CenasADescarregar;
    [SerializeField]
    private Collider2D entrada;
    [SerializeField]
    private Collider2D saida;
    // Start is called before the first frame update
   public void DescarregarCena()
   {
       foreach(string s in CenasADescarregar)
       {
           if(SceneManager.GetSceneByName(s).isLoaded)
            SceneManager.UnloadSceneAsync(s);
       }
   }

   public void CarregarCenas()
   {
        foreach(string s in CenasACarregar)
        {
            if(!SceneManager.GetSceneByName(s).isLoaded)
            SceneManager.LoadSceneAsync(s,LoadSceneMode.Additive);
        }
   }
}
