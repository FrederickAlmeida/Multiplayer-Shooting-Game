using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class Bullet : MonoBehaviourPunCallbacks
{
    private Camera _camera;

    private void Awake()
    {
        _camera = Camera.main;
    }

    private void Update()
    {
        DestroyWhenOffScreen();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy")) // Ensure your enemy has the "Enemy" tag
        {
            PhotonView enemyPhotonView = collision.gameObject.GetComponent<PhotonView>();
            if (enemyPhotonView != null && enemyPhotonView.IsMine)
            {
                PhotonNetwork.Destroy(collision.gameObject);
            }

            // Additionally, destroy the bullet itself
            PhotonNetwork.Destroy(this.gameObject);
        }
    }


    [PunRPC]
    void DestroyZombie(int viewID, PhotonMessageInfo info)
    {
        // Only the master client will receive this call and will destroy the zombie
        if (PhotonNetwork.IsMasterClient)
        {
            PhotonView targetView = PhotonView.Find(viewID);
            if (targetView != null)
            {
                PhotonNetwork.Destroy(targetView.gameObject);
            }
        }
    }


    private void DestroyWhenOffScreen()
    {
        Vector2 screenPosition = _camera.WorldToScreenPoint(transform.position);

        if (screenPosition.x < 0 || screenPosition.x > _camera.pixelWidth || screenPosition.y < 0 || screenPosition.y > _camera.pixelHeight)
        {
            PhotonNetwork.Destroy(gameObject);
        }
    }
}
