using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColisorTrocadorDeCenas : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private trocadorDecenas pai;
    void OnTriggerExit2D(Collider2D c)
    {
        pai.CarregarCenas();
    }
}
