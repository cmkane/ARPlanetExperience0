using System.Collections;
using UnityEngine;

public class spinStar : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right * Time.deltaTime);
    }
}
