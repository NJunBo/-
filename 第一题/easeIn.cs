private void EaseInMove(GameObject gameObject, Vector3 begin, Vector3 end, float time, bool pingpong)
{
	distance = (end - begin).magnitude;
	speed = 0;
	aSpeed = 2.5f;
	if (!pingpong)
	{
		if (gameObject.transform.position.x >= end.x)
		{
			gameObject.transform.position = begin;
			allTime = 0f;
		}

		allTime += Time.deltaTime;
		gameObject.transform.position = new Vector3(0.5f * aSpeed * (allTime * allTime), 0, 0);
	}
	else
	{
		if (gameObject.transform.position.x < 0 || gameObject.transform.position.x > 5)
		{
			isGo = !isGo;
			allTime = 0f;
		}
		allTime += Time.deltaTime;
		if (isGo)
		{
			gameObject.transform.position = new Vector3(0.5f * aSpeed * (allTime * allTime), 0, 0);
		}
		else
		{
			gameObject.transform.position = new Vector3(5f - (0.5f * aSpeed * (allTime * allTime)), 0, 0);
		}
	}
}
