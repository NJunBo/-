	private GameObject cube;
	private Transform begin;
	private Transform end;
	private bool pingpong = false;
	private float distance,disBegin,disEnd;
	//是否往end走
	private bool isGo = false;
	// Use this for initialization
	void Start()
	{
		cube = GameObject.Find("Cube");
		begin = transform.Find("Start");
		end = transform.Find("End");	
	}
    private void Update()
    {
		Move(cube, begin.position, end.position, 2f, pingpong);
	}
	private void Move(GameObject gameObject, Vector3 begin, Vector3 end, float time, bool pingpong)
	{
		distance = (end - begin).magnitude;
		if (!pingpong)
		{
			if (gameObject.transform.position.x >= end.x)
			{
				gameObject.transform.position = begin;
			}
			gameObject.transform.position += new Vector3(distance / time * Time.deltaTime, 0, 0);
		}
		else
		{
			disEnd = (gameObject.transform.position - end).magnitude;
			disBegin = (gameObject.transform.position - begin).magnitude;
			if (disBegin >= 5 || disEnd >= 5)
			{
				isGo = !isGo;
			}
			if (isGo)
			{
				gameObject.transform.position += new Vector3(distance / time * Time.deltaTime, 0, 0);
			}
			else
			{
				gameObject.transform.position -= new Vector3(distance / time * Time.deltaTime, 0, 0);
			}
		}
	}
