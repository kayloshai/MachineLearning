using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquirrelFoodLogic : MonoBehaviour
{
    public bool respawn;
    public SquirrelArea myArea;

    public void OnEaten()
    {
        if (respawn)
        {
            transform.position = new Vector3(Random.Range(-myArea.range, myArea.range),
                3f,
                Random.Range(-myArea.range, myArea.range)) + myArea.transform.position;
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
