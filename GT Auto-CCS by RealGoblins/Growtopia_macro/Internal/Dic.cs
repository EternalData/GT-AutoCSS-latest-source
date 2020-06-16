using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using ns0;

namespace Growtopia_macro.Internal
{
	// Token: 0x02000015 RID: 21
	public class Dic
	{
		// Token: 0x06000084 RID: 132
		[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
		private static extern int SetWindowsHookEx(int int_2, Dic.Delegate1 delegate1_2, IntPtr intptr_0, int int_3);

		// Token: 0x06000085 RID: 133
		[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto, SetLastError = true)]
		private static extern int UnhookWindowsHookEx(int int_2);

		// Token: 0x06000086 RID: 134
		[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
		private static extern int CallNextHookEx(int int_2, int int_3, int int_4, IntPtr intptr_0);

		// Token: 0x06000087 RID: 135
		[DllImport("user32")]
		private static extern int ToAscii(int int_2, int int_3, byte[] byte_0, byte[] byte_1, int int_4);

		// Token: 0x06000088 RID: 136
		[DllImport("user32")]
		private static extern int GetKeyboardState(byte[] byte_0);

		// Token: 0x06000089 RID: 137
		[DllImport("user32.dll", CallingConvention = CallingConvention.StdCall, CharSet = CharSet.Auto)]
		private static extern short GetKeyState(int int_2);

		// Token: 0x0600008A RID: 138 RVA: 0x00002804 File Offset: 0x00000A04
		public Dic()
		{
			Class21.smethod_0();
			base..ctor();
			this.MoveWorker();
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00002817 File Offset: 0x00000A17
		public Dic(bool isinstance, bool extractpol)
		{
			Class21.smethod_0();
			base..ctor();
			this.UpdateWorker(isinstance, extractpol);
		}

		// Token: 0x0600008C RID: 140 RVA: 0x00008BC0 File Offset: 0x00006DC0
		~Dic()
		{
			this.ReflectWorker(true, true, false);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00008BF0 File Offset: 0x00006DF0
		[CompilerGenerated]
		public void DestroyWorker(MouseEventHandler value)
		{
			MouseEventHandler mouseEventHandler = this.filter;
			MouseEventHandler mouseEventHandler2;
			do
			{
				mouseEventHandler2 = mouseEventHandler;
				MouseEventHandler value2 = (MouseEventHandler)Delegate.Combine(mouseEventHandler2, value);
				mouseEventHandler = Interlocked.CompareExchange<MouseEventHandler>(ref this.filter, value2, mouseEventHandler2);
			}
			while (mouseEventHandler != mouseEventHandler2);
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00008C28 File Offset: 0x00006E28
		[CompilerGenerated]
		public void PublishWorker(MouseEventHandler res)
		{
			MouseEventHandler mouseEventHandler = this.filter;
			MouseEventHandler mouseEventHandler2;
			do
			{
				mouseEventHandler2 = mouseEventHandler;
				MouseEventHandler value = (MouseEventHandler)Delegate.Remove(mouseEventHandler2, res);
				mouseEventHandler = Interlocked.CompareExchange<MouseEventHandler>(ref this.filter, value, mouseEventHandler2);
			}
			while (mouseEventHandler != mouseEventHandler2);
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00008C60 File Offset: 0x00006E60
		[CompilerGenerated]
		public void TestWorker(MouseEventHandler i)
		{
			MouseEventHandler mouseEventHandler = this.m_Service;
			MouseEventHandler mouseEventHandler2;
			do
			{
				mouseEventHandler2 = mouseEventHandler;
				MouseEventHandler value = (MouseEventHandler)Delegate.Combine(mouseEventHandler2, i);
				mouseEventHandler = Interlocked.CompareExchange<MouseEventHandler>(ref this.m_Service, value, mouseEventHandler2);
			}
			while (mouseEventHandler != mouseEventHandler2);
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00008C98 File Offset: 0x00006E98
		[CompilerGenerated]
		public void FindWorker(MouseEventHandler item)
		{
			MouseEventHandler mouseEventHandler = this.m_Service;
			MouseEventHandler mouseEventHandler2;
			do
			{
				mouseEventHandler2 = mouseEventHandler;
				MouseEventHandler value = (MouseEventHandler)Delegate.Remove(mouseEventHandler2, item);
				mouseEventHandler = Interlocked.CompareExchange<MouseEventHandler>(ref this.m_Service, value, mouseEventHandler2);
			}
			while (mouseEventHandler != mouseEventHandler2);
		}

		// Token: 0x06000091 RID: 145 RVA: 0x00008CD0 File Offset: 0x00006ED0
		[CompilerGenerated]
		public void LogoutWorker(MouseEventHandler first)
		{
			MouseEventHandler mouseEventHandler = this._Proccesor;
			MouseEventHandler mouseEventHandler2;
			do
			{
				mouseEventHandler2 = mouseEventHandler;
				MouseEventHandler value = (MouseEventHandler)Delegate.Combine(mouseEventHandler2, first);
				mouseEventHandler = Interlocked.CompareExchange<MouseEventHandler>(ref this._Proccesor, value, mouseEventHandler2);
			}
			while (mouseEventHandler != mouseEventHandler2);
		}

		// Token: 0x06000092 RID: 146 RVA: 0x00008D08 File Offset: 0x00006F08
		[CompilerGenerated]
		public void ExcludeWorker(MouseEventHandler task)
		{
			MouseEventHandler mouseEventHandler = this._Proccesor;
			MouseEventHandler mouseEventHandler2;
			do
			{
				mouseEventHandler2 = mouseEventHandler;
				MouseEventHandler value = (MouseEventHandler)Delegate.Remove(mouseEventHandler2, task);
				mouseEventHandler = Interlocked.CompareExchange<MouseEventHandler>(ref this._Proccesor, value, mouseEventHandler2);
			}
			while (mouseEventHandler != mouseEventHandler2);
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00008D40 File Offset: 0x00006F40
		[CompilerGenerated]
		public void ListWorker(MouseEventHandler res)
		{
			MouseEventHandler mouseEventHandler = this._Rule;
			MouseEventHandler mouseEventHandler2;
			do
			{
				mouseEventHandler2 = mouseEventHandler;
				MouseEventHandler value = (MouseEventHandler)Delegate.Combine(mouseEventHandler2, res);
				mouseEventHandler = Interlocked.CompareExchange<MouseEventHandler>(ref this._Rule, value, mouseEventHandler2);
			}
			while (mouseEventHandler != mouseEventHandler2);
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00008D78 File Offset: 0x00006F78
		[CompilerGenerated]
		public void CustomizeWorker(MouseEventHandler last)
		{
			MouseEventHandler mouseEventHandler = this._Rule;
			MouseEventHandler mouseEventHandler2;
			do
			{
				mouseEventHandler2 = mouseEventHandler;
				MouseEventHandler value = (MouseEventHandler)Delegate.Remove(mouseEventHandler2, last);
				mouseEventHandler = Interlocked.CompareExchange<MouseEventHandler>(ref this._Rule, value, mouseEventHandler2);
			}
			while (mouseEventHandler != mouseEventHandler2);
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00008DB0 File Offset: 0x00006FB0
		[CompilerGenerated]
		public void FlushWorker(MouseEventHandler item)
		{
			MouseEventHandler mouseEventHandler = this.pool;
			MouseEventHandler mouseEventHandler2;
			do
			{
				mouseEventHandler2 = mouseEventHandler;
				MouseEventHandler value = (MouseEventHandler)Delegate.Combine(mouseEventHandler2, item);
				mouseEventHandler = Interlocked.CompareExchange<MouseEventHandler>(ref this.pool, value, mouseEventHandler2);
			}
			while (mouseEventHandler != mouseEventHandler2);
		}

		// Token: 0x06000096 RID: 150 RVA: 0x00008DE8 File Offset: 0x00006FE8
		[CompilerGenerated]
		public void ResolveWorker(MouseEventHandler value)
		{
			MouseEventHandler mouseEventHandler = this.pool;
			MouseEventHandler mouseEventHandler2;
			do
			{
				mouseEventHandler2 = mouseEventHandler;
				MouseEventHandler value2 = (MouseEventHandler)Delegate.Remove(mouseEventHandler2, value);
				mouseEventHandler = Interlocked.CompareExchange<MouseEventHandler>(ref this.pool, value2, mouseEventHandler2);
			}
			while (mouseEventHandler != mouseEventHandler2);
		}

		// Token: 0x06000097 RID: 151 RVA: 0x00008E20 File Offset: 0x00007020
		[CompilerGenerated]
		public void DeleteWorker(MouseEventHandler v)
		{
			MouseEventHandler mouseEventHandler = this.model;
			MouseEventHandler mouseEventHandler2;
			do
			{
				mouseEventHandler2 = mouseEventHandler;
				MouseEventHandler value = (MouseEventHandler)Delegate.Combine(mouseEventHandler2, v);
				mouseEventHandler = Interlocked.CompareExchange<MouseEventHandler>(ref this.model, value, mouseEventHandler2);
			}
			while (mouseEventHandler != mouseEventHandler2);
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00008E58 File Offset: 0x00007058
		[CompilerGenerated]
		public void RunWorker(MouseEventHandler i)
		{
			MouseEventHandler mouseEventHandler = this.model;
			MouseEventHandler mouseEventHandler2;
			do
			{
				mouseEventHandler2 = mouseEventHandler;
				MouseEventHandler value = (MouseEventHandler)Delegate.Remove(mouseEventHandler2, i);
				mouseEventHandler = Interlocked.CompareExchange<MouseEventHandler>(ref this.model, value, mouseEventHandler2);
			}
			while (mouseEventHandler != mouseEventHandler2);
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00008E90 File Offset: 0x00007090
		[CompilerGenerated]
		public void AssetWorker(MouseEventHandler i)
		{
			MouseEventHandler mouseEventHandler = this._Mapping;
			MouseEventHandler mouseEventHandler2;
			do
			{
				mouseEventHandler2 = mouseEventHandler;
				MouseEventHandler value = (MouseEventHandler)Delegate.Combine(mouseEventHandler2, i);
				mouseEventHandler = Interlocked.CompareExchange<MouseEventHandler>(ref this._Mapping, value, mouseEventHandler2);
			}
			while (mouseEventHandler != mouseEventHandler2);
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00008EC8 File Offset: 0x000070C8
		[CompilerGenerated]
		public void IncludeWorker(MouseEventHandler i)
		{
			MouseEventHandler mouseEventHandler = this._Mapping;
			MouseEventHandler mouseEventHandler2;
			do
			{
				mouseEventHandler2 = mouseEventHandler;
				MouseEventHandler value = (MouseEventHandler)Delegate.Remove(mouseEventHandler2, i);
				mouseEventHandler = Interlocked.CompareExchange<MouseEventHandler>(ref this._Mapping, value, mouseEventHandler2);
			}
			while (mouseEventHandler != mouseEventHandler2);
		}

		// Token: 0x0600009B RID: 155 RVA: 0x00008F00 File Offset: 0x00007100
		[CompilerGenerated]
		public void DefineWorker(EventHandler<Dic.InterpreterToken> instance)
		{
			EventHandler<Dic.InterpreterToken> eventHandler = this.m_Mock;
			EventHandler<Dic.InterpreterToken> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<Dic.InterpreterToken> value = (EventHandler<Dic.InterpreterToken>)Delegate.Combine(eventHandler2, instance);
				eventHandler = Interlocked.CompareExchange<EventHandler<Dic.InterpreterToken>>(ref this.m_Mock, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x0600009C RID: 156 RVA: 0x00008F38 File Offset: 0x00007138
		[CompilerGenerated]
		public void DisableWorker(EventHandler<Dic.InterpreterToken> spec)
		{
			EventHandler<Dic.InterpreterToken> eventHandler = this.m_Mock;
			EventHandler<Dic.InterpreterToken> eventHandler2;
			do
			{
				eventHandler2 = eventHandler;
				EventHandler<Dic.InterpreterToken> value = (EventHandler<Dic.InterpreterToken>)Delegate.Remove(eventHandler2, spec);
				eventHandler = Interlocked.CompareExchange<EventHandler<Dic.InterpreterToken>>(ref this.m_Mock, value, eventHandler2);
			}
			while (eventHandler != eventHandler2);
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00008F70 File Offset: 0x00007170
		[CompilerGenerated]
		public void AwakeWorker(KeyEventHandler var1)
		{
			KeyEventHandler keyEventHandler = this.writer;
			KeyEventHandler keyEventHandler2;
			do
			{
				keyEventHandler2 = keyEventHandler;
				KeyEventHandler value = (KeyEventHandler)Delegate.Combine(keyEventHandler2, var1);
				keyEventHandler = Interlocked.CompareExchange<KeyEventHandler>(ref this.writer, value, keyEventHandler2);
			}
			while (keyEventHandler != keyEventHandler2);
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00008FA8 File Offset: 0x000071A8
		[CompilerGenerated]
		public void ViewWorker(KeyEventHandler def)
		{
			KeyEventHandler keyEventHandler = this.writer;
			KeyEventHandler keyEventHandler2;
			do
			{
				keyEventHandler2 = keyEventHandler;
				KeyEventHandler value = (KeyEventHandler)Delegate.Remove(keyEventHandler2, def);
				keyEventHandler = Interlocked.CompareExchange<KeyEventHandler>(ref this.writer, value, keyEventHandler2);
			}
			while (keyEventHandler != keyEventHandler2);
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00008FE0 File Offset: 0x000071E0
		[CompilerGenerated]
		public void ManageWorker(KeyPressEventHandler def)
		{
			KeyPressEventHandler keyPressEventHandler = this.m_Info;
			KeyPressEventHandler keyPressEventHandler2;
			do
			{
				keyPressEventHandler2 = keyPressEventHandler;
				KeyPressEventHandler value = (KeyPressEventHandler)Delegate.Combine(keyPressEventHandler2, def);
				keyPressEventHandler = Interlocked.CompareExchange<KeyPressEventHandler>(ref this.m_Info, value, keyPressEventHandler2);
			}
			while (keyPressEventHandler != keyPressEventHandler2);
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00009018 File Offset: 0x00007218
		[CompilerGenerated]
		public void ResetWorker(KeyPressEventHandler reference)
		{
			KeyPressEventHandler keyPressEventHandler = this.m_Info;
			KeyPressEventHandler keyPressEventHandler2;
			do
			{
				keyPressEventHandler2 = keyPressEventHandler;
				KeyPressEventHandler value = (KeyPressEventHandler)Delegate.Remove(keyPressEventHandler2, reference);
				keyPressEventHandler = Interlocked.CompareExchange<KeyPressEventHandler>(ref this.m_Info, value, keyPressEventHandler2);
			}
			while (keyPressEventHandler != keyPressEventHandler2);
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x00009050 File Offset: 0x00007250
		[CompilerGenerated]
		public void CloneWorker(KeyEventHandler res)
		{
			KeyEventHandler keyEventHandler = this.parser;
			KeyEventHandler keyEventHandler2;
			do
			{
				keyEventHandler2 = keyEventHandler;
				KeyEventHandler value = (KeyEventHandler)Delegate.Combine(keyEventHandler2, res);
				keyEventHandler = Interlocked.CompareExchange<KeyEventHandler>(ref this.parser, value, keyEventHandler2);
			}
			while (keyEventHandler != keyEventHandler2);
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x00009088 File Offset: 0x00007288
		[CompilerGenerated]
		public void InitWorker(KeyEventHandler v)
		{
			KeyEventHandler keyEventHandler = this.parser;
			KeyEventHandler keyEventHandler2;
			do
			{
				keyEventHandler2 = keyEventHandler;
				KeyEventHandler value = (KeyEventHandler)Delegate.Remove(keyEventHandler2, v);
				keyEventHandler = Interlocked.CompareExchange<KeyEventHandler>(ref this.parser, value, keyEventHandler2);
			}
			while (keyEventHandler != keyEventHandler2);
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000282C File Offset: 0x00000A2C
		public void MoveWorker()
		{
			this.UpdateWorker(true, true);
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x000090C0 File Offset: 0x000072C0
		public void UpdateWorker(bool removevalue, bool iscaller)
		{
			if (this.int_0 == 0 && removevalue)
			{
				Dic.delegate1_0 = new Dic.Delegate1(this.method_0);
				this.int_0 = Dic.SetWindowsHookEx(14, Dic.delegate1_0, Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]), 0);
				if (this.int_0 == 0)
				{
					int lastWin32Error = Marshal.GetLastWin32Error();
					this.ReflectWorker(true, false, false);
					throw new Win32Exception(lastWin32Error);
				}
			}
			if (this.int_1 == 0 && iscaller)
			{
				Dic.delegate1_1 = new Dic.Delegate1(this.method_1);
				this.int_1 = Dic.SetWindowsHookEx(13, Dic.delegate1_1, Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]), 0);
				if (this.int_1 == 0)
				{
					int lastWin32Error2 = Marshal.GetLastWin32Error();
					this.ReflectWorker(false, true, false);
					throw new Win32Exception(lastWin32Error2);
				}
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002836 File Offset: 0x00000A36
		public void QueryWorker()
		{
			this.ReflectWorker(true, true, true);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000918C File Offset: 0x0000738C
		public void ReflectWorker(bool setinstance, bool allowsecond, bool canc)
		{
			if (this.int_0 != 0 && setinstance)
			{
				int num = Dic.UnhookWindowsHookEx(this.int_0);
				this.int_0 = 0;
				if (num == 0 && canc)
				{
					throw new Win32Exception(Marshal.GetLastWin32Error());
				}
			}
			if (this.int_1 != 0 && allowsecond)
			{
				int num2 = Dic.UnhookWindowsHookEx(this.int_1);
				this.int_1 = 0;
				if (num2 == 0 && canc)
				{
					throw new Win32Exception(Marshal.GetLastWin32Error());
				}
			}
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x000091FC File Offset: 0x000073FC
		private int method_0(int int_2, int int_3, IntPtr intptr_0)
		{
			if (int_2 >= 0 && (this._Mapping != null || this.m_Mock != null || this.filter != null || this.m_Service != null || this._Rule != null || this._Proccesor != null || this.pool != null || this.model != null))
			{
				Dic.Class4 @class = (Dic.Class4)Marshal.PtrToStructure(intptr_0, typeof(Dic.Class4));
				MouseButtons mouseButtons = MouseButtons.None;
				short delta = 0;
				switch (int_3)
				{
				case 513:
				case 514:
				case 515:
					mouseButtons = MouseButtons.Left;
					break;
				case 516:
				case 517:
				case 518:
					mouseButtons = MouseButtons.Right;
					break;
				case 522:
					delta = (short)(@class.int_0 >> 16 & 65535);
					break;
				}
				int clicks = 0;
				if (mouseButtons != MouseButtons.None)
				{
					if (int_3 != 515)
					{
						if (int_3 != 518)
						{
							clicks = 1;
							goto IL_DC;
						}
					}
					clicks = 2;
				}
				IL_DC:
				MouseEventArgs e = new MouseEventArgs(mouseButtons, clicks, @class.class2_0.int_0, @class.class2_0.int_1, (int)delta);
				Dic.InterpreterToken e2 = new Dic.InterpreterToken(int_2, int_3, intptr_0);
				if (this.filter != null)
				{
					this.filter(this, e);
				}
				if (this.m_Service != null && int_3 == 514)
				{
					this.m_Service(this, e);
				}
				if (this._Proccesor != null && int_3 == 513)
				{
					this._Proccesor(this, e);
				}
				if (this.model != null && int_3 == 512)
				{
					this.model(this, e);
				}
				if (this._Rule != null && (int_3 == 514 || int_3 == 517))
				{
					this._Rule(this, e);
				}
				if (this.pool != null && (int_3 == 513 || int_3 == 516))
				{
					this.pool(this, e);
				}
				if (this._Mapping != null && int_3 == 522)
				{
					this._Mapping(this, e);
				}
				if (this.m_Mock != null)
				{
					this.m_Mock(this, e2);
				}
			}
			return Dic.CallNextHookEx(this.int_0, int_2, int_3, intptr_0);
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00009408 File Offset: 0x00007608
		private int method_1(int int_2, int int_3, IntPtr intptr_0)
		{
			bool flag = false;
			if (int_2 >= 0 && (this.writer != null || this.parser != null || this.m_Info != null))
			{
				Dic.Class5 @class = (Dic.Class5)Marshal.PtrToStructure(intptr_0, typeof(Dic.Class5));
				if (this.writer != null && (int_3 == 256 || int_3 == 260))
				{
					KeyEventArgs keyEventArgs = new KeyEventArgs((Keys)@class.int_0);
					this.writer(this, keyEventArgs);
					flag = (flag || keyEventArgs.Handled);
				}
				if (this.m_Info != null && int_3 == 256)
				{
					bool flag2 = (Dic.GetKeyState(16) & 128) == 128;
					bool keyState = Dic.GetKeyState(20) != 0;
					byte[] byte_ = new byte[256];
					Dic.GetKeyboardState(byte_);
					byte[] array = new byte[2];
					if (Dic.ToAscii(@class.int_0, @class.int_1, byte_, array, @class.int_2) == 1)
					{
						char c = (char)array[0];
						if ((keyState ^ flag2) && char.IsLetter(c))
						{
							c = char.ToUpper(c);
						}
						KeyPressEventArgs keyPressEventArgs = new KeyPressEventArgs(c);
						this.m_Info(this, keyPressEventArgs);
						flag = (flag || keyPressEventArgs.Handled);
					}
				}
				if (this.parser != null && (int_3 == 257 || int_3 == 261))
				{
					KeyEventArgs keyEventArgs2 = new KeyEventArgs((Keys)@class.int_0);
					this.parser(this, keyEventArgs2);
					flag = (flag || keyEventArgs2.Handled);
				}
			}
			if (flag)
			{
				return 1;
			}
			return Dic.CallNextHookEx(this.int_1, int_2, int_3, intptr_0);
		}

		// Token: 0x04000058 RID: 88
		[CompilerGenerated]
		private MouseEventHandler filter;

		// Token: 0x04000059 RID: 89
		[CompilerGenerated]
		private MouseEventHandler m_Service;

		// Token: 0x0400005A RID: 90
		[CompilerGenerated]
		private MouseEventHandler _Proccesor;

		// Token: 0x0400005B RID: 91
		[CompilerGenerated]
		private MouseEventHandler _Rule;

		// Token: 0x0400005C RID: 92
		[CompilerGenerated]
		private MouseEventHandler pool;

		// Token: 0x0400005D RID: 93
		[CompilerGenerated]
		private MouseEventHandler model;

		// Token: 0x0400005E RID: 94
		[CompilerGenerated]
		private MouseEventHandler _Mapping;

		// Token: 0x0400005F RID: 95
		[CompilerGenerated]
		private EventHandler<Dic.InterpreterToken> m_Mock;

		// Token: 0x04000060 RID: 96
		[CompilerGenerated]
		private KeyEventHandler writer;

		// Token: 0x04000061 RID: 97
		[CompilerGenerated]
		private KeyPressEventHandler m_Info;

		// Token: 0x04000062 RID: 98
		[CompilerGenerated]
		private KeyEventHandler parser;

		// Token: 0x04000063 RID: 99
		private int int_0;

		// Token: 0x04000064 RID: 100
		private int int_1;

		// Token: 0x04000065 RID: 101
		private static Dic.Delegate1 delegate1_0;

		// Token: 0x04000066 RID: 102
		private static Dic.Delegate1 delegate1_1;

		// Token: 0x02000016 RID: 22
		[StructLayout(LayoutKind.Sequential)]
		private class Class2
		{
			// Token: 0x060000A9 RID: 169 RVA: 0x00002354 File Offset: 0x00000554
			public Class2()
			{
				Class21.smethod_0();
				base..ctor();
			}

			// Token: 0x04000067 RID: 103
			public int int_0;

			// Token: 0x04000068 RID: 104
			public int int_1;
		}

		// Token: 0x02000017 RID: 23
		public class InterpreterToken : EventArgs
		{
			// Token: 0x060000AA RID: 170 RVA: 0x00002841 File Offset: 0x00000A41
			public InterpreterToken(int var1_min, int rowattr, IntPtr pool)
			{
				Class21.smethod_0();
				base..ctor();
				this.DeleteDescriptor(var1_min);
				this.AssetDescriptor(rowattr);
				this.DefineDescriptor(pool);
			}

			// Token: 0x060000AB RID: 171 RVA: 0x00002863 File Offset: 0x00000A63
			[CompilerGenerated]
			public int RegisterDescriptor()
			{
				return this.m_FacadeToken;
			}

			// Token: 0x060000AC RID: 172 RVA: 0x0000286B File Offset: 0x00000A6B
			[CompilerGenerated]
			public void DeleteDescriptor(int sum_item)
			{
				this.m_FacadeToken = sum_item;
			}

			// Token: 0x060000AD RID: 173 RVA: 0x00002874 File Offset: 0x00000A74
			[CompilerGenerated]
			public int ChangeDescriptor()
			{
				return this.accountToken;
			}

			// Token: 0x060000AE RID: 174 RVA: 0x0000287C File Offset: 0x00000A7C
			[CompilerGenerated]
			public void AssetDescriptor(int position_instance)
			{
				this.accountToken = position_instance;
			}

			// Token: 0x060000AF RID: 175 RVA: 0x00002885 File Offset: 0x00000A85
			[CompilerGenerated]
			public IntPtr NewDescriptor()
			{
				return this.m_WrapperToken;
			}

			// Token: 0x060000B0 RID: 176 RVA: 0x0000288D File Offset: 0x00000A8D
			[CompilerGenerated]
			public void DefineDescriptor(IntPtr key)
			{
				this.m_WrapperToken = key;
			}

			// Token: 0x04000069 RID: 105
			[CompilerGenerated]
			private int m_FacadeToken;

			// Token: 0x0400006A RID: 106
			[CompilerGenerated]
			private int accountToken;

			// Token: 0x0400006B RID: 107
			[CompilerGenerated]
			private IntPtr m_WrapperToken;
		}

		// Token: 0x02000018 RID: 24
		[StructLayout(LayoutKind.Sequential)]
		private class Class3
		{
			// Token: 0x060000B1 RID: 177 RVA: 0x00002354 File Offset: 0x00000554
			public Class3()
			{
				Class21.smethod_0();
				base..ctor();
			}

			// Token: 0x0400006C RID: 108
			public Dic.Class2 class2_0;

			// Token: 0x0400006D RID: 109
			public int int_0;

			// Token: 0x0400006E RID: 110
			public int int_1;

			// Token: 0x0400006F RID: 111
			public int int_2;
		}

		// Token: 0x02000019 RID: 25
		[StructLayout(LayoutKind.Sequential)]
		private class Class4
		{
			// Token: 0x060000B2 RID: 178 RVA: 0x00002354 File Offset: 0x00000554
			public Class4()
			{
				Class21.smethod_0();
				base..ctor();
			}

			// Token: 0x04000070 RID: 112
			public Dic.Class2 class2_0;

			// Token: 0x04000071 RID: 113
			public int int_0;

			// Token: 0x04000072 RID: 114
			public int int_1;

			// Token: 0x04000073 RID: 115
			public int int_2;

			// Token: 0x04000074 RID: 116
			public int int_3;
		}

		// Token: 0x0200001A RID: 26
		[StructLayout(LayoutKind.Sequential)]
		private class Class5
		{
			// Token: 0x060000B3 RID: 179 RVA: 0x00002354 File Offset: 0x00000554
			public Class5()
			{
				Class21.smethod_0();
				base..ctor();
			}

			// Token: 0x04000075 RID: 117
			public int int_0;

			// Token: 0x04000076 RID: 118
			public int int_1;

			// Token: 0x04000077 RID: 119
			public int int_2;

			// Token: 0x04000078 RID: 120
			public int int_3;

			// Token: 0x04000079 RID: 121
			public int int_4;
		}

		// Token: 0x0200001B RID: 27
		// (Invoke) Token: 0x060000B5 RID: 181
		private delegate int Delegate1(int nCode, int wParam, IntPtr lParam);
	}
}
