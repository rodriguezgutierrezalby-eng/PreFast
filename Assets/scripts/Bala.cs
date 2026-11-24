using UnityEngine;

public class Bala : MonoBehaviour
{

    float tiempo = 0;
    void Update()
    {
        tiempo = tiempo += Time.deltaTime;
        if (tiempo > 5f)
        {
            Destroy(this.gameObject);
        }
    }
}
