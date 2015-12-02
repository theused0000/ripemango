using UnityEngine; 
using System.Collections;

public class PinchZoom : MonoBehaviour
{
    public float perspectiveZoomSpeed = 0.2f;        // The rate of change of the field of view in perspective mode.
    public float orthoZoomSpeed = 0.1f;        // The rate of change of the orthographic size in orthographic mode.
    public float speed = 0.1F;
	public static bool stopScale;
	public static bool stopScaleHint;
	private int zoomSpeed = 5;

	void Start()
	{
		stopScale = false;
		stopScaleHint = false;
		Debug.Log (ResizeGame.tScaleX);
	}

    void Update()
    {
        float scaleX = transform.localScale.x;
        float scaleY = transform.localScale.y;

		if(scaleX > 1.2f)
		{
			stopScale = true;
		}
		if(GameButtons.hintUsed && stopScale && stopScaleHint && scaleX >= ResizeGame.tScaleX)
		{
			float newScaleX = Mathf.Lerp(transform.localScale.x, ResizeGame.tScaleX - 0.05f, Time.deltaTime * zoomSpeed);
			float newScaleY = Mathf.Lerp(transform.localScale.y, ResizeGame.tScaleY - 0.05f, Time.deltaTime * zoomSpeed);
			transform.localScale = new Vector3(newScaleX, newScaleY, 1f);
			Debug.Log (ResizeGame.tScaleX);
			StartCoroutine("stopScaleDelay");
			float newPosX = Mathf.Lerp(transform.position.x, 0f, Time.deltaTime * zoomSpeed);
			float newPosY = Mathf.Lerp(transform.position.y, 0f, Time.deltaTime * zoomSpeed);
			transform.position = new Vector3(newPosX, newPosY, 0f);
		}
		if(ObjectPressed.objectPressed && stopScale && scaleX >= ResizeGame.tScaleX)
		{
			float newScaleX = Mathf.Lerp(transform.localScale.x, ResizeGame.tScaleX - 0.05f, Time.deltaTime * zoomSpeed);
			float newScaleY = Mathf.Lerp(transform.localScale.y, ResizeGame.tScaleY - 0.05f, Time.deltaTime * zoomSpeed);
			transform.localScale = new Vector3(newScaleX, newScaleY, 1f);
			StartCoroutine("stopScaleDelay");
			float newPosX = Mathf.Lerp(transform.position.x, 0f, Time.deltaTime * zoomSpeed);
			float newPosY = Mathf.Lerp(transform.position.y, 0f, Time.deltaTime * zoomSpeed);
			transform.position = new Vector3(newPosX, newPosY, 0f);
		}
        // If there are two touches on the device...
        else if (Input.touchCount == 2)
        {
            // Store both touches.
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            // Find the position in the previous frame of each touch.
            Vector2 touchZeroPrevPos = touchZero.position - touchZero.deltaPosition;
            Vector2 touchOnePrevPos = touchOne.position - touchOne.deltaPosition;

            // Find the magnitude of the vector (the distance) between the touches in each frame.
            float prevTouchDeltaMag = (touchZeroPrevPos - touchOnePrevPos).magnitude;
            float touchDeltaMag = (touchZero.position - touchOne.position).magnitude;

            // Find the difference in the distances between each frame.
            float deltaMagnitudeDiff =  touchDeltaMag - prevTouchDeltaMag;


            // ... change the orthographic size based on the change in distance between the touches.
            scaleX += deltaMagnitudeDiff * orthoZoomSpeed;
            scaleY += deltaMagnitudeDiff * orthoZoomSpeed;

            // Make sure the scale size never drops below 1.
            scaleX = Mathf.Max(scaleX, ResizeGame.tScaleX);
            scaleY = Mathf.Max(scaleY, ResizeGame.tScaleY);

            // Zoom limiter
            if(scaleX > 2f) {
                scaleX = 2f;
            }
            if(scaleY > 2f) {
                scaleY = 2f;
            }

			transform.localScale = new Vector3(scaleX, scaleY, 1f);
            

        }
		else if(scaleX < 1.2f )
        {
			float newPosX = Mathf.Lerp(transform.position.x, 0f, Time.deltaTime * 4);
			float newPosY = Mathf.Lerp(transform.position.y, 0f, Time.deltaTime * 4);
			transform.position = new Vector3(newPosX, newPosY, 0f);
        }
        else if(scaleX > 1.2f)
        {
            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved) 
            {
                // Get movement of the finger since last frame
                Vector2 touchDeltaPosition = Input.GetTouch(0).deltaPosition;

                // Move object across XY plane
                transform.Translate(touchDeltaPosition.x * speed, touchDeltaPosition.y * speed, 0);
                float panLimitX = transform.position.x;
                float panLimitY = transform.position.y;
                panLimitX = Mathf.Clamp(panLimitX,-9, 9);
                panLimitY = Mathf.Clamp(panLimitY,-5, 3);
                transform.position = new Vector3(panLimitX, panLimitY, 0f);
            }
        }
    }
	IEnumerator stopScaleDelay ()
	{
		yield return new WaitForSeconds(0.8f);
		//transform.localScale = new Vector3(ResizeGame.tScaleX, ResizeGame.tScaleY, 1f);
		stopScale = false;
	}
}