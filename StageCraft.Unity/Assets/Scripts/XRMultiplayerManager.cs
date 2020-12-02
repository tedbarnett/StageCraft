using Normal.Realtime;
using UnityEngine;

public class XRMultiplayerManager : MonoBehaviour
{
    [SerializeField]
    private string prefabName = "";

    private Realtime realtime;

    private void Awake()
    {
        realtime = GetComponent<Realtime>();

        realtime.didConnectToRoom += Realtime_didConnectToRoom;
    }

    private void Realtime_didConnectToRoom(Realtime realtime)
    {
        int prefabCount = realtime.room.datastore.prefabViewModels.Count;

        Realtime.Instantiate(prefabName,
            position: new Vector3(transform.position.x + (prefabCount * 0.5f),
            transform.position.y, transform.position.z),
            rotation: transform.rotation,
            ownedByClient: true,
            preventOwnershipTakeover: false,
            destroyWhenOwnerOrLastClientLeaves: true,
            useInstance: realtime);

    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(transform.position, 0.05f);
    }
}
