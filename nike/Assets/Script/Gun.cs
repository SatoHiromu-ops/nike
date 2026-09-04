using UnityEngine;

public class ShootBall : MonoBehaviour
{
    public GameObject ballPrefab;
    public Transform firePoint;
    public float speed = 20f;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        // マウス位置からRayを飛ばす
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        RaycastHit hit;
        Vector3 targetPoint;

        // Rayが何かに当たった場合
        if (Physics.Raycast(ray, out hit))
        {
            targetPoint = hit.point;
        }
        else
        {
            // 当たらなかった場合は前方の適当な位置
            targetPoint = ray.GetPoint(100f);
        }

        // 球生成
        GameObject ball = Instantiate(ballPrefab, firePoint.position, Quaternion.identity);

        // 方向計算
        Vector3 direction = (targetPoint - firePoint.position).normalized;

        // Rigidbody取得
        Rigidbody rb = ball.GetComponent<Rigidbody>();

        // 発射
        rb.linearVelocity = direction * speed;
    }
}