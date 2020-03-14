using System.Collections;
using UnityEngine;

public class Pickup : MonoBehaviour
{
    public enum PickUpType
    {
        Star,
        Key,
        Heart
    }

    public PickUpType type;
}
