using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramove : MonoBehaviour
{
    [SerializeField] float smoothing = 5f;
    [SerializeField] Vector3 offset = new Vector3(0f, 15f, -22f);
    public GameObject Player;
    void FixedUpdate()
    {
        Vector3 targetCamPos = Player.transform.position + offset;

        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);

    }
}
