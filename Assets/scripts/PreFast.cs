using UnityEngine;

public class PreFast : MonoBehaviour
{
    public GameObject objeto;
    public GameObject puntoMira;
   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(objeto, transform.position, transform.rotation);
            var bala = Instantiate(objeto, puntoMira.transform.position, transform.rotation);
        }
    }
}
