using UnityEngine;
using Unity.Robotics.ROSTCPConnector;   // ROSConnection
using RosMessageTypes.Std;              // StringMsg

public class HelloRosPublisher : MonoBehaviour
{
    ROSConnection ros;
    float timer;

    void Start()
    {
        ros = ROSConnection.instance;                  // uses your Robotics → ROS Settings
        ros.RegisterPublisher<StringMsg>("/chatter");  // topic name
    }

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 1f)        // publish every 1 second
        {
            timer = 0f;
            var msg = new StringMsg("Hello from Unity!");
            ros.Publish("/chatter", msg);
        }
    }
}
