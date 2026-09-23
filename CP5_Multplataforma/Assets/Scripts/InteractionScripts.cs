using UnityEngine;
using Vuforia;

public class InteractionScripts : MonoBehaviour
{
    [SerializeField] GameObject []prefab;
    [SerializeField] Transform anchor;

    GameObject instance;

    public void create()
    {
        instance = Instantiate(prefab[0], anchor.position, anchor.rotation, anchor);
    }

    public void destroy()
    {
        Destroy(instance);
    }

    public void change()
    {
        destroy();
        create();
    }
}
