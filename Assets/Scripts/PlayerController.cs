using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject Reached;
    public Vector3 SourcePos;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Move = false;

            GetComponent<CircleCollider2D>().enabled = false;
            GameMAnager.Instance.LifeCount--;
            transform.DOLocalMove(SourcePos, 0.2f).OnComplete(() =>
            {
                circlePos = 0;

                Radius = -6.15f;
                _angle = 0;

                transform.localScale=Vector3.one*1.1f;

                GetComponent<CircleCollider2D>().enabled = true;

            });
        } 
        if (other.CompareTag("Reached"))
        {
            ScoreManager.Instance.Score++;
            Move = false;
            GetComponent<CircleCollider2D>().enabled = false;
          Reached.SetActive(true);
            transform.DOLocalMove(SourcePos, 0.2f).OnComplete(() =>
            {
                circlePos = 0;
                Radius = -6.15f;
                _angle = 0;
                transform.localScale=Vector3.one*1.1f;
                GetComponent<CircleCollider2D>().enabled = true;

            });
        }
    }

    
    public float RotateSpeed = 5f;
    public float Radius = 0.1f;
    public List<float> Scale;
    public List<float> Position;
    public Vector2 _centre;
    public float _angle;
 
    private void Start()
    {
        _centre =Vector2.zero;
    }

    public bool Move;
    private void Update()
    {
        if (CanvasManager.Instance.GamaState == Sate.Play&& Move)
        {
            _angle += RotateSpeed * Time.deltaTime;

            var offset = new Vector2(Mathf.Sin(_angle), Mathf.Cos(_angle)) * Radius;
            transform.position = _centre + offset;
        }

        if (CanvasManager.Instance.GamaState == Sate.Play && Input.GetMouseButtonDown(0))
        {
            if (!Move)
            {
                Radius = -6.1f;
                Move = true;
                return;
            }

            Radius += Position[circlePos];
            if (circlePos < Scale.Count)
            {
               

                transform.localScale = Vector3.one * Scale[circlePos];
                circlePos++;
            }

        }

    }

    public int circlePos;

}
