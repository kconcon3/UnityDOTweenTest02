using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Test02 : MonoBehaviour {

	void Start()
	{
		Sequence sequence = DOTween.Sequence();

		// 1つめのシーケンス
		sequence.Append(
			DOTween.To(
				() => gameObject.transform.position,	// 何に
				(n) => transform.position = n,			// 何を
				new Vector3(400.0f, 0.0f, 0.0f),		// どこまで(最終的な値)
				1.0f									// 時間
			)
		);

		// 2つめのシーケンス
		sequence.Append(
			DOTween.To(
				() => gameObject.transform.position,
				(n) => transform.position = n,
				new Vector3(0.0f, 200.0f, 0.0f),
				1.0f
			)
		);

		// 3つめのシーケンス
		sequence.AppendCallback(() => CallbackTest());	// コールバック

		// 4つめのシーケンス
		sequence.Append(
			DOTween.To(
				() => gameObject.transform.position,
				(n) => transform.position = n,
				new Vector3(0.0f, 0.0f, 0.0f),
				2.0f
			)
		);
	}

	// コールバックのテスト用関数
	void CallbackTest()
	{
		Debug.Log("CallbackTest");
	}

}
