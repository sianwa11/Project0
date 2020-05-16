using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player; // stores reference to player
    public Vector3 offset; // allows us to offset position

    // Update is called once per frame
    void Update()
    {
        // Set our position to the players position and offset it
        transform.position = player.position + offset;
    }
}
