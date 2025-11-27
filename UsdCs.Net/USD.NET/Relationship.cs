using System;

namespace USD.NET
{
	public class Relationship
	{
		public string[] targetPaths;

		public Relationship()
		{
		}

		public Relationship(string targetPath)
		{
			targetPaths = new string[1] { targetPath };
		}

		public Relationship(string[] targetPaths)
		{
			this.targetPaths = targetPaths;
		}

		public string GetTarget(int index)
		{
			if (targetPaths == null)
			{
				return null;
			}
			if (targetPaths.Length < index + 1)
			{
				return null;
			}
			return targetPaths[index];
		}

		public string GetOnlyTarget()
		{
			string target = GetTarget(0);
			if (target == null)
			{
				throw new ArgumentException("The relationship had no targets");
			}
			if (targetPaths.Length > 1)
			{
				throw new ArgumentException("The relationship had more than one target");
			}
			return target;
		}

		public static implicit operator Relationship(string path)
		{
			Relationship relationship = new Relationship();
			if (path == null)
			{
				relationship.targetPaths = null;
			}
			else if (path == string.Empty)
			{
				relationship.targetPaths = new string[0];
			}
			else
			{
				relationship.targetPaths = new string[1] { path };
			}
			return relationship;
		}

		public static implicit operator Relationship(string[] paths)
		{
			Relationship relationship = new Relationship();
			relationship.targetPaths = paths;
			return relationship;
		}
	}
}
