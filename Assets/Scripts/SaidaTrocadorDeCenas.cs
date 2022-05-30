using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaidaTrocadorDeCenas : MonoBehaviour
{
    [SerializeField]
    private trocadorDecenas pai;
    void OnTriggerExit2D(Collider2D c)
    {
        pai.DescarregarCena();
    }
}
