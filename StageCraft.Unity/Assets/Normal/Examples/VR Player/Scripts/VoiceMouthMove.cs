#if NORMCORE

using UnityEngine;

namespace Normal.Realtime.Examples {
    public class VoiceMouthMove : MonoBehaviour {
        public Transform mouth;

        private RealtimeAvatarVoice _voice;
        private float _mouthSize;
        public bool xMove = false; // does mouth scale in this dimension?
        public bool yMove = false; // does mouth scale in this dimension?
        public bool zMove = false; // does mouth scale in this dimension?

        void Awake() {
            // Get a reference to the RealtimeAvatarVoice component
            _voice = GetComponent<RealtimeAvatarVoice>();
        }

        void Update() {
            // Use the current voice volume (a value between 0 - 1) to calculate the target mouth size (between 0.1 and 1.0)
            float targetMouthSize = Mathf.Lerp(0.1f, 1.0f, _voice.voiceVolume);

            // Animate the mouth size towards the target mouth size to keep the open / close animation smooth
            _mouthSize = Mathf.Lerp(_mouthSize, targetMouthSize, 30.0f * Time.deltaTime);

            // Apply the mouth size to the scale of the mouth geometry
            Vector3 localScale = mouth.localScale;
            if (xMove) localScale.x = _mouthSize;
            if (yMove) localScale.y = _mouthSize;
            if (zMove) localScale.z = _mouthSize;

            mouth.localScale = localScale; // set mouth object's 3D scale to correspond with _voice.voiceVolume
        }
    }
}

#endif
