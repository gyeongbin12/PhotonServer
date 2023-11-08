using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotificationMananger : MonoBehaviour
{
    [SerializeField] Text content;

    public static void NotificationWindow(string message)
    {
        GameObject window = Instantiate(Resources.Load<GameObject>("Notification Window"));

        window.GetComponent<NotificationMananger>().content.text = message;
    }

    public void Close()
    {
        Destroy(gameObject);
    }
}
