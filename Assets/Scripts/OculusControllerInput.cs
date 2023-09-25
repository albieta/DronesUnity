using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace KartGame.KartSystems
{
    public class OculusControllerInput : BaseInput
    {
        public override InputData GenerateInput()
        {
            float accel = OVRInput.Get(OVRInput.Axis1D.PrimaryIndexTrigger);
            float brake = OVRInput.Get(OVRInput.Axis1D.PrimaryHandTrigger);
            Vector2 turn = OVRInput.Get(OVRInput.Axis2D.PrimaryThumbstick);

            return new InputData 
            {
                Accelerate = accel > 0.3f ? true : false,
                Brake = brake > 0.3f ? true : false,
                TurnInput = turn.x
            };
        }
    }
}


