using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    public Vector3 offset = new Vector3(25, 0, -20);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 newPos = player.transform.position + offset;
        newPos.x = 0;
        transform.position = newPos;
    }
}
