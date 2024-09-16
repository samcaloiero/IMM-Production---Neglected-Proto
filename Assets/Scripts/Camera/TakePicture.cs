using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TakePictures : MonoBehaviour
{

	private bool camAccess;
	public Image targetImagePrefab;
	public Transform parentContainer;
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
    
    			Sprite capturedSprite = Sprite.Create(texture, new Rect(0,0, texture.width, texture.height), new Vector2(0.5f,0.5f));
			    
			    Image newImage = Instantiate(targetImagePrefab, parentContainer);
			    newImage.sprite = capturedSprite;
			    newImage.preserveAspect = true;
			    
    		}
    	}, maxSize );
    
    	Debug.Log( "Permission result: " + permission );
    }
    

    public void CreateTextureFromImage()
    {
	    
    }
    
}
