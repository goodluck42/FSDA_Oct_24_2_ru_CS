using System.Collections;

namespace Interfaces2;

class ItemContainer<T> : ICollection<T>
{
	private readonly List<T> _items;

	public ItemContainer()
	{
		_items = new List<T>();
	}

	public IEnumerator<T> GetEnumerator()
	{
		return _items.GetEnumerator();
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public void Add(T item)
	{
		_items.Add(item);
	}

	public void Clear()
	{
		_items.Clear();
	}

	public bool Contains(T item)
	{
		return _items.Contains(item);
	}

	public void CopyTo(T[] array, int arrayIndex)
	{
		_items.CopyTo(array, arrayIndex);
	}

	public bool Remove(T item)
	{
		return _items.Remove(item);
	}

	public int Count => _items.Count; // public int Count { get; }
	public bool IsReadOnly => false;
}