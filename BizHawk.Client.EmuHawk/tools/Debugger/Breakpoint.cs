﻿using BizHawk.Emulation.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BizHawk.Client.EmuHawk
{
	public class BreakpointList : List<Breakpoint>
	{
		public Action Callback { get; set; }

		public void Add(IDebuggable core, uint address, MemoryCallbackType type)
		{
			Add(new Breakpoint(core, Callback, address, type));
		}

		public new void Clear()
		{
			foreach (var breakpoint in this)
			{
				breakpoint.ReadOnly = false;
				breakpoint.Active = false;
			}

			base.Clear();
		}

		public new bool Remove(Breakpoint b)
		{
			var breakpoint = Find(x => x == b);
			if (breakpoint != null)
			{
				breakpoint.ReadOnly = false;
				breakpoint.Active = false;
			}
			return base.Remove(b);
		}

		public new void RemoveAt(int index)
		{
			if (index < Count)
			{
				var breakpoint = this[index];
				breakpoint.ReadOnly = false;
				breakpoint.Active = false;
				base.RemoveAt(index);
			}
		}

		public new int RemoveAll(Predicate<Breakpoint> match)
		{
			var removeCount = 0;
			foreach (var breakpoint in this)
			{
				if (match(breakpoint))
				{
					Remove(breakpoint);
					removeCount++;
				}
			}
			return removeCount;
		}
	}

	public class Breakpoint
	{
		private bool _active;
		private readonly IDebuggable _core;

		public Breakpoint(bool readOnly, IDebuggable core, Action callBack, uint address, MemoryCallbackType type, bool enabled = true)
		{
			_core = core;
			Type = type;
			Callback = callBack;
			Address = address;
			Name = "Pause";

			Active = enabled;
			ReadOnly = readOnly;
		}

		public Breakpoint(IDebuggable core, Action callBack, uint address, MemoryCallbackType type, bool enabled = true)
		{
			_core = core;
			Type = type;
			Callback = callBack;
			Address = address;
			Name = "Pause";

			Active = enabled;
		}

		public Breakpoint(string name, bool readOnly, IDebuggable core, Action callBack, uint address, MemoryCallbackType type, bool enabled = true)
		{
			_core = core;
			Type = type;
			Callback = callBack;
			Address = address;
			Name = name;

			Active = enabled;
			ReadOnly = readOnly;
		}

		public Action Callback { get; set; }
		public uint? Address { get; set; }
		public MemoryCallbackType Type { get; set; }
		public string Name { get; set; }

		internal bool ReadOnly { get; set; }

		// Adds an existing callback
		public Breakpoint(IDebuggable core, IMemoryCallback callback)
		{
			_core = core;
			_active = true;
			Callback = callback.Callback;
			Address = callback.Address;
			Type = callback.Type;
			Name = callback.Name;

			// We don't know where this callback came from so don't let the user mess with it
			// Most likely it came from lua and doing so could cause some bad things to happen
			ReadOnly = true;
		}

		public bool Active
		{
			get
			{
				return _active;
			}

			set
			{
				if (!ReadOnly)
				{
					if (!value)
					{
						RemoveCallback();
					}

					if (!_active && value) // If inactive and changing to active
					{
						AddCallback();
					}

					_active = value;
				}
			}
		}

		private void AddCallback()
		{
			_core.MemoryCallbacks.Add(new MemoryCallback(Type, Name, Callback, Address));
		}

		private void RemoveCallback()
		{
			_core.MemoryCallbacks.Remove(Callback);
		}
		
		public void ResetCallback()
		{
			if (Active)
			{
				RemoveCallback();
				AddCallback();
			}
		}
	}
}
