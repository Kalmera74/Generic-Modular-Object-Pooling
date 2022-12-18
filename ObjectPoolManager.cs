using GameLib.ScriptableObjectBases.ObjectPooler;
using UnityEngine;
namespace GameLib.Managers.ObjectPoolManager
{

    public class ObjectPoolManager : MonoBehaviour
    {
        [SerializeField] private ObjectPoolerSO<GameObject> ObjectPooler;


        void Awake()
        {
            ObjectPooler.Init();
        }

    }
}