using UnityEngine;

[DefaultExecutionOrder(-10)]
public abstract class Singleton<T> : MonoBehaviour where T : MonoBehaviour
{
    public static T Instance { get; private set; }

    protected virtual void Awake()
    {
        if (Instance == null)
        {
            Instance = this as T;
            return;
        }
        else
        {
            Destroy(this);
        }
    }
}

