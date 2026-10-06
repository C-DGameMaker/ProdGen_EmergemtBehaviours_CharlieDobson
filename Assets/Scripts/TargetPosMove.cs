using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class TargetPosMove : MonoBehaviour
{
    int randX;
    int randZ;

    private void Start()
    {
        StartCoroutine(ChangePositions());
    }
    private void MovePosition()
    {
        randX = Random.Range(-28, 29);
        randZ = Random.Range(-48, 49);

        transform.position = new Vector3(randX, 0, randZ);
        StartCoroutine(ChangePositions());
    }

    IEnumerator ChangePositions()
    {
        yield return new WaitForSeconds(3);
        MovePosition();
        yield return null;
    }
}
