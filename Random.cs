/*public Transform CellPrefab;
	public Vector3 Size;
	public Transform[,] Grid;
	List <Transform> Visited= new List<Transform>();
	*/


void dfs(Transform cell){
		Stack stack=new Stack();
		stack.Push(cell);

		while(stack.Count != 0){
			cell = (Transform) stack.Pop();
			if (cell.GetComponent<CellScript>().Visited==false){
				cell.GetComponent<CellScript>().Visited=true;
				//Random.range(1,4);
				foreach(Transform adj in cell.GetComponent<CellScript>().Adjacents){
					cell.renderer.material.color = Color.black;
					Debug.Log ("looked at a cell");
					stack.Push (adj);
				}
			}
		}
	}
