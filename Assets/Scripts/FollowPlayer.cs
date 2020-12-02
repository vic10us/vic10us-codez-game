using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform Player;
    public Vector3 CameraOffest;

    // Update is called once per frame
    void Update()
    {
        transform.position = Player.position + CameraOffest;
    }
}
