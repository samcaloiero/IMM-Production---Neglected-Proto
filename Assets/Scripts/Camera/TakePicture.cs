using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TakePictures : MonoBehaviour
{

	private bool camAccess;

	public GameObject prefabPanel;
	public Image targetImagePrefab;
	public Transform parentContainer;
	public RectTransform rectTransform;
	public int containerHeightAddAmnt = 100;
	public GameObject promptQuestion;
	void Awake()
	{
		RequestPermissionAsynchronously(camAccess);
	}
	
    
    
    // Example code doesn't use this function but it is here for reference. It's recommended to ask for permissions manually using the
    // RequestPermissionAsync methods prior to calling NativeCamera functions
    private async void RequestPermissionAsynchronously( bool isPicturePermission )
    {
    	NativeCamera.Permission permission = await NativeCamera.RequestPermissionAsync( isPicturePermission );
    	Debug.Log( "Permission result: " + permission );
    }
    
    public void TakePicture( int maxSize )
    {
    	NativeCamera.Permission permission = NativeCamera.TakePicture( ( path ) =>
    	{
    		Debug.Log( "Image path: " + path );
    		if( path != null )
    		{
    			// Create a Texture2D from the captured image
    			Texture2D texture = NativeCamera.LoadImageAtPath( path, maxSize );
    			if( texture == null )
    			{
    				Debug.Log( "Couldn't load texture from " + path );
    				return;
    			}
			    
			    //Increased size of scrollable content
			    rectTransform.sizeDelta = new Vector2(rectTransform.sizeDelta.x, rectTransform.sizeDelta.y + containerHeightAddAmnt);
			    
				//Image creation stuff
    			Sprite capturedSprite = Sprite.Create(texture, new Rect(0,0, texture.width, texture.height), new Vector2(0.5f,0.5f));
			    //Instantiate Prefab Panel
			    //Prefab Panel that holds Image and Text box
			    GameObject newPanel = Instantiate(prefabPanel, parentContainer);
			    
			    // Transform childPanel = newPanel.transform.Find("ChildPanelImage");
			    // Image childImage = childPanel.GetComponent<Image>();
			    // if (childImage != null)
			    // {
				   //  childImage.sprite = capturedSprite;
			    // }

			    Image childImageComponent = newPanel.GetComponentInChildren<Image>();
			    if (childImageComponent != null)
			    {
				    childImageComponent.sprite = capturedSprite;
			    }
			    //Inside Instantiated prefab panel add find image panel and add image to it
			    // Image newImage = Instantiate(targetImagePrefab, parentContainer);
			    //    newImage.sprite = capturedSprite;
			    //    newImage.preserveAspect = true;

		    }
    	}, maxSize );
    
    	Debug.Log( "Permission result: " + permission );
    }
    

    public void CreateTextureFromImage()
    {
	    
    }
    
}
