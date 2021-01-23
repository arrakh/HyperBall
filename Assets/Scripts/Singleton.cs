using UnityEngine;

public class Singleton<T> : MonoBehaviour 
    where T : MonoBehaviour
{
    #region SINGLETON PATTERN
    public static T _instance;
    public static T Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = GameObject.FindObjectOfType<T>();

                if (_instance == null)
                {
                    GameObject container = new GameObject("New Singleton");
                    _instance = container.AddComponent<T>();
                }
            }

            return _instance;
        }
    }
    #endregion
}
