using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vibration : MonoBehaviour
{

    public static Vibration sigleton;

   
    // Start is called before the first frame update
    void Start()
    {
        if(sigleton && sigleton != this)
            Destroy(this);
        else
            sigleton = this;
    }

    // Update is called once per frame
    
    public void TriggerVibration(AudioClip vibrationAudio, OVRInput.Controller controller)
    {

        OVRHapticsClip clip = new OVRHapticsClip(vibrationAudio);

        if(controller == OVRInput.Controller.LTouch)
            {
                OVRHaptics.LeftChannel.Preempt(clip);
            }
        
        else if(controller == OVRInput.Controller.RTouch)
            {
                OVRHaptics.RightChannel.Preempt(clip);
            }
    }
}
