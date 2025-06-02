using System.Collections;

namespace Interfaces2;

class FixedArray<T> : IEnumerable<T>
{
	private T[] _array;

	public FixedArray(params T[] values)
	{
		_array = values;
		Length = _array.Length;
	}

	public int Length { get; }

	public IEnumerator<T> GetEnumerator()
	{
		return new Enumerator(this);
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	private class Enumerator : IEnumerator<T>
	{
		private FixedArray<T> _fixedArray;
		private int _currentIndex;

		public Enumerator(FixedArray<T> fixedArray)
		{
			_fixedArray = fixedArray;
			_currentIndex = -1;
		}

		public bool MoveNext()
		{
			_currentIndex++;

			return _currentIndex < _fixedArray.Length;
		}

		public void Reset()
		{
			_currentIndex = -1;
		}

		public T Current => _fixedArray._array[_currentIndex];

		object? IEnumerator.Current => Current;

		public void Dispose()
		{
		}
	}
}