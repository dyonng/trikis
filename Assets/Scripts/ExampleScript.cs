using UnityEngine;
using DG.Tweening;

public class ExampleScript : MonoBehaviour
{
    private static readonly uint RNG_SEED = 1337;
    private MersenneTwister rng;

    private void Awake()
    {
        rng = new MersenneTwister(RNG_SEED);
    }

    private void Start()
    {
        Debug.Log($"A cool random number: {rng.Random()}");

        Sequence sequence = DOTween.Sequence();
        sequence.Insert(0, transform.DORotate(Vector3.one * 720, 6f));
        sequence.Insert(0, transform.DOMoveX(3, 2f));
        sequence.Insert(2f, transform.DOMoveY(-3, 2f));
        sequence.Insert(4f, transform.DOMove(Vector3.zero, 2f));
        sequence.SetDelay(0.5f);
    }
}
