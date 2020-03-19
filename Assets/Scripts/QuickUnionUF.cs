using System;
using System.Collections.Generic;

public class QuickUnionUF
{
	private List<int> id = new List<int>();
	private List<int> sz = new List<int>();
	public QuickUnionUF(int N)
	{
		for (int i = 0; i < N; ++i)
		{
			id[i] = i;
			sz[i] = 1;
		}
	}

	public int Root(int i)
	{
		while (id[i] != i)
		{
			++i;
		}

		return id[i];
	}

	public bool Connected(int i, int j)
	{
		return Root(i) == Root(j);
	}

	public bool Union(int p, int q)
	{
		int i = Root(p);
		int j = Root(q);
		if (i == j) return false;
		if (sz[p] > sz[q])
		{
			id[j] = id[i];
			sz[p] += sz[q];
		}
		else
		{
			id[i] = id[j];
			sz[q] += sz[p];
		}

		return true;
	}

	public void DoRandomConnections()
	{
		Random rnd = new Random();
		while (true)
		{
			//int p = rnd.Next(0, );
		}
	}
}
