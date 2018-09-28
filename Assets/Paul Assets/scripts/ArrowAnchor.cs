using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ArrowAnchor : MonoBehaviour {

	// Use this for initialization
	// void Start () {
	// 	UnityEngine.XR.WSA.Persistence.WorldAnchorStore.GetAsync(AnchorStoreLoaded);
	// }
	
	// // Update is called once per frame
	// void Update () {
		
	// }

	// private void AnchorStoreLoaded(UnityEngine.XR.WSA.Persistence.WorldAnchorStore store)
 //    {
 //        this.store = store;
 //        LoadAnchors();
 //    }

 //    private void LoadAnchors()
 //    {      
 //                retTrue= this.store.Load("theGameObjectIWantAnchored", theGameObjectIWantAnchored);
 //                if (!retTrue)
 //                {
 //                    // Until the gameObjectIWantAnchored has an anchor saved at least once it will not be in the AnchorStore
 //                }
 //    }

 //    private void SaveAnchor()
 //    {
 //        bool retTrue;
 //        anchor = theGameObjectIWantAnchored.AddComponent<UnityEngine.XR.WSA.WorldAnchor>();
 //       // Remove any previous worldanchor saved with the same name so we can save new one
 //        this.store.Delete(theGameObjectIWantAnchored.name.ToString()); 
 //        retTrue = this.store.Save(theGameObjectIWantAnchored.name.ToString(), anchor);
 //        if (!retTrue)
 //        {
 //            Debug.Log("Anchor save failed.");
 //        }
 //    }

 //    private void ClearAnchor()
 //    {
 //        anchor = theGameObjectIWantAnchored.GetComponent<UnityEngine.XR.WSA.WorldAnchor>();
 //        if (anchor)
 //        {
 //            // remove any world anchor component from the game object so that it can be moved
 //            DestroyImmediate(anchor);
 //        }
 //    }
}
