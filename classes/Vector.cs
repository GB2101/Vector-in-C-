namespace School.classes
{
	public class Vector<T>
	{
		private T[] _array;
		private int _size;
		private int _length;

		public int length { get { return this._length; } }

		public Vector()
		{
			this._size = 25;
			this._length = 0;
			this._array = new T[this._size];

		}

		public T this[int i]
		{
			get
			{
				if (i < this._length && i >= 0)
				{
					return this._array[i];
				}
				else
				{
					throw new System.Exception("Index out of bounds");
				}
			}
			set
			{
				if (i >= 0)
				{
					if (i < this._length)
					{
						this._array[i] = value;
					}
					else
					{
						this._length = i;
						this._validateSize();
						this._array[i] = value;
					}
				}
				else
				{
					throw new System.Exception("Index out of bounds");
				}
			}
		}

		public void push(T item)
		{
			this._array[this._length] = item;
			this._length++;
			this._validateSize();
		}

		public T pop()
		{
			var item = this._array[this._length - 1];
			this._length--;
			return item;
		}

		public T item(int index)
		{
			return this._array[index];
		}

		public void concat(T[] array)
		{
			int length = array.Length;
			int pos = this._length;
			this._length += length;
			this._validateSize();
			for (int i = 0; i < length; i++, pos++)
			{
				this._array[pos] = array[i];
			}
		}

		public void concat(Vector<T> array)
		{
			int length = array.length;
			int pos = this._length;
			this._length += length;
			this._validateSize();
			for (int i = 0; i < length; i++, pos++)
			{
				this._array[pos] = array[i];
			}
		}

		private void _validateSize()
		{
			if (this._length >= this._size)
			{
				while (this._length >= this._size)
				{
					this._size *= 2;
					System.Console.WriteLine("double");
				}
				T[] temp = new T[this._size];
				for (int i = 0; i < this._array.Length; i++)
				{
					temp[i] = this._array[i];
				}
				this._array = temp;
			}
		}
	}
}
