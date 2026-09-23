using UnityEngine;

public class InteractionScripts : MonoBehaviour
{
    [SerializeField] GameObject []prefab;
    [SerializeField] Transform anchor;

    GameObject instance;

    public void create()
    {
        instance = Instantiate(prefab[Random.Range(0,3)], anchor.position, anchor.rotation, anchor);
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
