private void EaseInOutMove(GameObject gameObject, Vector3 begin, Vector3 end, float time, bool pingpong)
{
	distance = (end - begin).magnitude;
	speed = 5f;
	if (!pingpong)
	{
		if (Mathf.Abs(gameObject.transform.position.x - end.x) <= 0.001f)
		{
			gameObject.transform.position = begin;
			allTime = 0f;
			localTime = 0f;
		}
		allTime += Time.deltaTime;
		if (allTime >= 1.0f)
		{
			localTime += Time.deltaTime;
			aSpeed = -5.0f;
			gameObject.transform.position = new Vector3(2.5f + 5.0f * localTime + 0.5f * aSpeed * (localTime * localTime), 0, 0);
		}
		else
		{
			aSpeed = 5.0f;
			gameObject.transform.position = new Vector3(0.5f * aSpeed * (allTime * allTime), 0, 0);
		}
	}
	else
	{
		if (gameObject.transform.position.x < 0 || gameObject.transform.position.x > 5)
		{
			isGo = !isGo;
			allTime = 0f;
			localTime = 0f;
			aSpeed = 0f;
		}
		allTime += Time.deltaTime;
		if (isGo)
		{
			if (allTime >= 1.0f)
			{
				localTime += Time.deltaTime;
				aSpeed = -5.0f;
				gameObject.transform.position = new Vector3(2.6f + 5.0f * localTime + 0.5f * aSpeed * (localTime * localTime), 0, 0);
			}
			else
			{
				aSpeed = 5.0f;
				gameObject.transform.position = new Vector3(0.5f * aSpeed * (allTime * allTime), 0, 0);
			}
		}
		else
		{
			if (allTime > 1.0f)
			{
				localTime += Time.deltaTime;
				aSpeed = -5.0f;
				gameObject.transform.position = new Vector3(5 - (2.6f + 5.0f * localTime + 0.5f * aSpeed * (localTime * localTime)), 0, 0);
			}
			else
			{
				aSpeed = 5.0f;
				gameObject.transform.position = new Vector3(5 - (0.5f * aSpeed * (allTime * allTime)), 0, 0);
			}
		}
	}
}