using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipSpawner : MonoBehaviour
{
    public MainSpeed mainSpeed = null;
    public GameObject Ppip = null;
    public float delay = 1f;
    public float offset = 32f;
    public bool active = true;
    public Transform pipTransform;

    private int randomY;
    
    void Start()
    {
        StartCoroutine(PipGenerator());
    }

    IEnumerator PipGenerator()
    {
        yield return new WaitForSeconds(delay);

        if (active)
        {
            randomY = (int) (Random.Range(-(Screen.width / PixelCamera.pixelToUnit / 2f - offset), (Screen.width / PixelCamera.pixelToUnit / 2 - (offset / 6))));
            Ppip.GetComponent<MoveRelatively>().mainSpeed = mainSpeed;
            var pipClone = Instantiate(Ppip, new Vector3(transform.position.x, randomY, 0), Quaternion.identity);
            pipTransform = pipClone.transform;
        }

        StartCoroutine(PipGenerator());
    }
}
