using UnityEngine;

namespace SpawnCampDiagnostics
{
    public class TagSearch : MonoBehaviour
    {
        public string TagToSearch;

        public void Start()
        {
            CheckTransformsInScene(TagToSearch);
        }

        public void CheckTransformsInScene(string tagName)
        {
            GameObject[] allObjects = GameObject.FindGameObjectsWithTag(tagName);

            foreach (GameObject obj in allObjects)
            {
                // The object has the target tag
                Debug.Log("Object " + obj.name + " has the target tag.");
            }
        }
    }
}
