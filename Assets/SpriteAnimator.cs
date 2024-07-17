using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteAnimator : MonoBehaviour
{
    public List<SpriteAnimation> animations;
    [System.Serializable]
    public struct SpriteAnimation
    {
        public string name;
        public float swapTime;
        public List<Sprite> sprites;
    }

    public void PlayAnimation(string name)
    {
        for(int i = 0; i< animations.Count; i++)
            if (animations[i].name == name)
            {
                StopAllCoroutines();
                StartCoroutine(AnimationRoutine(animations[i]));
                return;
            }
    }

    private IEnumerator AnimationRoutine(SpriteAnimation animation)
    {
        int currentSpriteIndex = 0;

        while(true)
        {
            GetComponent<SpriteRenderer>().sprite = animation.sprites[currentSpriteIndex];
            currentSpriteIndex++;
            if (currentSpriteIndex >= animations.Count)
                currentSpriteIndex = 0;
            yield return new WaitForSeconds(animation.swapTime);
        }
    }
}
