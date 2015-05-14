using UnityEngine;
using System.Collections;

/// <summary> An add saitama.</summary>
public class AddSaitama : MonoBehaviour 
{
	[SerializeField]
	private GameObject _Saitama;
	public void InstantinateSaitama()
	{
		//（ ﾟ∀ﾟ ）生成.
		if(_Saitama != null)
		{
			GameObject obj = Instantiate(_Saitama);
			obj.transform.SetParent(transform.parent, false);

			//適当に飛ばす.
			Rigidbody2D rigidbody = obj.GetComponent<Rigidbody2D>();
			if (rigidbody != null)
			{
				rigidbody.AddForce(new Vector2(Random.Range(-200.0f, 200.0f),Random.Range(100.0f,200.0f)), ForceMode2D.Impulse);
			}

			//適当に殺す.
			GameObject.Destroy(obj, 2.0f);
		}
	}
}
