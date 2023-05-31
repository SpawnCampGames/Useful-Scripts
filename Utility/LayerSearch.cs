using UnityEngine;

namespace SpawnCampDiagnostics
{
    public class LayerSearch : MonoBehaviour
    {
        public string LayerToSearch;

        public void Start()
        {
            CheckTransformsInScene(LayerToSearch);
        }

        public void CheckTransformsInScene(string layerName)
        {
            Transform[] allTransforms = FindObjectsOfType<Transform>();

            foreach(Transform tr in allTransforms)
            {
                if(tr.gameObject.layer == LayerMask.NameToLayer(layerName))
                {
                    // The transform's layer matches the target layer
                    Debug.Log("Transform " + tr.name + " has the target layer.");
                }
            }
        }
    }
}
