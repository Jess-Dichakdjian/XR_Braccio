using UnityEngine;

public class RobotTrajectorySender : MonoBehaviour
{
    void Update()
    {
        // Example: simulate robot position & rotation
        Vector3 position = transform.position;
        Quaternion rotation = transform.rotation;

        // Prepare the message you would normally send to ROS
        string message = $"{{\"x\":{position.x:F2}, \"y\":{position.y:F2}, \"z\":{position.z:F2}, " +
                         $"\"qx\":{rotation.x:F2}, \"qy\":{rotation.y:F2}, \"qz\":{rotation.z:F2}, \"qw\":{rotation.w:F2}}}";

        // Print to the Unity Console
        Debug.Log($"[Trajectory] Sending: {message}");
    }
}

